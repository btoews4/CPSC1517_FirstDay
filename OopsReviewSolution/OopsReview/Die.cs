using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsReview
{
    public class Die
    {
        //This is the definition of an object
        //It's a conceptual view of the data that
        //will be held by a physical instance(object)
        //of this class

        //It's a dice, my dude

        private static Random _random = new Random();

        //Data Members   
        private int _sides;
        private string _color; //Isn't necessary as it's stored in the property
        private int _face; //Isn't necessary, but nice to have to keep track of data

        //Constructors
        public Die()
        {
            Sides = 6;
            Color = "White";
            Roll();
        }

        public Die(int size, string color)
        {
            Sides = size;
            Color = color;
            Roll();
        }

        //Properties       
        public int Sides
        {
            get
            {
                return _sides;
            }
            set
            {
                if(value < 6 || value > 20)
                {
                    throw new Exception("Invalid Dice size. Must be 6-20");
                }
                _sides = value;
                Roll();
            }
        }

        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                //(value == null) this will fail for an empty string
                //(value == "") this will fail for a null value
                //Could do (value == null || value == "")
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))// Maybe have to type value.ToString()
                {
                    throw new Exception("Color has no value.");
                }
                _color = value;
            }
        }

        //Auto Implimented propety
        public int Face { get; private set; }
        //public int Face
        //{
        //    get
        //    {
        //        return _face;
        //    }
        //    set
        //    {
        //        if (value < 1 || value > Size)
        //        {
        //            throw new Exception("Invalid face number");
        //        }
        //        _face = value;
        //    }
        //}

        //Behaviours (methods)
        public override string ToString()
        {
            return ("Size: " + Sides + ", Color: " + Color + ", Face: " + Face);
        }

        public void SetSides(int sides)
        {
            if (sides >= 6 && sides <= 20)
            {
                Sides = sides;
            }
            else
            {
                //optionally:
                //a) throw a new exception
                throw new Exception("Invalid value for die sides");
                //b) set mSides to a default value
                //Sides = 6;
            }
            Roll();
        }

        public void Roll()
        {
            Face = _random.Next(1, Sides + 1);
        }
    }
}
