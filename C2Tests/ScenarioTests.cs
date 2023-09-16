using C2Models;

namespace C2Tests
{
    [TestClass]
    public class ScenarioTests
    {
        [TestMethod]
        public void Scenario1_ValidInput()
        {        
            var sorter = new AnimalSorter();
            var animals = Scenarios.Scenario1(); 
      
            var result = sorter.SortAnimals(animals);  

            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void Scenario2_ValidInput()
        {
            var sorter = new AnimalSorter();
            var animals = Scenarios.Scenario2();

            var result = sorter.SortAnimals(animals);

            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void Scenario3_ValidInput()
        {
            var sorter = new AnimalSorter();
            var animals = Scenarios.Scenario3();

            var result = sorter.SortAnimals(animals);

            Assert.AreEqual(4, result.Count);
        }

        [TestMethod]
        public void Scenario4_ValidInput()
        {
            var sorter = new AnimalSorter();
            var animals = Scenarios.Scenario4();

            var result = sorter.SortAnimals(animals);

            Assert.AreEqual(5, result.Count);
        }

        [TestMethod]
        public void Scenario5_ValidInput()
        {
            var sorter = new AnimalSorter();
            var animals = Scenarios.Scenario5();

            var result = sorter.SortAnimals(animals);

            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void Scenario6_ValidInput()
        {
            var sorter = new AnimalSorter();
            var animals = Scenarios.Scenario6();

            var result = sorter.SortAnimals(animals);

            Assert.AreEqual(3, result.Count);
        }

        [TestMethod]
        public void Scenario7_ValidInput()
        {
            var sorter = new AnimalSorter();
            var animals = Scenarios.Scenario7();

            var result = sorter.SortAnimals(animals);

            Assert.AreEqual(13, result.Count);
        }

        [TestMethod]
        public void Scenario8_ValidInput()
        {
            var sorter = new AnimalSorter();
            var animals = Scenarios.Scenario8();

            var result = sorter.SortAnimals(animals);

            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void Scenario_CarnivoresOnly()
        {
            var sorter = new AnimalSorter();
            var animals = Scenarios.CarnivoresOnly();

            var result = sorter.SortAnimals(animals);

            Assert.AreEqual(5, result.Count);
        }

        [TestMethod]
        public void Scenario_HerbivoresOnly()
        {
            var sorter = new AnimalSorter();
            var animals = Scenarios.HerbivoresOnly();

            var result = sorter.SortAnimals(animals);

            Assert.AreEqual(2, result.Count);
        }

    }
}