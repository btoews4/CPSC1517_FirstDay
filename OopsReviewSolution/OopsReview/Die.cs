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
        private string _color;
        private int _face;

        //Constructors
        public Die()
        {
            _size = 1;
            _color = "White";
            _face = 1;
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
                if(value < 1)
                {
                    throw new Exception("Invalid dice size");
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
                _color = value;
            }
        }

        public int Face
        {
            get
            {
                return _face;
            }
            set
            {
                if (value < 1)
                {
                    throw new Exception("Invalid face number");
                }
                _face = value;
            }
        }

        //Behaviours (methods)

    }
}
