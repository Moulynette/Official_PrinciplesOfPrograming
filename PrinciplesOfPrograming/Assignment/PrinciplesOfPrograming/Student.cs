using System;
using System.Collections.Generic;
using System.Text;

namespace PrinciplesOfPrograming
{
    public class Student : Person
    {
        // attributes

        public string studentNumber;
        public int age;
        public Adress adress;
        public string fullName;
        public int[] score;
        public double averageScore;
        public string fullAdress;





        // constructor


        public Student(string firstName, string lastName, string studentNumber, int age, Adress adress, int[] score) :
            base(firstName, lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentNumber = studentNumber;
            this.age = age;
            this.adress = adress;
            this.score = score;

            int sum = 0; 
            for(int i = 0; i<score.Length; i++)
            {
                sum += score[i];
            }
            averageScore = sum / score.Length;
            this.fullName = firstName + " " + lastName;
            this.fullAdress = adress.ToString();

            
        }


        //methods

        public void ToString(Adress adress, Student s)
        {
            Console.WriteLine("first name :"+this.firstName );
            Console.WriteLine("last name :" + this.lastName);
            Console.WriteLine("student number :" + this.studentNumber);
            Console.WriteLine("age :" + age);
            Console.WriteLine("full adress :" + s.ToString());
            Console.WriteLine("full name :" + this.fullName);
            Console.WriteLine("score :" + this.score);
            Console.WriteLine("average score :" + this.fullName);

        }


    }

}
