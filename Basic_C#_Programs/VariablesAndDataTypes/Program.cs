﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This is a simple program
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favourite number?");
            //string favouriteNumber = Console.ReadLine();
            //int favNumber = Convert.ToInt32(favouriteNumber);
            //int total = favNumber + 5;
            //Console.WriteLine("Your favourite number plus 5 is: " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemperature = -23;
            char questionMark = '\u2103';
            decimal moneyInBank = 100.5m;
            double heightInCentimeters = 211.30202092;
            float secondsLeft = 2.62f;
            short temperatureOnMars = -341;
            string myName = "Tim";

            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);



            Console.WriteLine(rainingStatus );
            Console.ReadLine();

        }
    }
}
