using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsReview
{
    public static class Utilities
    {
        public static int GetPosInt(string prompt)
        {
            int n = 0;
            bool valid = false;
            while (valid == false)
            {
                try
                {
                    Console.Write(prompt);
                    n = int.Parse(Console.ReadLine());
                    if (n >= 0)
                        valid = true;
                    else
                        throw new Exception("Error - must be positive");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return n;
        }

        public static int GetValidInt(string prompt)
        {
            int n = 0;
            bool valid = false;
            while (valid == false)
            {
                try
                {
                    Console.Write(prompt);
                    n = int.Parse(Console.ReadLine());                    
                    valid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return n;
        }

        public static string GetNonEmptyString(string prompt)
        {
            //VALIDATION LOOP
            string s = ""; //null string
            bool valid = false;
            while (valid == false)
            {
                try
                {
                    Console.Write(prompt);
                    s = Console.ReadLine();
                    if (s != "")
                        valid = true;
                    else
                        //THROW EXCEPTION IF STRING IS EMPTY
                        throw new Exception("Error - must enter data");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return s;
        }

        public static char GetChar(string prompt)
        {
            //VALIDATION LOOP
            char c = '\0';  //null character
            bool valid = false;
            while (valid == false)
            {
                try
                {
                    Console.Write(prompt);
                    c = char.ToUpper(char.Parse(Console.ReadLine()));
                    if (c != ' ')
                    {
                        valid = true;
                    }
                    else
                    {
                        throw new Exception("Must be one character");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return c;
        }

        public static double GetValidDbl(string prompt)
        {
            double n = 0;
            bool valid = false;
            while (valid == false)
            {
                try
                {
                    Console.Write(prompt);
                    n = double.Parse(Console.ReadLine());
                    valid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return n;
        }

        public static double GetPosDbl(string prompt)
        {
            double n = 0;
            bool valid = false;
            while (valid == false)
            {
                try
                {
                    Console.Write(prompt);
                    n = double.Parse(Console.ReadLine());
                    if(n > 0)
                    {
                        valid = true;
                    }                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return n;
        }
    }
}
