using System;

namespace _01._ValidPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pesho = new Person("Pesho", "Peshev", 24);

            try
            {
                Person noName = new Person(string.Empty, "Goshev", 31);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Person noLastName = new Person("Ivan", null, 63);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Person negativeAge = new Person("Stoyan", "Kolev", -1);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Person tooOld = new Person("Iskren", "Ivanov", 121);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
