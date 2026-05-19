using System.Numerics;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HotelManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string guestName = "";
            string guestPhone = "";
            int roomNumber = 0;
            string roomType = "";
            double nightlyRate = 0.0;
            DateTime checkInDate= DateTime.Now;
            DateTime checkOutDate = DateTime.Now;
            int numberOfNights = 0;
            string roomNotes = "";
            double discountPercentage = 0;
            int loyaltyPoints = 0;
            bool isRegistered = false ;
            bool currentlyCheckedIn = false;
            bool exit = false;
            Random rand = new Random();

            while (exit == false) {
                Console.WriteLine("================================= ");
                Console.WriteLine("           Main Menu");
                Console.WriteLine("================================= ");
                Console.WriteLine("0) Register New Guest ");
                Console.WriteLine("1) View Guest Information  ");
                Console.WriteLine("2) Check-In Guestt ");
                Console.WriteLine("3) Check-Out & Bill ");
                Console.WriteLine("4) Apply Discount  ");
                Console.WriteLine("5) Upgrade Room ");
                Console.WriteLine("6) Add Room Service Note ");
                Console.WriteLine("7) Search Guest by Name ");
                Console.WriteLine("8) Calculate Loyalty Points");
                Console.WriteLine("9) Print Receipt ");
                Console.WriteLine("10) Edit Guest Name ");
                Console.WriteLine("11) Exit ");
                Console.WriteLine("================================= ");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    //Register New Gues
                    case 0:
                        Console.Write("Enter guest name: ");
                        guestName = Console.ReadLine().Trim();
                        Console.Write("Enter guest phone: ");
                        guestPhone = Console.ReadLine().Trim();
                        Console.Write("Enter room type: ");
                        roomType = Console.ReadLine();
                        Console.Write("Enter nightly rate : ");
                        nightlyRate = Double.Parse(Console.ReadLine());
                        roomNumber = rand.Next(100,500);
                        isRegistered = true;
                        break;
                    //View Guest Information 
                    case 1:
                        if (isRegistered == false)
                        {
                            Console.WriteLine("No guest registered.");
                            return;
                        }
                        else {
                            Console.WriteLine("Guest name " + guestName.ToUpper());
                            Console.WriteLine("Guest phone " + guestPhone);
                            Console.WriteLine("Room Type " + roomType.ToUpper());
                            Console.WriteLine("Nightly Rate " +Math.Round(nightlyRate));
                            Console.WriteLine("Room Number " + Convert.ToString(roomNumber));
                        }

                        break;
                    //Check-In Guest
                    case 2:
                        if (isRegistered == false)
                        {
                            Console.WriteLine("Please register guest first.");
                            return;
                        }
                        Console.Write("Enter number of nights: ");
                        numberOfNights = int.Parse(Console.ReadLine());
                        checkInDate = DateTime.Today;
                        checkOutDate = checkInDate.AddDays(numberOfNights);
                        currentlyCheckedIn = true;
                        Console.WriteLine("Guest checked in successfully ");
                        Console.WriteLine("Check-In Date: " + checkInDate.ToString("dd/MM/yyyy"));
                        Console.WriteLine("Check-Out Date: " + checkOutDate.ToString("dd/MM/yyyy"));
                        break;
                    //Check-Out & Bill
                    case 3:
                        if(currentlyCheckedIn == false)
                        {
                            Console.WriteLine("No guest check in");
                            return;
                        }
                        else
                        {
                            double totalBill = nightlyRate * numberOfNights;
                            double discountAmount1 = totalBill * (discountPercentage / 100);
                            double finalBill1 = totalBill - discountAmount1;
                            currentlyCheckedIn = false;
                            isRegistered = false;
                            Console.WriteLine("Guest checked out successfully ");
                            Console.WriteLine("Total Bill: " + Math.Round(totalBill));
                            Console.WriteLine("Discount Amount: " + Math.Round(discountAmount1));
                            Console.WriteLine("final Bill: " + Math.Round(finalBill1));
                        }

                        break;
                    //Apply Discount
                    case 4:
                        Console.WriteLine("Apply  percentage dicount:  ");
                         discountPercentage = double.Parse(Console.ReadLine());
                        double originalAmount = nightlyRate * numberOfNights;
                        double discountedAmount = originalAmount * (discountPercentage / 100);
                        double amountSaved = originalAmount - discountedAmount; ;   
                        Console.WriteLine("Original Amount Bill: " + Math.Round(originalAmount));
                        Console.WriteLine("Discount Amount: " + Math.Round(discountedAmount));
                        Console.WriteLine("final Bill: " + Math.Abs(amountSaved));
                        break;
                    //Upgrade Room 
                    case 5:
                        Console.WriteLine("Enter new room type: ");
                        string newRoomType = Console.ReadLine();
                        Console.WriteLine("Enter new nightly rate: ");
                        double newNightlyRate =double.Parse(Console.ReadLine());
                        double higherRate = Math.Max(nightlyRate, newNightlyRate);
                        double lowerRate = Math.Min(nightlyRate, newNightlyRate);
                        double difference = Math.Abs(nightlyRate - newNightlyRate);
                        nightlyRate = newNightlyRate;
                        Console.WriteLine("Room upgraded successfully ");
                        Console.WriteLine("Old Room Type: " + roomType);
                        Console.WriteLine("New Room Type: " + newRoomType);
                        Console.WriteLine("Higher Rate: " + higherRate);
                        Console.WriteLine("Lower Rate: " + lowerRate);
                        Console.WriteLine("Difference Per Night: " + difference);
                        break;
                    //Add Room Service Note
                    case 6:
                        Console.Write("Enter service room note: ");
                        roomNotes = Console.ReadLine();
                        if (roomNotes.Length == 0)
                        {
                            Console.WriteLine("Note cannot be blank.");
                            
                        }
                        roomNotes = roomNotes.Replace("bad", "good");
                        Console.WriteLine("Note added successfully.");
                        Console.WriteLine("Room Notes: " + roomNotes);
                        Console.WriteLine("Total Notes Length: " + roomNotes.Length);
                        break;
                    //Search Guest by Name 
                    case 7:
                        if (isRegistered == false)
                        {
                            Console.WriteLine("Please register guest first.");
                            return;
                        }
                        else
                        {
                            Console.Write("Enter keyword name to search: ");
                            string keyword = Console.ReadLine().ToLower();
                            if (guestName.ToLower().Contains(keyword))
                            {
                                Console.WriteLine("Guest found: " + guestName);
                            }
                            else
                            {
                                Console.WriteLine("Guest not found ");
                            }
                        }
                        break;
                    //Calculate Loyalty Points
                    case 8:
                        double earnedPoints = Math.Pow(numberOfNights, 2);
                        earnedPoints = Math.Round(earnedPoints);
                        loyaltyPoints = loyaltyPoints + Convert.ToInt32(earnedPoints);

                        Console.WriteLine("Earned Points: " + earnedPoints);
                        Console.WriteLine("Total Loyalty Points: " +
                            loyaltyPoints);
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        Console.WriteLine("Back to Main Menu ");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("invalid option please try again");
                        break;



                }
                Console.Write(" press any key to countinue...  ");
                Console.ReadLine();
                Console.Clear();
            }
            
        }
    }
}
