using System;
using System.Reflection;

namespace _01._DefinePerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Type personType = typeof (Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);

            Person person1 = new Person();
            Person person2 = new Person();
            Person person3 = new Person();

            person1.name = "Pesho";
            person1.age = 20;
            person2.name = "Gosho";
            person2.age = 18;
            person3.name = "Stamat";
            person3.age = 43;
        }
    }
}
