using System;

class Program
{
    static void Main(string[] args)
    {
        StoreController controller = new StoreController();
        Engine engine = new Engine(controller);
        engine.Run();
    }
}
