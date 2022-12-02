// Created by: sophie
// Created on: dec 2020
//
// This program has if statements

using System;

class Program
{
    public static void Main(string[] args)
    {
        string size;
        string sauce;

        double TAXRATE = 0.13;

        double small = 2.00;
        double medium = 2.50;
        double large = 3.00;

        double ketchup = 0.5;
        double mustard = 0.93;
        double relish = 0.5;
        double sriracha = 0.14;

        double subtotal;
        double total;


        Console.Write("Enter a size (small, medium, large): ");
        size = Convert.ToString(Console.ReadLine());
        Console.Write("Enter a sauce (ketchup, mustard, relish, sriracha, none): ");
        sauce = Convert.ToString(Console.ReadLine());

        //small size
        if (size == "small")
        {
            if (sauce == "ketchup")
            {
                subtotal = small + ketchup;
                total = subtotal + (subtotal * TAXRATE);
                Console.WriteLine(size + ": $" + Math.Round(small, 2) + "  " + sauce + ": $" + ketchup + "  subtotal: $" + Math.Round(subtotal, 2) + "  total: $" + Math.Round(total, 2));
            }
            else if (sauce == "mustard")
            {
                subtotal = small + mustard;
                total = subtotal + (subtotal * TAXRATE);
                Console.WriteLine(size + ": $" + Math.Round(small, 2) + "  " + sauce + ": $" + mustard + "  subtotal: $" + Math.Round(subtotal, 2) + "  total: $" + Math.Round(total, 2));
            }
            else if (sauce == "relish")
            {
                subtotal = small + relish;
                total = subtotal + (subtotal * TAXRATE);
                Console.WriteLine(size + ": $" + Math.Round(small, 2) + "  " + sauce + ": $" + relish + "  subtotal: $" + Math.Round(subtotal, 2) + "  total: $" + Math.Round(total, 2));
            }
            else if (sauce == "sriracha")
            {
                subtotal = small + sriracha;
                total = subtotal + (subtotal * TAXRATE);
                Console.WriteLine(size + ": $" + Math.Round(small, 2) + "  " + sauce + ": $" + sriracha + "  subtotal: $" + Math.Round(subtotal, 2) + "  total: $" + Math.Round(total, 2));
            }
            else
            {
                total = small + (small * TAXRATE);
                Console.WriteLine(size + ": $" + Math.Round(small, 2) + "  none: $0   subtotal: $" + Math.Round(small, 2) + "  total: $" + Math.Round(total, 2));
            }
        }
        //medium size
        else if (size == "medium")
        {
            if (sauce == "ketchup")
            {
                subtotal = medium + ketchup;
                total = subtotal + (subtotal * TAXRATE);
                Console.WriteLine(size + ": $" + Math.Round(medium, 2) + "  " + sauce + ": $" + Math.Round(ketchup, 2) + "  subtotal: $" + Math.Round(subtotal, 2) + "  total: $" + Math.Round(total, 2));
            }
            else if (sauce == "mustard")
            {
                subtotal = medium + mustard;
                total = subtotal + (subtotal * TAXRATE);
                Console.WriteLine(size + ": $" + Math.Round(medium, 2) + "  " + sauce + ": $" + mustard + "  subtotal: $" + Math.Round(subtotal, 2) + "  total: $" + Math.Round(total, 2));
            }
            else if (sauce == "relish")
            {
                subtotal = medium + relish;
                total = subtotal + (subtotal * TAXRATE);
                Console.WriteLine(size + ": $" + Math.Round(medium, 2) + "  " + sauce + ": $" + Math.Round(relish, 2) + "  subtotal: $" + Math.Round(subtotal, 2) + "  total: $" + Math.Round(total, 2));
            }
            else if (sauce == "sriracha")
            {
                subtotal = medium + sriracha;
                total = subtotal + (subtotal * TAXRATE);
                Console.WriteLine(size + ": $" + Math.Round(medium, 2) + "  " + sauce + ": $" + Math.Round(sriracha, 2) + "  subtotal: $" + Math.Round(subtotal, 2) + "  total: $" + Math.Round(total, 2));
            }
            else
            {
                total = medium + (medium * TAXRATE);
                Console.WriteLine(size + ": $" + Math.Round(medium, 2) + "  none: $0   subtotal: $" + Math.Round(medium, 2) + "  total: $" + Math.Round(total, 2));
            }
        }
        else
        {
            if (sauce == "ketchup")
            {
                subtotal = large + ketchup;
                total = subtotal + (subtotal * TAXRATE);
                Console.WriteLine(size + ": $" + Math.Round(large, 2) + "  " + sauce + ": $" + Math.Round(ketchup, 2) + "  subtotal: $" + Math.Round(subtotal, 2) + "  total: $" + Math.Round(total, 2));
            }
            else if (sauce == "mustard")
            {
                subtotal = large + mustard;
                total = subtotal + (subtotal * TAXRATE);
                Console.WriteLine(size + ": $" + Math.Round(large, 2) + "  " + sauce + ": $" + mustard + "  subtotal: $" + Math.Round(subtotal, 2) + "  total: $" + Math.Round(total, 2));
            }
            else if (sauce == "relish")
            {
                subtotal = large + relish;
                total = subtotal + (subtotal * TAXRATE);
                Console.WriteLine(size + ": $" + Math.Round(large, 2) + "  " + sauce + ": $" + Math.Round(relish, 2) + "  subtotal: $" + Math.Round(subtotal, 2) + "  total: $" + Math.Round(total, 2));
            }
            else if (sauce == "sriracha")
            {
                subtotal = large + sriracha;
                total = subtotal + (subtotal * TAXRATE);
                Console.WriteLine(size + ": $" + Math.Round(large, 2) + "  " + sauce + ": $" + Math.Round(sriracha, 2) + "  subtotal: $" + Math.Round(subtotal, 2) + "  total: $" + Math.Round(total, 2));
            }
            else
            {
                total = large + (large * TAXRATE);
                Console.WriteLine(size + ": $" + Math.Round(large, 2) + "  none: $0   subtotal: $" + Math.Round(large, 2) + "  total: $" + Math.Round(total, 2));
            }
        }
        Console.WriteLine("\nDone.");
    }
}