public class StartUp
{
    public static void Main(string[] args)
    {
        StoreController storeController = new StoreController();
        Engine engine = new Engine(storeController);
        engine.Run();
    }
}
