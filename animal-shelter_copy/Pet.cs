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
        public int Age { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public bool PetFriendly { get set};

        //pet object
        public Pet(int petID, int age, string name, string breed, string color, bool petfriendly)
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
    }
}