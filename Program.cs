using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioFactoryPattern.FactoryPattern;
using DesafioFactoryPattern.Interfaces;

namespace DesafioFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneFactory phoneModel = new PhoneFactory();
            Console.Write("Enter the brand of your cell phone (Motorola, LG, Samsung, Apple): ");
            string brand = Console.ReadLine().ToUpper();

            switch (brand)
            {
                case "APPLE":
                    IPhone phone1 = phoneModel.GetPhone("APPLE");
                    Console.WriteLine(phone1.Hello());
                    break;
                case "LG":
                    IPhone phone2 = phoneModel.GetPhone("LG");
                    Console.WriteLine(phone2.Hello());
                    break;
                case "MOTOROLA":
                    IPhone phone3 = phoneModel.GetPhone("MOTOROLA");
                    Console.WriteLine(phone3.Hello());
                    break;
                case "SAMSUNG":
                    IPhone phone4 = phoneModel.GetPhone("SAMSUNG");
                    Console.WriteLine(phone4.Hello());
                    break;
                default:
                    Console.WriteLine("Sorry, the brand " + brand + " wasn't found");
                    break;
            }
            Console.ReadKey();
        }
    }
}
