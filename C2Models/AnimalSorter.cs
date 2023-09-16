using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2Models
{
    public class AnimalSorter
    {
        public List<Wagon> SortAnimals(List<Animal> animals)
        {
            
            var smallestFirst = Sort(animals.OrderBy(a => a.Size).ToList());   
            var largestFirst = Sort(animals.OrderByDescending(a => a.Size).ToList());
      
            return smallestFirst.Count <= largestFirst.Count ? smallestFirst : largestFirst;
        }

        private List<Wagon> Sort(List<Animal> animals)
        {
            List<Wagon> wagons = new List<Wagon>();

            var carnivores = animals.Where(a => a.Type == AnimalType.Carnivore).ToList();
            var herbivores = animals.Where(a => a.Type == AnimalType.Herbivore).ToList();

            carnivores = carnivores.OrderByDescending(a => a.Size).ToList();

            foreach (var carnivore in carnivores)
            {
                var newWagon = new Wagon();
                newWagon.AddAnimal(carnivore);
                wagons.Add(newWagon);
            }

            foreach (var herbivore in herbivores)
            {
                bool added = false;
                foreach (var wagon in wagons)
                {
                    if (wagon.CanAddAnimal(herbivore))
                    {
                        wagon.AddAnimal(herbivore);
                        added = true;
                        break;
                    }
                }

                if (!added)
                {
                    var newWagon = new Wagon();
                    newWagon.AddAnimal(herbivore);
                    wagons.Add(newWagon);
                }
            }

            return wagons;
        }
    }


}
