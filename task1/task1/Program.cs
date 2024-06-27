using System.Globalization;

namespace task1c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine($"your name is {name} ");
            /////// 2-	Define variables with kind of
            double a = 1.45;
            string b = "sara";
            char test = 'A';
            bool isActive = true;
            const double PI = 3.14;
            //3-	Define array with name car that hold more than 3 kinds on cars, then print all the cars with the array length.
            string[] car = { "Toyota", "Honda", "Ford", "BMW" };
            foreach (string item in car) { Console.WriteLine(item); }
            Console.WriteLine($"the length of array is {car.Length}");
            ////4-Write a program in C that reads a first name, surname and year of birth and display the names and the year one after another sequentially. Go to the editor

            Console.Write("Input your firstname");
            string Fname = Console.ReadLine();
            Console.Write("Input your lastnamee");
            string lname = Console.ReadLine();
            Console.Write("Input your year of birthday");
            string birthday = Console.ReadLine();
            Console.WriteLine(Fname + lname + birthday);
            //array
            Console.WriteLine("Enter ten number");
            int[] num = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"element  {i} :");
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.Write($"Elements in array are:");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            }

        }
    }
}