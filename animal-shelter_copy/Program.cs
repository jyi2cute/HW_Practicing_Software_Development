using System.Collections.Generic;
using System.ComponentModel;


namespace animal_shelter
{



    internal class Program
    {
        
        

        //the dog class or the general pet class 
        /*class Pet
        {
            public int petID;
            public int age;
            public string name;
            public string breed;
            public string color;
            public bool petfriendly;

            //Pet constructor
            //Update: moved this to a new file
            //Added in the pet constructor - Jin 
            //public Pet(int age, string name, string breed)
            //{
            //    this.age = age;
            //    this.name = name;
            //    this.breed = breed;
            //}

        }*/

        //the person class 
        /*class Person()
        {
            public int age;
            public string name;

            //person constructor
          

        }*/

        //Making an empty dictionary with the name as the key to the Pet object
        Dictionary<string, object> animalList = new Dictionary<string, object>();

        void add(string name, int age, string breed) {
            //Error handling
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
            //Error handling
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
            int genID = 1000;
            string userInp = "";

            Console.WriteLine("Welcome to the Animal Shelter!");



            //Using object/constructor
            Pet myPet = new Pet(1462, 4, "Max", "Husky", "Black and White", true);

            //Create While Loop That Allows User to Use Methods and Exits when done
            Console.WriteLine("\nWhat would you like to do?");
            while(userInp != "Leave")
            {
                userInp = Console.ReadLine();
            //Will determine what method user requested based on first letter given, upercasing it for extra certainty
            //Will also cycle through again if user types incorect value
                //Return will use add feature
                if (userInp.ToUpper().StartsWith("R"))
                {

                    genID++;
                }
                //Adopt will use the remove feature
                else if (userInp.ToUpper().StartsWith("A"))
                {

                    genID++;
                }
                //Learn the pet will use the inspect function
                if (userInp.ToUpper().StartsWith("L"))
                {

                    genID++;
                }

            }
            
        }

    }
}
