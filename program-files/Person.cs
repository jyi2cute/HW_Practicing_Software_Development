using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal_shelter
{
    public class Person
    {
        // getters and setters, probably does not need both
        public int PersonID { get; set; }
        public string Name { get; set; }
        public bool HasKids { get; set; }
        public string PreferredSpecies { get; set; }
        public bool OtherPets { get; set; }

        // person object
        public Person(int personID, string name, bool hasKids, string preferredSpecies, bool otherPets)
        {   // int for tracking's sake
            PersonID = personID;
            // maybe irrelevant, unless use in call text
            Name = name;
            // boolean y/n, helps with filtering
            HasKids = hasKids;
            // string for preferred species MUST BE LOWERCASE ALWAYS
            PreferredSpecies = preferredSpecies;
            // y/n
            OtherPets = otherPets;
        }
    }
}
