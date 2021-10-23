using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StoreController
{
    private List<Store> stores;

    public StoreController()
    {
        stores = new List<Store>();
    }

    public string CreateStore(List<string> args)
    {
        string name = args[0];
        string type = args[1];

        if (GetStore(name) == null)
        {
            stores.Add(new Store(name, type));
            return $"Store {name} was successfully registered in the system!";
        }

        return $"Store {name} is already registered!";
    }

    public string ReceiveProduct(List<string> args)
    {
        string type = args[0];
        string name = args[1];
        int quantity = int.Parse(args[2]);
        double price = double.Parse(args[3]);
        double percentageMarkup = double.Parse(args[4]);
        string storeName = args[5];

        Store store = GetStore(storeName);

        if (store == null)
        {
            return $"Invalid Store: {storeName}. Cannot find it in system!";
        }

        Product product = store.GetProduct(name);

        switch (type)
        {
            case "Food":
                product = new Food(name, quantity, price, percentageMarkup);
                break;
            case "Drink":
                product = new Drink(name, quantity, price, percentageMarkup);
                break;
            default:
                return $"Product {type} is invalid!";
        }

        return store.ReceiveProduct(product) ? $"Product {name} was successfully delivered to {storeName}!" : $"Product {name} was already delivered to {storeName}!";
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

        return store.SellProduct(name, quantity) ? $"Product {name} was successfully bought from {storeName}!" : $"Product {name} was already sold out!";
    }

    public string StoreInfo(List<string> args)
    {
        string storeName = args[0];

        Store store = GetStore(storeName);

        return store == null ? $"Invalid Store: {storeName}. Cannot find it in system!" : store.ToString();
    }

    public string Shutdown()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"Stores: {stores.Count}");

        foreach (Store store in stores.OrderByDescending(s => s.Revenue).ThenBy(s => s.Name))
        {
            sb.AppendLine(store.ToString());
        }

        sb.AppendLine($"System Store Revenues: {stores.Sum(s => s.Revenue):F2}BGN");

        return sb.ToString().Trim();
    }

    private Store GetStore(string name)
    {
        return stores.FirstOrDefault(s => s.Name == name);
    }
}
