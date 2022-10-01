using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcnew
{
    public class Calculator
    {
        public void Start()
        {
            Calc();

        }
        private void Calc()
        {

            double firstvalue, secondvalue;
            string action;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter first number");
                firstvalue = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number");
                secondvalue = double.Parse(Console.ReadLine());

                Console.WriteLine("Choose action: '+' '-' '*' '/' '%'");
                action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        Console.WriteLine(firstvalue + secondvalue);
                        break;

                    case "-":
                        Console.WriteLine(firstvalue - secondvalue);
                        break;

                    case "*":
                        Console.WriteLine(firstvalue * secondvalue);
                        break;

                    case "/":
                        if (secondvalue == 0)
                        
                            Console.WriteLine("Error! Cannot divide by 0 ");
                        
                        else
                            Console.WriteLine(firstvalue / secondvalue);
                        break;
                    case "%":
                        Console.WriteLine(firstvalue % secondvalue);
                        break;

                    default:
                        Console.WriteLine("Unknown action");
                        break;
                }

                Console.ReadLine();
            }

        }   

        public double Add(double numberOne, double numberTwo) { return numberOne + numberTwo; }
        public double Add(double[] number)
        {
            double sum = 0;
            for (int i = 0; i < number.Length; i++)
            
                sum = sum + number[i];
            
            return sum;
        }

        public double Sub(double numberOne, double numberTwo) { return numberOne - numberTwo; }

        public double Sub(double[] number)
        {
            double sum = number[0];
            for (int i = 1; i < number.Length; i++)
            
                sum = sum - number[i];
            
            return sum;
        }

        public double Multi(double numberOne, double numberTwo) { return numberOne * numberTwo; }

        public double Div(double numberOne, double numberTwo)
        {
            if (numberTwo == 0)
            {
                throw new DivideByZeroException("Division by zero is not possible.");
            }
            return numberOne / numberTwo;
        }
    }
}
