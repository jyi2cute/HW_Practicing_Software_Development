﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Linq;


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
        static Dictionary<string, object> animalList = new Dictionary<string, object>();

        public static void add(int ID, string name, int age, string breed)
        {
            //Error handling
            try
            {
                Pet newAnimal = new Pet(ID, age, name, breed);
                animalList.Add(name, newAnimal);
                Console.WriteLine($"Successfully added pet: {name}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: Pet with name '{name}' already exists. {ex.Message}");
            }
        }

        public static void remove(string name)
        {
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
            int genID = 1000;//Pet ID that will update which each added pet
            string userInp = "";

            Console.WriteLine("Welcome to the Animal Shelter!");



            //Using object/constructor
            Pet myPet = new Pet(1462, 4, "Max", "Husky", "Black and White", true);
            add(genID, myPet.Name, myPet.Age, myPet.Breed);
            genID++;
            Console.WriteLine($"Key: {myPet.Name}, Age: {animalList["Max"]}");
            //Create While Loop That Allows User to Use Methods and Exits when done

            while (userInp != "Leave")
            {
                Console.WriteLine("\nWhat would you like to do?");
                
                Console.WriteLine("Choose to: Adopt, Return, Learn, Browse, Leave");
                userInp = Console.ReadLine();
                //Will determine what method user requested based on first letter given, upercasing it for extra certainty
                //Will also cycle through again if user types incorect value
                //Return will use add feature
                if (userInp.ToUpper().Equals("RETURN"))
                {
                    Console.WriteLine("What's their name?");
                    string tempName = Console.ReadLine();
                    Console.WriteLine("How old are they?"); 
                    int tempAge = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("User didn't give an integer value");
                    Console.WriteLine("Do you know the breed of this little guy?");
                    string tempBreed = Console.ReadLine();
                    add(genID, tempName, tempAge, tempBreed);

                    Console.WriteLine($"We'll take great care of {tempName}");
                    genID++;
                }
                //Adopt will use the remove feature
                else if (userInp.ToUpper().Equals("ADOPT"))
                {

                    while (!animalList.ContainsKey(userInp) && !userInp.ToUpper().Equals("EXIT"))
                    {
                        //Which Pet
                        Console.WriteLine("\nWhich Pet did you want? We have: ");

                        foreach (var pet in animalList.Keys)
                        {
                            Console.WriteLine(pet);
                        }
                        Console.WriteLine("*case sensitive");
                        userInp = Console.ReadLine();
                        //If user types animal name correctly, remove from Dictionary annd add to ID just cause
                        if (animalList.ContainsKey(userInp))
                        {
                            remove(userInp);
                            Console.WriteLine("We're sad to see him go");
                            genID++;
                        }
                        else if (userInp.ToUpper().Equals("EXIT")) { //Return to Main Menu
                            Console.WriteLine("Returning to Main Menu");    
                        }
                        else {
                            Console.WriteLine("Be sure to type in the EXACT name of the pet!");
                        }
                    }
                }

                //Learn the pet will use the inspect function
                else if (userInp.ToUpper().Equals("LEARN"))
                {

                    genID++;
                }
                //Browse list the whole dictionary
                else if (userInp.ToUpper().Equals("BROWSE"))
                {
                    Console.WriteLine("We have a lot of Pets!");
                    foreach (var pets in animalList.Values)
                    {
                        //Console.WriteLine($"We have: {pets.Name}");
                    }
                }
            }
        }

    }

}
