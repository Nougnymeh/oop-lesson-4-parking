using System;
using System.Collections.Generic;
using System.Text;

namespace oop_lesson_4_parking.models
{
   public class customers
    {
      
        public int hoursParked { get; set; }
        public string registration { get; set; }
        public customers(int hoursParked, string registration)
        {

            Console.WriteLine("I am the customer");
            this.hoursParked = hoursParked;
            this.registration = registration;
        }

       
        public override string ToString()
        {
            return "I am the customers()";
        }
    }
}
