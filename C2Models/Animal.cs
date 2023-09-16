using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2Models
{
    public class Animal
    {
       
        public AnimalType Type { get; set; }
        public AnimalSize Size { get; set; }

        public int GetPoints()
        {
            switch (Size)
            {
                case AnimalSize.Small:
                    return 1;
                case AnimalSize.Medium:
                    return 3;
                case AnimalSize.Large:
                    return 5;
                default:
                    return 0; 
            }
        }
    }

    public enum AnimalType
    {
        Herbivore,
        Carnivore
    }

    public enum AnimalSize
    {
        Small,
        Medium,
        Large
    }


}
