﻿using System;
using System.Threading;

namespace RocketLaunchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rocket Countdown! ");
            Console.WriteLine("Get ready for liftoff...");

            for (int i = 10; i >=1; i--)
            {
                Console.WriteLine($"T-{i} seconds...");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Ignition sequence start! ");
            Console.WriteLine("Engines are firing...");

            int countdown = 5;
            while (countdown > 0)
            {
                Console.WriteLine($"T-{countdown} seconds...");
                Thread.Sleep(1000); 
                countdown--;

            }

            Console.WriteLine("Liftoff! The rocket is on its way to space! ");
            Console.WriteLine("Mission accomplished. Have a stellar day!");

            for (int altitude = 0; altitude <= 100; altitude += 10)
            {
                Console.WriteLine($"Altitude: {altitude} km");
                Thread.Sleep(500);
            }




        } // end main
    } // end class
} // end namespace
