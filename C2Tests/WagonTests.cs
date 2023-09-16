using C2Models;

namespace C2Tests
{
    [TestClass]
    public class WagonTests
    {
        [TestMethod]
        public void TestCanAddAnimal_ValidAnimal()
        {
         
            var wagon = new Wagon();
            var animal = new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Small };

            bool canAdd = wagon.CanAddAnimal(animal);

            Assert.IsTrue(canAdd);
        }

        [TestMethod]
        public void TestCanAddAnimal_ExceedsCapacity()
        {
            var wagon = new Wagon();
            var animal1 = new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Large };
            var animal2 = new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Medium };

            wagon.AddAnimal(animal1);
            wagon.AddAnimal(animal2);


            bool canAdd = wagon.CanAddAnimal(animal2);

            Assert.IsFalse(canAdd);
        }

        [TestMethod]
        public void TestCanAddAnimal_CarnivoreConflict()
        {
            var wagon = new Wagon();
            var herbivore = new Animal { Type = AnimalType.Herbivore, Size = AnimalSize.Medium };
            var carnivore = new Animal { Type = AnimalType.Carnivore, Size = AnimalSize.Medium };

            wagon.AddAnimal(carnivore);

            bool canAdd = wagon.CanAddAnimal(herbivore);
      
            Assert.IsFalse(canAdd);
        }

        
    }
}