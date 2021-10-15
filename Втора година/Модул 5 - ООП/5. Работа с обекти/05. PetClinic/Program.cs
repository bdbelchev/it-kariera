using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._PetClinic
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Pet> pets = new Dictionary<string, Pet>();
            Dictionary<string, Clinic> clinics = new Dictionary<string, Clinic>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                switch (command[0])
                {
                    case "Create":
                        switch (command[1])
                        {
                            case "Pet":
                                Console.WriteLine(CreatePet(pets, command[2], int.Parse(command[3]), command[4]));
                                break;
                            case "Clinic":
                                CreateClinic(clinics, command[2], int.Parse(command[3]));
                                break;
                        }
                        break;
                    case "Add":
                        Console.WriteLine(clinics[command[2]].Add(pets[command[1]]));
                        break;
                    case "Release":
                        Console.WriteLine(clinics[command[1]].Release());
                        break;
                    case "HasEmptyRooms":
                        Console.WriteLine(clinics[command[1]].HasEmptyRooms());
                        break;
                    case "Print":
                        if (command.Length > 2)
                        {
                            clinics[command[1]].Print(int.Parse(command[2]));
                        }
                        else
                        {
                            clinics[command[1]].Print();
                        }
                        break;
                }
            }
        }

        private static void CreateClinic(Dictionary<string, Clinic> clinics, string name, int rooms)
        {
            try
            {
                Clinic clinic = new Clinic(name, rooms);
                clinics.Add(name, clinic);
            }
            catch
            {
                Console.WriteLine("Invalid Operation!");
            }
        }

        private static bool CreatePet(Dictionary<string, Pet> pets, string name, int age, string species)
        {
            try
            {
                Pet pet = new Pet(name, age, species);
                pets.Add(name, pet);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
