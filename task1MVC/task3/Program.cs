namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car myCar = new Car(2023, "SUV", 35000, "Rav4", "Red" ,"1234");
            //myCar.start();
            //myCar.stop();
            //Console.WriteLine(myCar.carInfo());
            ///////////////////////////////
            // task 7 (files):
            //task7files fileobj = new task7files();
            //string fileName = "my_info.txt";
            //fileobj.WriteToFile(fileName);
            //fileobj.ReadFromFile(fileName);
            //fileobj.CountWords(fileName);
            //fileobj.CountCharacters(fileName);
            ///////////////////////////////////
            /// task 3 (try catch)
            //Trycatchtask obj = new Trycatchtask();
            //obj.testTryAndCatch(12);
            checkAge(15);
        }
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }
    }
}
