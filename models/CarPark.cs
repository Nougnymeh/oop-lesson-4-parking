using System;
using System.Collections.Generic;
using System.Text;

namespace oop_lesson_4_parking.models
{
   public  class CarPark
    {
        public List<customers> listOfCustomers = new List<customers>();
        public CarParkCharges carParkCharges = new CarParkCharges();
        public CarPark()
        {
            Console.WriteLine("I am in the CarPark");
        }

        public override string ToString()
        {
            return "I am in the CarPark()";
        }

        public void CalculateCharges()
        {
            foreach (customers customer in listOfCustomers)
            {
                int calculatecharge = carParkCharges.CalculateCharge(customer.hoursParked);
                Console.WriteLine($"Calculating charge for customer: cost is {calculatecharge}");
            }
        }


    }
}
