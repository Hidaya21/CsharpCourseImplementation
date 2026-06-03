namespace ListPracticeTaskSheet
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
                    List <double> temperature = new List <double> { 35.6, 36.9, 23.7, 34.9, 36.5, 46.4, 36.7 };
                    for (int i = 0; i < temperature.Count; i++)
                    {
                        Console.WriteLine("Day " + (i + 1) + ": " + temperature[i] + " C");
                    }
                    Console.WriteLine("Total readings: " + temperature.Count);
                    break;
                case 2:
                    List<double> scores = new List<double> { 99, 95, 90, 98, 89, 93 };
                    Console.WriteLine("Original Order:");
                    foreach (int score in scores)
                    {
                        Console.WriteLine(score);
                    }
                    scores.Reverse();
                    Console.WriteLine("Reversed Order:");
                    for (int i = 0; i < scores.Count; i++)
                    {
                        Console.WriteLine(scores[i]);
                    }
                    break;
                case 3:
                    List<double> price = new List<double> { 3.5, 4.0, 2.2, 5.5, 6.5 };
                    for (int i = 0; i < price.Count; i++)
                    {
                        Console.WriteLine("Product " + (i + 1) + ": " + price[i]);
                    }
                    double targetPrice = 3.5;
                    int index = price.IndexOf(targetPrice);
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
                    List<int> finishTimes = new List<int> { 33, 46, 51, 36, 39, 69, 44, 47 };
                    Console.WriteLine("Original Finish Times:");
                    foreach (int time in finishTimes)
                    {
                        Console.WriteLine(time + " seconds");
                    }
                    finishTimes.Sort();
                    Console.WriteLine("Finish times after sorted:");
                    foreach (int time in finishTimes)
                    {
                        Console.WriteLine(time + " seconds");
                    }
                    Console.WriteLine("Number of participants: " + finishTimes.Count);
                    break;  
                case 5:
                    List<int> grades = new List<int> { 99, 96, 87, 98, 100, 90, 94, 89, 88, 91 };
                    grades.Sort();
                    grades.Reverse();
                    Console.WriteLine("ascending order:");
                    for (int i = 0; i < grades.Count; i++)
                    {
                        Console.WriteLine(grades[i]);
                    }
                    break;
                case 6:
                    List<int> quantities = new List<int> { 8, 7, 15, 12, 21, 13, 6, 19 };
                    int total = 0;
                    for (int i = 0; i < quantities.Count; i++)
                    {
                        total = total + quantities[i];
                    }
                    Console.WriteLine("toatal stock: " + total);
                    double average = total / quantities.Count;
                    Console.WriteLine("stock per slot: " + average);
                    int target = 15;
                    int indexs = quantities.IndexOf(target);
                    if (indexs != -1)
                    {
                        Console.WriteLine("Quantity " + target + " found at index: " + indexs);
                    }
                    else
                    {
                        Console.WriteLine("Quantity not found .");
                    }
                    break; 
                case 7:
                    List<int> copies = new List<int> { 19, 20, 35, 30, 25, 33, 15, 32, 22 };
                    Console.WriteLine("Original order:");
                    foreach (int copy in copies)
                    {
                        Console.WriteLine(copy);
                    }
                    copies.Sort();
                    Console.WriteLine("Sorted order:");
                    foreach (int copy in copies)
                    {
                        Console.WriteLine(copy);
                    }
                    int maxCopies = copies[copies.Count - 1];
                    Console.WriteLine("The title with the most copies: " + maxCopies);
                    bool hasZero = false;
                    for (int i = 0; i < copies.Count; i++)
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
                    break;
                case 8:
                    List<double> revenue = new List<double> { 12500.50, 13800.75, 11200.25, 15600.80, 14950.40, 16700.90, 14250.60, 13500.30, 17100.45, 15900.20, 14800.70, 16250.85 };
                    double[] sortedCopy = new double[revenue.Count];
                    for (int i = 0; i < revenue.Count; i++)
                    {
                        Console.WriteLine("Month" + (i + 1) + ": " + revenue[i] + "OMR");
                    }
                    for (int i = 0; i < revenue.Count; i++)
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
                    for (int i = 0; i < revenue.Count; i++)
                    {
                        totalRevenue = totalRevenue + revenue[i];
                    }
                    double avrerageRevenue = totalRevenue / revenue.Count;
                    Console.WriteLine("Average Monthly Revenue: " + avrerageRevenue + "OMR");
                    break;
                case 9:
                    List<int> seats = new List<int> { 12, 5, 8, 1, 3, 5, 7, 9, 10, 2, 4, 6, 11, 13, 14 };
                    List<int> reverse = new List<int>();

                    foreach (int seat in seats)
                    {
                        Console.WriteLine("seat: " + seat);
                    }
                    seats.Sort();
                    foreach (int seat in seats)
                    {
                        Console.WriteLine("seat: " + seat);
                    }
                    int target1 = 15;
                    int index1 = seats.IndexOf(target1);
                    if (index1 != -1)
                    {
                        Console.WriteLine("seat " + target1 + " found at index: " + index1);
                    }
                    else
                    {
                        Console.WriteLine("seat not found .");
                    }
                    reverse = new List<int>(seats);
                    reverse.Reverse();
                    Console.WriteLine("Sorted vs Reversed:");
                    for (int i = 0; i < seats.Count; i++)
                    {
                        Console.WriteLine("Sorted:" + seats[i] + " Reversed:" + reverse[i]);
                    }
                    Console.WriteLine("Total number of seats: " + seats.Count);
                    break;
                case 10:
                    List<int> severity = new List<int> { 5, 2, 8, 1, 4, 3, 7, 6, 2, 9, 10, 3, 4, 5, 1, 6, 7, 8, 2, 3 };
                    Console.WriteLine("Original Severity Scores:");
                    foreach (int s in severity)
                    {
                        Console.Write(s + " ");
                    }
                    Console.WriteLine();
                    severity.Sort();
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
                    int index2 = severity.IndexOf( target2);

                    if (index2 != -1)
                        Console.WriteLine("Severity " + target2 + " found it");
                    else
                        Console.WriteLine("Severity " + target2 + " not found");
                    break;

            }
  
        }
    }
}
