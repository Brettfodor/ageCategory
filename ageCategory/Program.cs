using System;

namespace ageCategory
{
    class Program
    {
        static void Main(string[] args)
        {
            int childAge;


            Console.WriteLine("Welcome to the WCCI School District Age Sorter!");

            Console.WriteLine("What age is your child?");


            childAge = Convert.ToInt32(Console.ReadLine());

            if (childAge >= 0 && childAge <= 2)
            {
                Console.WriteLine("Still in mama's arms");
            }
            else if (childAge == 3 || childAge == 4)
            {
                Console.WriteLine("Preschool Maniac");
            }
            else if (childAge >= 5 && childAge <= 11)
            {
                Console.WriteLine("Elementary School");
            }
            else if (childAge >= 12 && childAge <= 14)
            {
                Console.WriteLine("Middle School");
            }
            else if (childAge >=15 && childAge <= 18)
            {
                Console.WriteLine("High School");
            }
            else if (childAge >= 19 && childAge <= 22)
            {
                Console.WriteLine("College");
            }
            else if (childAge >=23 && childAge <= 65)
            {
                Console.WriteLine("Working for the Man");
            }
            else if (childAge >= 66 && childAge <= 100) 

            {
                Console.WriteLine("The Golden Years");
            }
            else
            {
                Console.WriteLine("This program is for humans.");
            }
        }
    }
}
