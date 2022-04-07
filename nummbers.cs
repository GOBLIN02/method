using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverLoading
{
    public class Numbers
    {
        public int FindMinimum(int number1, int number2)
        {
            int Minimal;
            if (number1 < number2)
            {
                Minimal = number1;
            }
            else
            {
                Minimal = number2;
            }
            return Minimal;

        }
        public int FindMinimum(int number1, int number2, float number3)
        {
            int Minimal;
            if ((number1 < number2) && (number1 < number3))
            {
                Minimal = number1;
            }
            else if ((number2 < number1) && (number2 < number3))
            {
                Minimal = number2;
            }
            else
            {
                Minimal = (int)number3;
            }
            return Minimal;
        }
        public int FindMaximum(int number1, int number2)
        {
            int Maximal;
            {
                if (number1 > number2)
                {
                    Maximal = number1;
                }
                else
                {
                    Maximal = number2;
                }
                return Maximal;
            }
        }
        public int FindMaximum(int number1, int number2, float number3)
        {
            int Maximal;
            {
                if ((number1 > number2) && (number1 > number3))
                {
                    Maximal = number1;
                }
                else if ((number1 > number2) && (number1 > number3))
                {
                    Maximal = number2;
                }
                else
                {
                    Maximal = (int)number3;
                }
                return Maximal;
            }
        }
    }
}
