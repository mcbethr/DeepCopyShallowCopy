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
            Fur MonsterFur = new Fur(Fur.FUR_COLOR.BLUE);

            Monster MonsterOne = new Monster(Name, Age, MonsterFur);
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
            Fur MonsterFur = new Fur(Fur.FUR_COLOR.BLUE);

            Monster MonsterOne = new Monster(Name, Age, MonsterFur);
            Monster MonsterTwo = MonsterOne.ShallowCopy();

            MonsterOne.Name = "Generic";
            MonsterOne.Age = 50;
            MonsterOne.MonsterFurType.FurColor = Fur.FUR_COLOR.GREEN;

            Assert.AreEqual(Name, MonsterTwo.Name);
            Assert.AreEqual(Age, MonsterTwo.Age);
            Assert.AreEqual(Fur.FUR_COLOR.GREEN, MonsterTwo.MonsterFurType.FurColor);

        }

        [TestMethod]
        public void TestDeepCopy()
        {

            string Name = "Ryan Monster";
            int Age = 25;
            Fur MonsterFur = new Fur(Fur.FUR_COLOR.BLUE);

            Monster MonsterOne = new Monster(Name, Age, MonsterFur);
            Monster MonsterTwo = MonsterOne.DeepCopy();

            MonsterOne.Name = "Generic";
            MonsterOne.Age = 50;
            MonsterOne.MonsterFurType.FurColor = Fur.FUR_COLOR.GREEN;

            Assert.AreEqual(Name, MonsterTwo.Name);
            Assert.AreEqual(Age, MonsterTwo.Age);
            Assert.AreEqual(Fur.FUR_COLOR.BLUE, MonsterTwo.MonsterFurType.FurColor);

        }

    }
}
