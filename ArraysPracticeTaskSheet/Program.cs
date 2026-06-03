using System.Diagnostics;
using System.IO.Pipelines;

namespace ArraysPracticeTaskSheet
{
    internal class Program
    {
        public static void TemperatureLog()
        {
            double[] temperature = { 35.6, 36.9, 23.7, 34.9, 36.5, 46.4, 36.7 };
            for (int i = 0; i < temperature.Length; i++)
            {
                Console.WriteLine("Day " + (i + 1) + ": " + temperature[i] + " C");
            }
            Console.WriteLine("Total readings: " + temperature.Length);
        }
        public static void StudentScoreBoard()
        {
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
        }
        public static void ProductPriceFinder()
        {
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
        }
        public static void RaceFinishTimes()
        {
            int[] finishTimes = { 33, 46, 51, 36, 39, 69, 44, 47 };
            Console.WriteLine("Original Finish Times:");
            foreach (int time in finishTimes)
            {
                Console.WriteLine(time + " seconds");
            }
            Array.Sort(finishTimes);
            Console.WriteLine("Finish times after sorted:");
            foreach (int time in finishTimes)
            {
                Console.WriteLine(time + " seconds");
            }
            Console.WriteLine("Number of participants: " + finishTimes.Length);
        }
        public static void ClassroomGradeReport()
        {
            int[] grades = { 99, 96, 87, 98, 100, 90, 94, 89, 88, 91 };
            Array.Sort(grades);
            Array.Reverse(grades);
            Console.WriteLine("ascending order:");
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
            }
        }
        public static void WarehouseInventoryCheck()
        {
            int[] quantities = { 8, 7, 15, 12, 21, 13, 6, 19 };
            int total = 0;
            for (int i = 0; i < quantities.Length; i++)
            {
                total = total + quantities[i];
            }
            Console.WriteLine("toatal stock: " + total);
            double average = total / quantities.Length;
            Console.WriteLine("stock per slot: " + average);
            int target = 15;
            int indexs = Array.IndexOf(quantities, target);
            if (indexs != -1)
            {
                Console.WriteLine("Quantity " + target + " found at index: " + indexs);
            }
            else
            {
                Console.WriteLine("Quantity not found .");
            }
        }
        public static void LibraryBookShelfScanner()
        {
            int[] copies = { 19, 20, 35, 30, 25, 33, 15, 32, 22 };
            Console.WriteLine("Original order:");
            foreach (int copy in copies)
            {
                Console.WriteLine(copy);
            }
            Array.Sort(copies);
            Console.WriteLine("Sorted order:");
            foreach (int copy in copies)
            {
                Console.WriteLine(copy);
            }
            int maxCopies = copies[copies.Length - 1];
            Console.WriteLine("The title with the most copies: " + maxCopies);
            bool hasZero = false;
            for (int i = 0; i < copies.Length; i++)
            {
                if (copies[i] == 0)
                {
                    hasZero = true;
                    break;
                }

            }
            if (hasZero)
            {
                Console.WriteLine("There is at least one book with zero copies.");
            }
            else
            {
                Console.WriteLine("No books have zero copies.");
            }
        }
        public static void SalesPerformanceAnalyzer()
        {
            double[] revenue = { 12500.50, 13800.75, 11200.25, 15600.80, 14950.40, 16700.90, 14250.60, 13500.30, 17100.45, 15900.20, 14800.70, 16250.85 };
            double[] sortedCopy = new double[revenue.Length];
            for (int i = 0; i < revenue.Length; i++)
            {
                Console.WriteLine("Month" + (i + 1) + ": " + revenue[i] + "OMR");
            }
            for (int i = 0; i < revenue.Length; i++)
            {
                sortedCopy[i] = revenue[i];
            }
            Array.Sort(sortedCopy);
            for (int i = 0; i < sortedCopy.Length; i++)
            {
                Console.WriteLine(sortedCopy[i] + "OMR");
            }
            double worstRevenue = sortedCopy[0];
            double bestRevenue = sortedCopy[sortedCopy.Length - 1];
            Console.WriteLine($"Worst Month Revenue: " + worstRevenue + "OMR");
            Console.WriteLine($"Best Month Revenue: " + bestRevenue + "OMR");
            double totalRevenue = 0;
            for (int i = 0; i < revenue.Length; i++)
            {
                totalRevenue = totalRevenue + revenue[i];
            }

            double avrerageRevenue = totalRevenue / revenue.Length;
            Console.WriteLine("Average Monthly Revenue: " + avrerageRevenue + "OMR");
        }
        public static void FlightSeat()
        {
            int[] seats = { 12, 5, 8, 1, 3, 5, 7, 9, 10, 2, 4, 6, 11, 13, 14 };
            int[] reverse = new int[seats.Length];
            foreach (int seat in seats)
            {
                Console.WriteLine("seat: " + seat);
            }
            Array.Sort(seats);
            foreach (int seat in seats)
            {
                Console.WriteLine("seat: " + seat);
            }
            int target1 = 15;
            int index1 = Array.IndexOf(seats, target1);
            if (index1 != -1)
            {
                Console.WriteLine("seat " + target1 + " found at index: " + index1);
            }
            else
            {
                Console.WriteLine("seat not found .");
            }
            Array.Copy(seats, reverse, seats.Length);
            Array.Reverse(reverse);

            Console.WriteLine("Sorted vs Reversed:");
            for (int i = 0; i < seats.Length; i++)
            {
                Console.WriteLine("Sorted:" + seats[i] + " Reversed:" + reverse[i]);
            }
            Console.WriteLine("Total number of seats: " + seats.Length);
        }
        public static void HospitalPatient()
        {
            int[] severity = { 5, 2, 8, 1, 4, 3, 7, 6, 2, 9, 10, 3, 4, 5, 1, 6, 7, 8, 2, 3 };
            Console.WriteLine("Original Severity Scores:");
            foreach (int s in severity)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            Array.Sort(severity);
            Console.WriteLine("Sort Severity Scores:");
            foreach (int s in severity)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            double median = (severity[9] + severity[10]) / 2.0;
            Console.WriteLine("Medain: " + median);
            int criticalCount = 0;
            foreach (int s in severity)
            {
                if (s <= 3)
                    criticalCount++;
            }
            int target2 = 2;
            int index2 = Array.IndexOf(severity, target2);

            if (index2 != -1)
                Console.WriteLine("Severity " + target2 + " found it");
            else
                Console.WriteLine("Severity " + target2 + " not found");
        }
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
                    TemperatureLog();
                    break;
                case 2:
                    StudentScoreBoard();
                    break;
                case 3:
                    ProductPriceFinder();
                    break;
                case 4:
                    RaceFinishTimes();
                    break;
                case 5:
                    ClassroomGradeReport();
                    break;
                case 6:
                    WarehouseInventoryCheck();
                    break;
                case 7:
                    LibraryBookShelfScanner();

                    break;
                case 8:
                    SalesPerformanceAnalyzer();
                    break;
                case 9:
                    FlightSeat();
                    break;
                case 10:
                    HospitalPatient();
                    break;
            }
           
        }
    }
}
