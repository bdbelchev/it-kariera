using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class StoreController
{
    private List<Store> stores;

    public StoreController()
    {
        this.stores = new List<Store>();
    }

    public string CreateStore(List<string> args)
    {
        string name = args[0];
        string type = args[1];

        Store store = GetStore(name);

        if (store != null)
        {
            return $"Store {name} is already registered!";
        }

        store = new Store(name, type);
        stores.Add(store);

        return $"Store {name} was successfully registerd in the system!";
    }

    public string ReceiveProduct(List<string> args)
    {
        string type = args[0];
        string name = args[1];
        int quantity = int.Parse(args[2]);
        double deliverPrice = double.Parse(args[3]);
        double percentageMarkup = double.Parse(args[4]);
        string storeName = args[5];

        Store store = GetStore(storeName);

        if (store == null)
        {
            return $"Invalid Store: {storeName}. Cannot find it in system!";
        }

        Product product = null;

        switch (type)
        {
            case "Food":
                product = new Food(name, quantity, deliverPrice, percentageMarkup);
                break;
            case "Drink":
                product = new Drink(name, quantity, deliverPrice, percentageMarkup);
                break;
            default:
                return $"Product {type} is invalid!";
        }

        bool isReceived = store.ReceiveProduct(product);

        if (!isReceived)
        {
            return $"Product {name} was already delivered to {storeName}!";
        }

        return $"Product {name} was successfully delivered to {storeName}!";
    }

    public string SellProduct(List<string> args)
    {
        string name = args[0];
        int quantity = int.Parse(args[1]);
        string storeName = args[2];

        Store store = GetStore(storeName);

        if (store == null)
        {
            return $"Invalid Store: {storeName}. Cannot find it in system!";
        }

        bool wasSold = store.SellProduct(name, quantity);

        if (!wasSold)
        {
            return $"Product {name} was already sold out!";
        }

        return $"Product {name} was successfully bought from {storeName}!";
    }

    public string StoreInfo(List<string> args)
    {
        string storeName = args[0];

        Store store = GetStore(storeName);

        if (store == null)
        {
            return $"Invalid Store: {storeName}. Cannot find it in system!";
        }

        return store.ToString();
    }

    public string Shutdown()
    {
        double totalRevenue = 0;
        List<Store> sortedStores = stores
            .OrderByDescending(store => store.Revenue)
            .ThenBy(store => store.Name)
            .ToList();

        StringBuilder builder = new StringBuilder();

        builder.AppendLine($"Stores: {stores.Count}");
        sortedStores.ForEach(store =>
        {
            totalRevenue += store.Revenue;
            List<string> args = new List<string>
            {
                    store.Name
            };

            builder.AppendLine(StoreInfo(args));
        });
        builder.AppendLine($"System Store Revenues: {totalRevenue:F2}BGN");

        return builder.ToString().Trim();
    }

    private Store GetStore(string name)
    {
        return stores.FirstOrDefault(store => store.Name == name);
    }
}
