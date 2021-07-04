using DeepAndShallowCopy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DeepAndShallowCopy.Monster;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAssignmentOperator()
        {
            string Name = "Ryan Monster";
            int Age = 25;
            FurColor furColor = FurColor.BLUE;

            Monster MonsterOne = new Monster(Name, Age, furColor);
            Monster MonsterTwo = MonsterOne;

            MonsterOne.Name = "Generic";
            MonsterOne.Age = 26;

            Assert.AreNotEqual(Name, MonsterTwo.Name);
            Assert.AreNotEqual(Age, MonsterTwo.Age);

        }

        [TestMethod]
        public void TestShallowCopy()
        {

            string Name = "Ryan Monster";
            int Age = 25;
            FurColor furColor = FurColor.BLUE;

            Monster MonsterOne = new Monster(Name, Age, furColor);
            Monster MonsterTwo = MonsterOne.ShallowCopy();

            MonsterOne.Name = "Generic";
            MonsterOne.Age = 26;

            Assert.AreEqual(Name, MonsterTwo.Name);
            Assert.AreEqual(Age, MonsterTwo.Age);

        }
    }
}
