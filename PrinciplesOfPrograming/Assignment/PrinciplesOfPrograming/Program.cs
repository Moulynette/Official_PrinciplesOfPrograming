using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrinciplesOfPrograming
{


    class Program
    {

        static void Main(string[] args)
        {
            int ans;
            ConsoleKeyInfo cki;
            Console.WindowHeight = 50;
            Console.WindowWidth = 100;
            do
            {

                Console.Clear();
                Console.WriteLine("Hello dear student, please enter your firstName");
                string firstName = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("please enter your lastName");
                string lastName = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("please enter your student number");
                string studentNumber = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("please enter your age");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("please enter your street number");
                string stnumber = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("please enter your street");
                string street = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("please enter your city");
                string city = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("please enter your country");
                string country = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("How many scores do you want to save ?");
                int scoreNumber = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                int[] score = new int[scoreNumber];
                for (int i = 0; i < score.Length; i++)
                {
                    score[i] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }

                Adress adress = new Adress(number, street, city, country);
                
                Student s = new Student(firstName,lastName,studentNumber,age,adress,score);

                


                do
                {
                    Console.WriteLine(" tape 1  for displaying your average score ");
                    Console.WriteLine(" tape 2  for displaying your adress ");
                    Console.WriteLine(" tape 3  for displaying your city ");
                    Console.WriteLine(" tape 4  for displaying all of your informations ");



                    int ex = Convert.ToInt32(Console.ReadLine());
                    switch (ex)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine(s.FirstName + " " + s.LastName + " average score is " + s.averageScore);
                            Console.WriteLine();
                            Console.WriteLine("press enter to continue");
                            Console.ReadKey();


                            break;


                        case 2:
                            Console.Clear();
                            Console.WriteLine(s.FirstName + " " + s.LastName + adress.ToString());
                            Console.WriteLine();
                            Console.WriteLine("press enter to continue");
                            Console.ReadKey();
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine(s.FirstName + " " + s.LastName + " is living in " + adress.City);
                            Console.WriteLine();
                            Console.WriteLine("press enter to continue");
                            Console.ReadKey();
                            break;

                        case 4:
                            Console.Clear();
                            s.ToString(adress, s);
                            Console.WriteLine();
                            Console.WriteLine("press enter to continue");
                            Console.ReadKey();
                            break;
                    }
                    Console.Clear();
                    
                    Console.WriteLine("Tape the escape key to leave the program");
                    Console.WriteLine("Tape 5 to see check other informations on this student");
                    Console.WriteLine("are any other keys to continu with an other student");
                    ans = Convert.ToInt32(Console.ReadLine());
                    
                    Console.Clear();

                } while (ans == 5);
                cki = Console.ReadKey();
            } while (cki.Key != ConsoleKey.Escape);

            Console.Read();
        }

    }
}
