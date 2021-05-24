using System;

namespace Calculator
{
    class Program
    {
        //static int numo;
        //static int num1;
        //static int num2;
        
        
        //nimetumia methods kutengeneza. nimepatia ee???
        
        
        static void Main(string[] args)
        {
            double num0 = 0;
            double num1 = 0;
            
            Console.WriteLine("Hello World! I'm about to make a calculator program!\r");
            Console.WriteLine("----------------------------------------------------\n");
            Console.WriteLine("Please enter first number: ");
            num0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter second number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the operation i.e. sum, div, sub or mul: ");
            var op = Console.ReadLine();
            Program s = new Program();
            Program w = new Program();
            Program x = new Program();
            Program y = new Program();
            
            if (op == "sum")
            {
                Console.WriteLine($"The Result of {num0} {op} {num1} is: " + s.GetResultSum(num0,num1));
            }
            else if (op == "sub")
            {
                //Console.WriteLine("The Result is:" + num0-num1);
                Console.WriteLine($"The Result of {num0} {op} {num1} is: " + w.GetResultSub(num0,num1));
            }
            else if (op == "div")
            {
                Console.WriteLine($"The Result of {num0} {op} {num1} is: " + Math.Round(x.GetResultDiv(num0,num1),3));
                //Console.WriteLine("The Result is:" + num0/num1);
            }
            else if (op == "mul")
            {
                Console.WriteLine($"The Result of {num0} {op} {num1} is: " + Math.Round(y.GetResultMul(num0,num1),3));
                //Console.WriteLine("The Result is:" + num0*num1);
            }

            // Program s = new Program();
            // Console.WriteLine("The Result is: " + s.GetResultSum(num0,num1));
        }

        public double GetResultSum(double a, double b)
        {
            return a+b;
        }

        public double GetResultSub(double a, double b)
        {
            return a-b;
        }

        public double GetResultMul(double a, double b)
        {
            return a*b;
        }

        public double GetResultDiv(double a, double b)
        {
            return a/b;
        }
    }
}
