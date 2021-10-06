using oop_lesson_4_parking.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace oop_lesson_4_parking.tes
{
    public class Driver
    {
        public Driver()
        {
            Console.WriteLine("I am the code driver");
        }
        public void CreateObjects()
        {
            CarPark carpark = new CarPark();
            carpark.listOfCustomers.Add(new customers(1, "a"));
            carpark.listOfCustomers.Add(new customers(2,"b"));
            carpark.listOfCustomers.Add(new customers(2,"c"));
            carpark.listOfCustomers.Add(new customers(7,"d"));
            carpark.listOfCustomers.Add(new customers(9,"e"));

            carpark.CalculateCharges();
            
            
            
            customers customer = new customers(8,"g");
            CarParkCharges carParkCharges = new CarParkCharges();

            Console.WriteLine(customer.ToString());
            Console.WriteLine(carParkCharges.ToString());
            Console.WriteLine(carpark.ToString());

        }
    }
}
