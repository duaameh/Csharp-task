using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPcSharptask
{
    public class Car
    {
        int year;
        string type;
        double price;
        string model;
        string color;
        string palletno;
        public Car(int year, string type, double price, string model, string color, string palletno)
        {
            this.year = year;
            this.type = type;
            this.price = price;
            this.model = model;
            this.color = color;
            this.palletno = palletno;
        }
        public void start()
        {
            Console.WriteLine("The car start.");
        }
        public void stop()
        {
            Console.WriteLine("The car stop.");
        }
        public string carInfo()
        {
            return "Car Year : " + year + "\nCar type : " + type + "\nCar price : "
                   + price + "\nCar model : " + model +
                   "\nCar color : " + color +
                   "\npalletNo : " + palletno;
        }

    }
}
