using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            ex1();
            console.writeline();
            ex2(7, 8);
            console.writeline();
            ex3();
            console.writeline();
            ex4();
            console.writeline();
            ex5();
            console.writeline();
            ex6();
            console.writeline();
            ex7();
            console.writeline();
            ex8();
            Console.WriteLine();
            ex9();
            Console.WriteLine();
            ex10();
            Console.ReadKey();

        }
        static void ex1()
        {
            Console.WriteLine("Hello Thomas");
        }

        static void ex2(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void ex3()
        {
            string aB = "-1 + 4 * 6";
            int a = -1 + 4 * 6;
            string bB = "(35 + 5) % 7";
            int b = (35 + 5) % 7;
            string cB = "14 + -4 * 6 / 11";
            int c = 14 + -4 * 6 / 11;


            string dB = "2 + 15 / 6 * 1 - 7 % 2";
            int d = 2 + 15 / 6 * 1 - 7 % 2;

            Console.WriteLine("The result of " + aB + " is " + a);
            Console.WriteLine("The result of " + bB + " is " + b);
            Console.WriteLine("The result of " + cB + " is " + c);
            Console.WriteLine("The result of " + dB + " is " + d);



        }

        static void ex4()
        {

            Console.WriteLine("Please, enter 1 number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("One other number");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("the last number");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The result of the multiplication bewteen those numbers is " + a * b * c);
        }

        static void ex5()
        {
            Console.WriteLine("MULTIPLICATION TABLE : \n " +
                "Enter a number between 1 and 10");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            for(int i = 1; i<11; i++)
            {
                Console.WriteLine(i * a);
            }
        }

        static void ex6()
        {
            Console.WriteLine("Let's calculate the average of 4 numbers \n"+
                "Please, enter 1 number");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("One other number");
            double b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("an other number");
            double c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a last number");
            double d = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("The result of the average bewteen those numbers is " +(a+b+c+d)/4);
        }

        static void ex7()
        {
            Console.WriteLine("Please enter an integer, we'll check if its range is between 100 and 200");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a>=100 && a<=200)
            {
                Console.WriteLine("The number is in the range");
            }
            else
            {
                Console.WriteLine("The number is out the range");
            }
        }

        static void ex8()
        {
            DateTime date = DateTime.Now;
            date = date.Date;
            Console.WriteLine("today we are the "+date.ToString("d"));
        }

        static void ex9()
        {
            Console.WriteLine("Hello, how old are you ? I'll find your birth's year");
            int age = Convert.ToInt32(Console.ReadLine());
            int birthYear = 2020 - age;
            Console.WriteLine("Your birth's year might be " + birthYear + " or " + (birthYear-1));


        }

        static void ex10()
        {

            Console.WriteLine("Please, enter 1 number x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("One other number y");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("the last number z ");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The result of (x+y)*z is "+ (x+y)*z);


            Console.WriteLine("The result of (x+y)*z is " + x* y + y* z);



        }




    }
}
