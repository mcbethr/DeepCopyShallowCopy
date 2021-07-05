using System;

namespace DeepAndShallowCopy
{
    class Program
    {


        static void Main(string[] args)
        {
            
        }

    }



    public class Monster
    {

        private string _Name;
        private int _Age;
        private Fur _MonsterFurType;


        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }
        public Fur MonsterFurType
        {
            get { return _MonsterFurType; }
            set { _MonsterFurType = value; }
        }

        public Monster (string Name, int Age, Fur FurType)
        {
            _Name = Name;
            _Age = Age;
            _MonsterFurType = FurType;

        }

        public Monster ShallowCopy()
        {

            Monster temp = (Monster)this.MemberwiseClone();

            return temp;

        }


        public Monster DeepCopy()
        {
            Fur fur = new Fur(this.MonsterFurType.FurColor);
            Monster ClonedMonster = new Monster(this.Name, this.Age, fur);

            return ClonedMonster;

        }

















    }

    public class Fur
    {

        public enum FUR_COLOR
        {
            BLUE,
            GREEN,
            RED
        }

        public FUR_COLOR FurColor { get; set; }

        public Fur(FUR_COLOR FurColor)
        {
            this.FurColor = FurColor;
        }


    }




}
