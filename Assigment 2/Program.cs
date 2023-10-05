using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            sumOfElementOfArray();

            firstObjectOfProduct();

            secondObjectOfProduct();

            thirdObjectOfProduct();

            fourthObjectOfProduct();

            fifthObjectOfProduct();




            Console.Read();
        }

        private static void fifthObjectOfProduct()
        {
            product p5 = new product();
            p5.Product_id = 5;
            p5.Product_name = "CPU";
            p5.Product_price = 10000;
            p5.UnitOfMeasurment = "each";
            p5.Product_qty = 5;
            Console.WriteLine($"CPU Deatils : ");
            Console.WriteLine($"The Product_id is {p5.Product_id}");
            Console.WriteLine($"The Product_name is {p5.Product_name}");
            Console.WriteLine($"The Product_price is {p5.Product_price}");
            Console.WriteLine($"The Unit of Measurement is {p5.UnitOfMeasurment}");
            Console.WriteLine($"The Product_qty is {p5.Product_qty}");
        }

        private static void fourthObjectOfProduct()
        {
            product p4 = new product();
            p4.Product_id = 4;
            p4.Product_name = "Headphones";
            p4.Product_price = 1000;
            p4.UnitOfMeasurment = "each";
            p4.Product_qty = 5000;
            Console.WriteLine($"Fouth Object of Product");
            Console.WriteLine(p4.Product_id);
            Console.WriteLine(p4.Product_name);
            Console.WriteLine(p4.Product_price);
            Console.WriteLine(p4.UnitOfMeasurment);
            Console.WriteLine(p4.Product_qty);
        }

        private static void thirdObjectOfProduct()
        {
            product p3 = new product();
            p3.Product_id = 3;
            p3.Product_name = "Desktop";
            p3.Product_price = 30000;
            p3.UnitOfMeasurment = "each";
            p3.Product_qty = 10;
            Console.WriteLine($"Third Object of Product");
            Console.WriteLine(p3.Product_id);
            Console.WriteLine(p3.Product_name);
            Console.WriteLine(p3.Product_price);
            Console.WriteLine(p3.UnitOfMeasurment);
            Console.WriteLine(p3.Product_qty);
        }

        private static void secondObjectOfProduct()
        {
            product p2 = new product();
            p2.Product_id = 2;
            p2.Product_name = "Mobile";
            p2.Product_price = 25000;
            p2.UnitOfMeasurment = "each";
            p2.Product_qty = 500;
            Console.WriteLine($"Second Object of Product");
            Console.WriteLine(p2.Product_id);
            Console.WriteLine(p2.Product_name);
            Console.WriteLine(p2.Product_price);
            Console.WriteLine(p2.UnitOfMeasurment);
            Console.WriteLine(p2.Product_qty);
        }

        private static void firstObjectOfProduct()
        {
            product p1 = new product();
            p1.Product_id = 1;
            p1.Product_name = "Laptop";
            p1.Product_price = 80000;
            p1.UnitOfMeasurment = "each";
            p1.Product_qty = 100;
            Console.WriteLine($"First Object of Product");
            Console.WriteLine(p1.Product_id);
            Console.WriteLine(p1.Product_name);
            Console.WriteLine(p1.Product_price);
            Console.WriteLine(p1.UnitOfMeasurment);
            Console.WriteLine(p1.Product_qty);
        }

        private static void sumOfElementOfArray()
        {
            int[] arr = { 2, 4, 7, 9, 3, 10 };
            int sum = 0;
            foreach (int i in arr)
            {
                sum = sum + i;

            }
            Console.WriteLine($"The sum of elements of array is : {sum}");
        }

    }
}
