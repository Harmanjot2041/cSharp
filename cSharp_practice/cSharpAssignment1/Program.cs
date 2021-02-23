using System;

namespace cSharpAssignment1
{
    class Program
    {
         void Ques1()
        {
            Console.WriteLine("Quetion 1 ");
            Console.Write("Enter Number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                for(int space = 1; space <= n-i; space++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            for(int i = 1;i <= n-1; i++)
            {
                for (int space = 1; space <= i; space++)
                    Console.Write(" ");

                for (int j = 1; j <= 2*(n - i)-1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
        }
        void Ques2()
        {
            Console.WriteLine("Question 2");
            Console.Write("Enter first number :");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number :");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Two number before swap are : " + first + " , " + second);
            first += second;
            second = first-second;
            first = first - second;
            Console.WriteLine("Two number after swap are : " + first + " , " + second);
            Console.WriteLine();
            Console.WriteLine();
        }
        void Ques3()
        {
            Console.WriteLine("Question 3 ");
            Console.Write("Enter number to check for Palindrome : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int reverse = 0;
            while(temp > 0)
            {
                reverse = reverse * 10 + temp % 10;
                temp = temp / 10;
            }
            if (reverse == num)
                Console.WriteLine("Number " + num + " is Palindrome");
            else
                Console.WriteLine("Number " + num + " is NOT Palindrome");
            Console.WriteLine();
            Console.WriteLine();
        }
        void Ques4()
        {
            Console.WriteLine("Question 4 ");
            //AbstractClass obj = new AbstractClass();
            Console.WriteLine();
            Console.WriteLine("Abstract eg : ");
            ChildAbstract childObj = new ChildAbstract();
            childObj.NonAbstractMethod();
            childObj.AbstractMethod();
            Console.WriteLine();
            Console.WriteLine("INterface eg : ");
            InnterfaceClass interfaceObj = new InnterfaceClass();
            interfaceObj.InterfaceMothod1();
            Console.WriteLine();
            Console.WriteLine();

        }
        void Ques5()
        {
            Console.WriteLine("Question 5 ");
            ConstructorClass obj1 = new ConstructorClass();
            ConstructorClass obj2 = new ConstructorClass(25);
            ConstructorClass obj3 = new ConstructorClass(obj2);
            Console.WriteLine();
            Console.WriteLine();
        }
        void Ques6()
        {
            Console.WriteLine("Question 6 ");
            int a;
            try
            {
                var num = 5;
                var num2 = 0;
                a = num / num2;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(" Infinte Exception handled using try catch block .");
            }
            finally
            {
                Console.WriteLine("hello from finally " );
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        void Ques7()
        {
            Console.WriteLine("Question 7");
            Console.Write("Enter string : ");
            string str1 = Console.ReadLine();
            Console.WriteLine("String Before reverted : " + str1);
            string[] strArray = str1.Split(" ");
            
            int i = 0;
            int j = strArray.Length - 1;
            while(i < j)
            {
                string temp = strArray[i];
                strArray[i] = strArray[j];
                strArray[j] = temp;
                i++;
                j--;
            }
            str1 = string.Join(" ", strArray);
            Console.WriteLine(" string after reversed : " + str1);
            //foreach (string str in strArray)
            //    Console.Write(str + " ");
            Console.WriteLine();
            Console.WriteLine();

        }
        void Ques8()
        {
            Console.WriteLine("Question 8 ");
            Console.Write("Enter number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;

            while(temp > 0)
            {
                if(temp % 10 == 3)
                {
                    Console.WriteLine(num + " contains digit 3");
                    break;
                }
                temp = temp / 10;

            }
            if (temp == 0)
                Console.WriteLine(num + " Does not contain digit 3");
            Console.WriteLine();
            Console.WriteLine();
        }
        
        void Ques9()
        {
            Console.WriteLine("Question 9 ");
            Console.WriteLine("");
            int val1 = 25;
            unsafe
            {
                int* ptr = &val1;
                Console.WriteLine(" Address of varible using pointer : " + (int)ptr);
                Console.WriteLine(" value of varible through pointer : " + *ptr);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        void Ques10()
        {
            Console.WriteLine("Question 10 ");
            
            Console.Write("Enter number  of objects in array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[size];
            
            for(int k =0; k < size; k++)
            {
                arr[k] = Console.ReadLine();
            }

            Console.WriteLine("Array Before reverse : ");
            foreach (string str in arr)
                Console.Write(str + " ");

            int i = 0;
            int j = arr.Length - 1;
            while (i < j)
            {
                string temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
            Console.WriteLine();
            Console.WriteLine("Array after reverse : ");
            foreach (string str in arr)
                Console.Write(str + " ");

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
           
            Program obj = new Program();
            obj.Ques1();
            obj.Ques2();
            obj.Ques3();
            obj.Ques4();
            obj.Ques5();
            obj.Ques6();
            obj.Ques7();
            obj.Ques8();
            obj.Ques9();
            obj.Ques10();
            
            
        }
    }
    public abstract class AbstractClass // abstract class - we have to override the absract method of class in child class.
    {
        public string name;
        public int id;
        public abstract void AbstractMethod();
        public void NonAbstractMethod()
        {
            Console.WriteLine("NON ABSTRACT METHOD IN ABSTRACT CLASS SUCCESSFULLY CALLED USING CHILD CLASS ");
        }
    }
    public class ChildAbstract : AbstractClass
    {
        public override void  AbstractMethod()
        {
            Console.WriteLine("Abstract method is overrided succesfully in dervied class from abstract class ");
        }
    }
    public interface InterfaceEg
    {
        void InterfaceMothod1();
        double InterfaceMothod2();

    }
    public class InnterfaceClass : InterfaceEg
    {
        int val = 25;
        public void InterfaceMothod1()
        {
            Console.WriteLine("Interface methods defined Successfully in Class ");
        }
        public double InterfaceMothod2()
        {
            return 34.5;
        }
    }
    public class ConstructorClass
    {
        public int value;
        public ConstructorClass()
        {
            Console.WriteLine("Normal Default constructor");
        }
        public ConstructorClass(int a)
        {
            Console.WriteLine("Parameterized constructor with values : " + a );
            this.value = a;
        }
        public ConstructorClass(ConstructorClass obj) 
        {
            this.value = obj.value;
            Console.WriteLine("Copy conastructor called succesfully. ");
        }
        static ConstructorClass()
        {
            //hey = "hey1";
            Console.WriteLine("You are in static class and called only once" );
        }

    }
    }
