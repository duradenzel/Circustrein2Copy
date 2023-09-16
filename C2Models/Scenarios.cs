using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2Models
{

    public static class Scenarios
    {
        public static List<Animal> Scenario1()
        {
            return new List<Animal>
            {
                new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Small },

                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Medium },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Medium },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Medium },

                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Large },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Large },
            
            };
        }

        public static List<Animal> Scenario2()
        {
            return new List<Animal>
            {
                new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Small },

                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Small },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Small },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Small },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Small },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Small },

                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Medium },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Medium },

                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Large },

            };
        }

        public static List<Animal> Scenario3()
        {
            return new List<Animal>
            {
                new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Small },
                new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Medium },
                new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Large },

                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Small },           
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Medium },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Large },

            };
        }
        public static List<Animal> Scenario4()
        {
            return new List<Animal>
            {
                new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Small },
                new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Small },
                new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Medium },
                new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Large },

                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Small },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Medium },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Medium },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Medium },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Medium },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Medium },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Large },

            };
        }

        public static List<Animal> Scenario5()
        {
            return new List<Animal>
            {
                new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Small },
            
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Small },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Medium },             
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Large },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Large },

            };
        }

        public static List<Animal> Scenario6()
        {
            return new List<Animal>
            {
                new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Small },
                new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Small },
                new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Small },

                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Medium },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Medium },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Large },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Large },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Large },

            };
        }

        public static List<Animal> Scenario7()
        {
            return new List<Animal>
            {
                new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Small },
                new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Small },
                new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Small },
                new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Small },
                new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Small },
                new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Small },
                new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Small },
                new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Medium },
                new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Medium },
                new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Medium },
                new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Large },
                new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Large },
                new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Large },

                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Medium },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Medium },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Medium },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Medium },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Medium },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Large },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Large },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Large },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Large },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Large },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Large },

            };
        }

        public static List<Animal> Scenario8()
        {
            return new List<Animal>
            {
              
            };
        }

        public static List<Animal> CarnivoresOnly()
        {
            return new List<Animal>
            {
                new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Small },
                new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Medium },
                new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Medium },
                new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Medium },
                new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Large },
            };
        }

        public static List<Animal> HerbivoresOnly()
        {
            return new List<Animal>
            {
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Medium },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Medium },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Medium },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Large },
                new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Large },
            };
        }


    }

}
