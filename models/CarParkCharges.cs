using System;
using System.Collections.Generic;
using System.Text;

namespace oop_lesson_4_parking.models
{
   public class CarParkCharges
    {
        public int minFee { get; set; }
        public int minHours { get; set; }
        public CarParkCharges(int _minFee = 2, int _minHours=3)
        {
            Console.Write("I am the CarParkCharges");
            minFee = _minFee;
            minHours = _minFee;
        }

        public override string ToString()
        {
            return "I am the CarParkCharges()";
        }

       

        internal int CalculateCharge(int hoursParked)
        {
            int calculateFee= hoursParked< minHours? minFee: hoursParked*minFee;
            return calculateFee;
        }
    }
}
