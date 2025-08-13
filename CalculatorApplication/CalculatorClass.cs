using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    // Declaring a generic Formula
    public delegate X Formula<X>(X arg1, X arg2);
    internal class CalculatorClass
    {
        //setting variable and data type
        public Formula<double> formula;

        //Method creation
        public static double getSum(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double getDifference(double num1, double num2)
        {
            return num1 - num2;
        }
        // Event accessor with two mwthods
        public event Formula<double> CalculateEvent
        {
            add { Console.WriteLine("Added the delegate");
                formula += value; 
            }
            remove { 
                Console.WriteLine("Removed the delegate");
                formula -= value;
            }
        }
       
    }
}