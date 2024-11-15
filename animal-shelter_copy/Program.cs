using System.Collections.Generic;
using System.ComponentModel;


namespace animal_shelter
{



    internal class Program
    {
        
        

        //the dog class or the general pet class 
        class Pet
        {
            public int age;
            public string name;
            public string breed;

            //Pet constructor
            //Added in the pet constructor - Jin 
            public Pet(int age, string name, string breed)
            {
                this.age = age;
                this.name = name;
                this.breed = breed;
            }

        }

        //the person class 
        class Person()
        {
            public int age;
            public string name;

            //person constructor
          

        }

        //Making an empty dictionary with the name as the key to the Pet object
        Dictionary<string, object> animalList = new Dictionary<string, object>();

        void add(string name, int age, string breed) {
            //error handling
            try
            {
                Pet newAnimal = new Pet(age, name, breed);
                animalList.Add(name, newAnimal);
                Console.WriteLine($"Successfully added pet: {name}");
            } catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: Pet with name '{name}' already exists. {ex.Message}");
            }
        }

        void remove(string name) {
            //error handling
            if (animalList.ContainsKey(name))
            {
                animalList.Remove(name);
                Console.WriteLine($"Successfully removed pet: {name}");
            } 
            else
            {
                Console.WriteLine($"Error: Pet with '{name}' not found.");

            }
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Animal Shelter!");

           
        }

    }
}
