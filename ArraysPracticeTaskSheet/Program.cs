using System.Diagnostics;

namespace ArraysPracticeTaskSheet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================= ");
            Console.WriteLine("           Proplems ");
            Console.WriteLine("================================= ");
            Console.WriteLine("1: Temperature Log ");
            Console.WriteLine("2: Student Score Board    ");
            Console.WriteLine("3: Product Price Finder   ");
            Console.WriteLine("4: Race Finish Times   ");
            Console.WriteLine("5: Classroom Grade Report   ");
            Console.WriteLine("6: Warehouse Inventory Check ");
            Console.WriteLine("7: Library Book Shelf Scanner");
            Console.WriteLine("8: Sales Performance Analyzer ");
            Console.WriteLine("9: Flight Seat Allocation Display ");
            Console.WriteLine("10: Hospital Patient Priority Queue ");
            Console.WriteLine("================================= ");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    double [] temperature = { 35.6 ,36.9 ,23.7 ,34.9 ,36.5 ,46.4, 36.7 };
                    for (int i =0; i < temperature.Length; i++)
                    {
                        Console.WriteLine("Day " + (i + 1) + ": " + temperature[i] + " C");
                    }
                    Console.WriteLine("Total readings: " + temperature.Length);
            
            break;
                case 2:
                    int[] scores = { 99, 95, 90, 98, 89, 93 };
                    Console.WriteLine("Original Order:");
                    foreach (int score in scores)
                    {
                        Console.WriteLine(score);
                    }
                    Array.Reverse(scores);  
                    Console.WriteLine("Reversed Order:");
                    for (int i = 0; i < scores.Length; i++)
                    {
                        Console.WriteLine(scores[i]);
                    }

                    break;
                case 3:
                    double[] price = { 3.5, 4.0, 2.2, 5.5, 6.5 };
                    for (int i = 0; i < price.Length; i++)
                    {
                        Console.WriteLine("Product " + (i + 1) + ": " + price[i]);
                    }
                    double targetPrice = 7.25;
                    int index = Array.IndexOf(price, targetPrice);
                    if (index != -1)
                    {
                        Console.WriteLine("Price " + targetPrice + " found at index: " + index);
                    }
                    else
                    {
                        Console.WriteLine("Price not found in the array.");
                    }
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;

            }
            }
    }
}
