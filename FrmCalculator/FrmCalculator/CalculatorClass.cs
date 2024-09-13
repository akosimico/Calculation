using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmCalculator
{
    public delegate T Information<T>(T arg1);
    public delegate double Calculation(double num1, double num2);
    class CalculatorClass
    {
        public Information<string> info;

        public double GetSum(double num1, double num2)
        {
            return num1 + num2;
        }
        public double GetDiff(double num1, double num2)
        {
            return num1 - num2;
        }
        public double GetProduct(double num1, double num2)
        {
            return num1 * num2;
        }
        public double GetQou(double num1, double num2)
        {
            return num1 / num2;
        }
        public double Calculate(double num1, double num2)
        {
            if (CalculationEvent != null)
            {
                return CalculationEvent(num1, num2);
            }
            return 0;
        }
        private event Calculation CalculationEvent;
        public event Calculation CalculateEvent
        {
            add
            {
                Console.WriteLine("Added the Delegate");
                CalculationEvent += value;
            }
            remove
            {
                Console.WriteLine("Remove the Delegate");
                CalculationEvent  -= value;
            }
        }

       
    }
}
