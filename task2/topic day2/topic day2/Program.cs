namespace topic_day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	While / Do While  
            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine("iteration  " + i);
            //    i++;
            //}
            //int x = 0;
            //do
            //{
            //    Console.WriteLine("iteration  " + x);
            //    x++;
            //} while (x < 5);

            //forloop'

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Hello, world! " + i);
            //}

            //forloop throw array

            //int[] scores = { 90, 70, 80, 95, 85 };

            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine("Score " + i + ": " + scores[i]);
            //}

            //foreach

            //int[] scores = { 90, 70, 80, 95, 85 };

            //foreach (int score in scores)
            //{
            //    Console.WriteLine("Score: " + score);
            //}

            //break & continue
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break; 
                    //continue;
                }
                Console.WriteLine("i = " + i);
            }
            //•	Method without parameters 

            //int result = CalculateSum();
            //Console.WriteLine("The sum is: " + result);

            //•	Method with parameters ,
            int result = AddNumbers(5, 10);
            Console.WriteLine("The sum is: " + result);

            //•	Method with Default parameter value  
            PrintHello("John"); 
            PrintHello("Jane", 30);
            //•	Method parameter and Arguments, 
            //parameter method ,arg call
            //•	Method that return value and not return value ,
            //•	Method with Array parameters . 
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            PrintValues(arr);
        }
        static int CalculateSum()  //•	Method without parameters ,
        {
            int a = 5;
            int b = 10;
            return a + b;
        }
        static int AddNumbers(int a, int b) //•	Method with parameters ,
        {
            return a + b;
        }
        static void PrintHello(string name, int age = 25) //Method with Default parameter value  , 
        {
            Console.WriteLine("Hello, " + name + "! You are " + age + " years old.");
        }
        static void PrintValues(int[] values)
        {
            foreach (int value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound.");
        }

        public virtual void Eat()
        {
            Console.WriteLine("The animal is eating.");
        }
    }

    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) 
        { }

        public override void MakeSound()
        {
            Console.WriteLine("The dog barks.");
        }

        public override void Eat()
        {
            Console.WriteLine("The dog is eating dog food.");
        }
    }
    public class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine("The cat meows.");
        }

        public override void Eat()
        {
            Console.WriteLine("The cat is eating cat food.");
        }
    }


}
