using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_practice
{
    class Program
    {
        enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };
        
        static void  Main(string[] args)
        {
            //Console.WriteLine(args);
            Area rectangle = new Area();
            double length = Convert.ToDouble(Console.ReadLine());
            double width = Convert.ToDouble(Console.ReadLine());
            rectangle.AcceptDetails(length,width);
            Console.WriteLine("Area of Rectangle is: " + rectangle.GetArea());
            int temp = 37;
            Console.WriteLine(temp.ToString());
            for(int i = 0;i <5;i++)
            {
                if (i == 3)
                {
                    continue;
                }
                Console.WriteLine(i);
               
            }
            
            int Factorial(int num)
            {
                int factorial = 1;
                for (int i = 1; i <= num; i++)
                {
                    factorial *= i;
                }
                return factorial;
            }

            int number = Convert.ToInt32(Console.ReadLine());
            int result = Factorial(number);
            Console.WriteLine("factorial of " + number + " is :" +  result);

            string[] data =
            {
                "harman",
                "harman1",
                "harman2",
                "harman3",
                "harmnn4"
            };
            Console.WriteLine("Foreach loop on string array :");
            foreach(var name in data)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine(data);
            var a = 2;
            try
            {
                var num = 5;
                var num2 = 0;
                a = num/ num2;
            }
            catch(ArithmeticException e)
            {
                Console.WriteLine("hii infinite you are handled" );
            } 
            finally
            {
                Console.WriteLine("hello finally "+ a);
            }
            Console.WriteLine(Days.Mon);
            dynamic value1 = "myType";
            Console.WriteLine("Type of Dynamic varible at runtime: " + value1.GetType());
            int val1;
            int val2 = 3;
            int val3 = 1;
            unsafe
            {
                int* ptr = &val2;
                Console.WriteLine((int)&val2);
                Console.WriteLine(*ptr);
            }
            int[] arr = new int[] { 1, 2, 4, 5 };
            Console.WriteLine("1D  dynamic array: " +arr[3]);
            Console.WriteLine("array elements after loop:");
            for(int i=0 ; i < arr.Length; i++)
            {
                ++arr[i];
                Console.WriteLine(arr[i]);
            }
            string myName = "harman";
            Console.WriteLine("string: " + myName);
            //int* ptr = &val2;
            //Console.WriteLine((int)&val2);
            //Console.WriteLine(*ptr);
            Console.WriteLine("value with ++ oprator: " + val3++);
            val1 = val2 & val3;
            Console.WriteLine(" value with bitwise AND "+val1);

            
            if(Convert.ToBoolean(val1) && Convert.ToBoolean(val2))
            {
                Console.WriteLine("Logical and worked");
            }
            Console.WriteLine(Math.Sqrt(val1));
            Console.WriteLine(Math.Pow(val1,val2));
            Console.WriteLine(Math.Floor(145.23));
            Console.WriteLine(Math.Tan(val1));

            Console.ReadKey();
        }
    }
    class Area

    {
        double length;
        double width;
        public void AcceptDetails(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public double GetArea()
        {
            return length * width;
        }


    }
}
