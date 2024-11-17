using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal_shelter
{
    public class Pet
    {


        //constructor
        public int PetID { get; set; }
        public string Age { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public bool PetFriendly { get; set; }

        //pet object
        public Pet(int petID, string age, string name, string breed, string color, bool petfriendly)
        {
            //Pet ID
            PetID = petID;
            //Pet's age
            Age = age;
            //Pet's name
            Name = name;
            //Pet's breed or species
            Breed = breed;
            //Pet's color
            Color = color;

            //If the pet is friendly or not
            PetFriendly = petfriendly;
        }
        public Pet(int petID, string age, string name, string breed)
        {
            //Pet ID
            PetID = petID;
            //Pet's age
            Age = age;
            //Pet's name
            Name = name;
            //Pet's breed or species
            Breed = breed;
            //Pet's color
            Random rand = new Random();
            int randVal = rand.Next(0, 4);
            string[] colorBase = ["Black", "Black and White", "Beige", "White", "Gray"];

            this.Color = colorBase[randVal];
            //Choose Boolean Value
            randVal = rand.Next(0, 2);

            //If the pet is friendly or not
            if (randVal == 1)
            {
                this.PetFriendly = true;
            }
            else
            {
                this.PetFriendly = false;
            }
        }
        public override string ToString()
        {
            if (PetFriendly)
            {
                return (Name + " is " + Age + " and a " + Breed + ". They're very friendly and have a " + Color + " coat.");
            }
            else
            {
                return (Name + " is " + Age + " and a " + Breed + ". They're not too friendly and have a " + Color + " coat.");
            }
        }

    }
}