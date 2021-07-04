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
        private FurColor _FurColor;
        private string _Name;
        private int _Age;

        public enum FurColor
        {
            BLUE
        }

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
        public FurColor MonsterColor
        {
            get { return _FurColor; }
            set { _FurColor = value; }
        }

        public Monster (string Name, int Age, FurColor furColor)
        {
            _Name = Name;
            _Age = Age;
            _FurColor = furColor;

        }


        public Monster ShallowCopy()
        {
  
             Monster temp = (Monster)this.MemberwiseClone();

             return temp;
            
        }

    }




}
