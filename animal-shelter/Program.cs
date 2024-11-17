using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Linq;


namespace animal_shelter
{



    internal class Program
    {
        //Making an empty dictionary with the name as the key to the Pet object
        static Dictionary<string, Pet> animalList = new Dictionary<string, Pet>();

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
            //added more pets
            Pet myPet = new Pet(1462, 4, "Max", "Husky", "Black and White", true);
            Pet myPet = new Pet(1256, 8, "Buddy", "Bulldog", "Gray", false);
            Pet myPet = new Pet(1600, 2, "Coco", "Maltipoo", "Brown", true);
            Pet myPet = new Pet(6892, 10, "Teddy", "German Shepherd", true);
            Pet myPet = new Pet(9003, 6, "Luna", "Chihuahua", false);
            add(genID, myPet.Name, myPet.Age, myPet.Breed);


            genID++;

            //Console.WriteLine($"Key: {myPet.Name}, Age: {animalList["Max"].Age}"); 

            //Create While Loop That Allows User to Use Methods and Exits when done
            while (!userInp.ToUpper().Equals("LEAVE"))
            {
                Console.WriteLine("\nWhat would you like to do?");

                Console.WriteLine("Choose to: Adopt, Return, Learn, Browse, Leave");
                userInp = Console.ReadLine();
                //Will determine what method user requested based on first letter given, upercasing it for extra certainty
                //Will also cycle through again if user types incorect value
                //Return will use add feature
                if (userInp.ToUpper().Equals("RETURN"))
                {
                    /* RETURN
                     * Won't ask for last two details in Pet Object of color and friendliness
                     * Default Constructor made specifically to randomly generate those last to values
                     */
                    Console.WriteLine("What's their name?");
                    string tempName = Console.ReadLine();
                    Console.WriteLine("How old are they?");
                    int tempAge = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Do you know the breed of this little guy?");
                    string tempBreed = Console.ReadLine();
                    add(genID, tempName, tempAge, tempBreed);

                    Console.WriteLine($"We'll take great care of {tempName}");
                    genID++;
                }
                //Adopt will use the remove feature
                else if (userInp.ToUpper().Equals("ADOPT"))
                {
                    /* ADOPT
                     * Will simply remove Pet from function unless match function is added later
                     * Default Constructor made specifically to randomly generate those last to values
                     */
                    while (!animalList.ContainsKey(userInp) && !userInp.ToUpper().Equals("EXIT"))
                    {
                        //Initally checks to see if any pets are in the shelter
                        if (animalList.Count == 0)
                        {
                            Thread.Sleep(1000);//Just a brief wait to signify transition
                            Console.WriteLine("\nWe don't have anymore Pets at this time...\nReturning to Menu");
                            userInp = "EXIT";
                        }
                        else
                        {
                            //Which Pet
                            Console.WriteLine("\nWhich Pet did you want? We have: ");

                            foreach (var pet in animalList.Keys)
                            {
                                Console.WriteLine(pet);
                            }

                            Console.WriteLine("*case sensitive*");
                            Console.WriteLine("\nType 'exit' to go back");
                            userInp = Console.ReadLine();
                            //If user types animal name correctly, remove from Dictionary and add to ID just to ensure no overlap
                            if (animalList.ContainsKey(userInp))
                            {
                                remove(userInp);
                                Console.WriteLine("We're sad to see him go");
                                genID++;
                            }
                            else if (userInp.ToUpper().Equals("EXIT"))
                            { //Return to Main Menu
                                Console.WriteLine("Returning to Main Menu");
                            }
                            else
                            {
                                Console.WriteLine("Be sure to type in the EXACT name of the pet!");
                            }
                        }

                    }
                }

                //Learn the pet will use the inspect function
                else if (userInp.ToUpper().Equals("LEARN") && !userInp.ToUpper().Equals("EXIT"))
                {
                    /* LEARN
                     * Will simply inspect Pet with void function generating string about the pet chosen 
                     * Displays all details of the Pet including friendliness and color
                     */
                    while (!animalList.ContainsKey(userInp) && !userInp.ToUpper().Equals("EXIT"))
                    {
                        //Initally checks to see if any pets are in the shelter
                        if (animalList.Count == 0)
                        {
                            Thread.Sleep(1000);//Just a brief wait to signify transition
                            Console.WriteLine("\nWe don't have anymore Pets at this time...\nReturning to Menu");
                            userInp = "EXIT";
                        }
                        else
                        {
                            //Which Pet
                            Console.WriteLine("\nWhich Pet did you want to learn about? We have: ");

                            foreach (var pet in animalList.Keys)
                            {
                                Console.WriteLine(pet);
                            }

                            Console.WriteLine("*case sensitive*");
                            Console.WriteLine("\nType 'exit' to go back");
                            userInp = Console.ReadLine();
                            //If user types animal name correctly, remove from Dictionary annd add to ID just cause
                            if (animalList.ContainsKey(userInp))
                            {
                                //inspect function which is essentially just a ToString
                                Console.WriteLine(animalList[userInp]);
                                Thread.Sleep(1000);
                            }
                            else if (userInp.ToUpper().Equals("EXIT"))
                            { //Return to Main Menu
                                Console.WriteLine("Returning to Main Menu");
                            }
                            else
                            {
                                Console.WriteLine("Be sure to type in the EXACT name of the pet!");
                            }
                        }
                    }

                }
                //Browse list the to glance through the whole dictionary and its objects
                else if (userInp.ToUpper().Equals("BROWSE"))
                {
                    /* BROWSE
                     * Will browse through all of the dictionary briefly 
                     * Think window shopping as opposed to actually adopting and learning about the Pet
                     */
                    Console.WriteLine("\nWe have a lot of Pets!");
                    foreach (var pets in animalList.Values)
                    {
                        Console.WriteLine($"We have: {pets.Name} and they're a {pets.Breed}");
                    }
                }
            }

            //Code has been ended, user typed Leave
            Console.WriteLine("\nWe hope you enjoyed your experience!");
            Thread.Sleep(5000);

        }

    }

}
