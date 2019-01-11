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

        //Data Members   
        private int _size;
        private string _color; //Isn't necessary as it's stored in the property
        private int _face; //Isn't necessary, but nice to have to keep track of data

        //Constructors
        public Die()
        {
            Size = 6;
            Color = "White";
            Face = 1;
        }

        public Die(int size, string color, int face)
        {
            Size = size;
            Color = color;
            Face = face;
        }

        //Properties       
        public int Size
        {
            get
            {
                return _size;
            }
            set
            {
                if(value < 6 || value > 20)
                {
                    throw new Exception("Invalid dice size. (Must be 6-20)");
                }
                _size = value;
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
        public int Face { get; set; }
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
            return ("Size: " + Size + ", Color: " + Color + ", Face: " + Face);
        }
    }
}
