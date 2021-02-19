using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate int MyDelegate(int props);
namespace cSharp_practice
{
    class Program
    {
        enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };
        

        static void Main(string[] args)
        {
            //Console.WriteLine(args);
            
            Console.Write("Enter length of Reactangle: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter width of Reactangle: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Area rectangle = new Area(length, width);
            rectangle.AcceptDetails<double>(12.4, 24.4) ;
            
            Area copy = new Area(rectangle);
            Console.WriteLine("Area of Rectangle is: " + rectangle.GetArea());
            //rectangle.Free();
            //Delegatesssssssssssss
            MyDelegate add = new MyDelegate(copy.Add);
            MyDelegate minus = new MyDelegate(copy.Minus);
            int check = 5;
            check =add(check);
            check = minus(check);
            Console.WriteLine(" value using Delegate : "+ check);
            int temp = 37;
            Console.WriteLine(temp.ToString());
            for (int i = 0; i < 5; i++)
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
            Console.Write("Enter number for factorial: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = Factorial(number);
            Console.WriteLine("factorial of " + number + " is :" + result);

            string[] data =
            {
                "harman",
                "harman1",
                "harman2",
                "harman3",
                "harmnn4"
            };
            Console.WriteLine("Foreach loop on string array :");
            foreach (var name in data)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine(data);
            var a = 2;
            try
            {
                var num = 5;
                var num2 = 0;
                a = num / num2;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("hii infinite you are handled");
            }
            finally
            {
                Console.WriteLine("hello finally " + a);
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
            Console.WriteLine("1D  dynamic array: " + arr[3]);
            Console.WriteLine("array elements after loop:");
            for (int i = 0; i < arr.Length; i++)
            {
                ++arr[i];
                Console.WriteLine(arr[i]);
            }
            int[,] matrix = new int[,] {
                {1,2,3 },
                {2,3,4 },
                { 3, 4, 5},
                {4,5,6 }
            };
            Console.WriteLine("Matrix (multidem array) :");
            for(int i=0;i< 4;i++)
            {
                for(int j = 0;j<3;j++)
                {
                    Console.Write(matrix[i, j]+ "  ");
                }
                Console.WriteLine(" ");
                
            }
            int[][] obj = new int[4][];
            for(int i=0;i<4;i++)
            {
                obj[i] = new int[3];
            }
            // jagged array
            Console.WriteLine("Jagged array: ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(obj[i][j] + "  ");
                }
                Console.WriteLine(" ");

            }
            //ArrayList collections 
            List<int> arrList = new List<int>();
            Console.WriteLine("Size of ArrayList when NO element is inserted: " + arrList.Capacity);
            arrList.Add(1);
            Console.WriteLine("Size of ArrayList when 1 element is inserted: " + arrList.Capacity);
            arrList.Add(2);
            arrList.Add(3);
            arrList.Add(4);
            arrList.Add(5);
            Console.WriteLine("Size of ArrayList when 4 element is inserted: " + arrList.Capacity);
            arrList.Remove(3);
            foreach (object item in arrList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            //Hashed Tables collections
            Hashtable hashTable = new Hashtable();
            hashTable.Add("Name", "Harman");
            hashTable.Add("Age", 21);
            hashTable.Add("id", "happy16harman@gmail.com");
            hashTable.Add("collage", "UIET PANJAB UNIVERSITY CHD");
            Console.WriteLine("Data from hashTables : ");
            foreach(object key in hashTable.Keys)
            {
                Console.WriteLine(key + " : " + hashTable[key] + " Hashed code: " + key.GetHashCode());
            }
            //LINQ
            int[] marks = { 1,2,3,4,5,6,7,8,9 };
            var maxMark = from mark in marks where mark > 4 orderby mark descending select mark;
            foreach(int j in maxMark)
                Console.WriteLine("data from LINQ : " + j);
            //Console.WriteLine("Name from Hashtable Data : " + hashTable["Name"]);
            //Console.WriteLine("Age from Hashtable Data : " + hashTable["Age"]);
            //Console.WriteLine("id from Hashtable Data : " + hashTable["id"]);
            //Console.WriteLine("Collage from Hashtable Data : " + hashTable["collage"]);

            string myName = "harman";
            Console.WriteLine("string: " + myName);
            
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
            // static class
            //StaticClass abc = new StaticClass();
           // abc.hey1 = "abc";
           // StaticClass.hey = "hey";
           // StaticClass abcd = new StaticClass();
            //abcd.hey = "abcd";
            //StaticClass.StaticMember();
            // static int a = 2;
           // public delegate void delegateEg(int props);
            Console.WriteLine(StaticClass.hey ="hey1  "  + StaticClass.Func(1));
            Console.WriteLine(StaticClass.hey = "hey2   " + StaticClass.Func(2));
            //file in c#
            File.WriteAllText("fileFromC#.txt", "hey i am sending you in txt file Good byeeeeeeeee");
            string fileData = File.ReadAllText("fileFromC#.txt");
            Console.WriteLine(fileData);
            InnterfaceClass propObj = new InnterfaceClass();
            propObj.Code = 24;
            Console.ReadKey();
        }
    }
      static class StaticClass
    {
        //public string hey1;
         //int a = 2;
        public  static string hey;
        public   static int   Func(int a)
        {
            return a;
        }
         static StaticClass()
        {
            //hey = "hey1";
            Console.WriteLine("You are in static class and called only once" + hey);
        }
    }
    public abstract class AbstractClass // abstract class - we have to override the absract method of class in child class.
    {
        public string name ;
        public int id;
        public abstract void func();
    }
    // interface 
    public interface InterfaceEg
    {
        void func();
        double temp1();

    }
    public class InnterfaceClass : InterfaceEg
    {
        int val = 25;
        public void func()
        {
            
        }
        public double temp1()
        {
            return 34.5;
        }
        public int Code
        {
            get
            {
                return val;
            }
            set
            {
                val = value;
            }
        }
    }
    class Area

    {
        
        public int Add(int props)
        {
            return ++props;
        }
        public int Minus(int props)
        {
            return --props;
        }
        double length;
        double width;
        public  Area (double length,double width) //parameterize type
        {
             this.length = length;
            this.width = width;
            //Console.WriteLine(length);
        }
        ~Area ()
        {
            Console.WriteLine("byeeewwe");
        }
        public void AcceptDetails<T> (T len, T wid)
        {
            dynamic leng = len;
            dynamic widt = wid;
        }
        public Area(Area rectangle) //copy constructor
        {
            this.length = rectangle.length;
            this.width = rectangle.width;
        }
        public double GetArea()
        {
            return length * width;
        }


    }
}
// 16-02-2021
//classes and objects -implement 
//constractor -implement
//types of classes 
//access  modifiers in c# -
//abstract vs interfaces -
//interfaces - implements
//properties - (get,set)-implement
//events 