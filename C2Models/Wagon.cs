using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2Models
{
    public class Wagon
    {
        public List<Animal> Animals { get; } = new List<Animal>();
        public int AvailableCapacity => 10 - Animals.Sum(animal => animal.GetPoints());

        public bool CanAddAnimal(Animal animal)
        {
            bool withinCapacity = AvailableCapacity >= animal.GetPoints();

            bool hasCarnivoreConflict = Animals.Any(a => a.Type == AnimalType.Carnivore && a.Size >= animal.Size);

            return !hasCarnivoreConflict && withinCapacity;
        }

        public bool AddAnimal(Animal animal)
        {
            if (CanAddAnimal(animal))
            {
                Animals.Add(animal);
                return true;
            }
            return false;
        }

       
    }
}
