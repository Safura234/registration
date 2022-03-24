using System;

namespace hometask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name and surname");
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            Console.WriteLine(name, surname);
            Console.WriteLine("Please select your gender");
            char gender;
            char gender1 = 'm';
            char gender2 = 'f';
            //Reading gender from user
            Console.WriteLine("Enter gender (1/m or 2/f): ");
            gender = Convert.ToChar(Console.ReadLine());
            switch (gender)
            {
                case 'm':
                    Console.WriteLine("Please enter 1");
                    Console.WriteLine("m");
                    break;
                case 'f':
                    Console.WriteLine("Please enter 2");
                    Console.WriteLine("f");
                    break;
            }
            int age;
            Console.Write("Enter your age ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            Console.Write("no permission");
            else if (age >18)
            {
                Console.WriteLine("successfully registered");
            }





        }




    }







}
    

