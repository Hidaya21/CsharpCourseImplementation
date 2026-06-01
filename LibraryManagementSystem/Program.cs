


using Microsoft.VisualBasic;
using System.Diagnostics.Metrics;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibraryManagementSystem
{
    internal class Program
    {
        //member data
        static string memberName = "";
        static string memberId = "";
        static string memberEmail = "";
        static string membershipExpiryDate = "";
        static string memberTier = "";
        static bool memberIsRegister = false;

        //book data
        static string bookTitle = "";
        static string bookAuthor = "";
        static string bookGener = "";
        static DateTime date = DateTime.Now;
        static int numberBookCopies = 0;
        static bool bookIsRegister = false;
        static int totalBookBorrowed = 0;
        static int  maxBookCopies = 0;

        static int totalFinesPaid = 0;
        string keyword = "";

        public static void PrintMenu()
        {
            Console.WriteLine("================================= ");
            Console.WriteLine("           Main Menu");
            Console.WriteLine("================================= ");
            Console.WriteLine("0) Register Memnber ");
            Console.WriteLine("1) Display Member Profile   ");
            Console.WriteLine("2) Search Book by Title  ");
            Console.WriteLine("3) Borrow a Book  ");
            Console.WriteLine("4) Return a Book   ");
            Console.WriteLine("5) Calculate Late Fine ");
            Console.WriteLine("6) Apply Member Discount");
            Console.WriteLine("7) Check Borrowing Eligibility ");
            Console.WriteLine("8) Register Book");
            Console.WriteLine("9) Generate Member ID ");
            Console.WriteLine("10) Display Book Details ");
            Console.WriteLine("11) Calculate Renewal Fee");
            Console.WriteLine("12) Update Member Email  ");
            Console.WriteLine("13) Session Summary ");
            Console.WriteLine("================================= ");
            
        }
        public static void CheckMemberRegister()

        {
            Console.WriteLine(" This member information already exists! ");       
        }
        public static void IsMemberRegister()

        {
            Console.WriteLine("No memeber registered.");
        }

        public static void RegisterMemnber()
        {
            Console.Write("Enter member name: ");
            memberName = Console.ReadLine();
            Console.Write("Enter new member Id: ");
            memberId = Console.ReadLine();
            Console.Write("Enter new member email: ");
            memberEmail = Console.ReadLine();    
            memberIsRegister = true;
            Console.WriteLine(date);
            Console.WriteLine("member information added successfully.");
        }

        public static void DisplayMemberProfile()
        {
            Console.WriteLine("member name: ".PadLeft(5) + memberName);
            Console.WriteLine("member Id: ".PadLeft(5) + memberId);
            Console.WriteLine("member email:".PadLeft(5) + memberEmail);
            Console.WriteLine("date time:".PadLeft(5) + Convert.ToString(date));
        }

        //Register Book 
        public static void RegisterBook(out string bookTitle,out string bookAuthor,out int numberBookCopies, string bookGener = "general")
        {
            Console.Write("Enter book title: ");
            bookTitle = Console.ReadLine().Trim();
            Console.Write("Enter book author: ");
            bookAuthor = Console.ReadLine();
            Console.Write("Enter number of copies: ");
             numberBookCopies = int.Parse(Console.ReadLine());
            Console.Write("Enter genre (press Enter to skip): ");
             bookGener = Console.ReadLine();
            bookIsRegister = true;
 
        }
        //Search book by title
        public static bool SearchBook(string keyword)
        {    
            keyword = keyword.Trim();
            if (bookTitle.ToLower().Contains(keyword))
            { 
                return true;
            }
            else
            {

                return false;
            }
        }
        //Borrow a Book
        public static void BorrowBook(ref int copies)
        {
            if (copies == 0) 
            {
                Console.WriteLine("No copies available!");
            }
            else
            {
                copies = Math.Max(0, copies - 1);
            }
        }
        //Return a Book 
        public static void ReturnBook(ref int copies)
        {
            copies =  copies + 1;

        }
        //Calculate Late Fine 
        public static double CalculateFine(int days)
        {
            double fine = Math.Sqrt(days) * 2;
            return Math.Round(fine, 2);
        }
        public static double Discount(double amount)
        {
            return Math.Round(amount * 0.9, 2);
        }

        public static double Discount(double amount, string tier)
        {
            tier = tier.ToUpper();

            if (tier == "GOLD")
                return Math.Round(amount * 0.8, 2);
            else if (tier == "SILVER")
                return Math.Round(amount * 0.9, 2);
            else
                return Math.Round(amount * 0.95, 2);
        }
        //Check Borrowing Eligibility
        public static bool CheckEligibility(string expiry)
        {
            DateTime exp = DateTime.Parse(expiry);
            return exp >= DateTime.Today;
        }
        //Generate Member ID 
        public static string GenerateMemberID()
        {
            double val = Math.Sqrt(DateTime.Now.Ticks);
            return memberName.Substring(0, 2) + ((int)val).ToString();
        }

        // Display Book Details 
        public static void DisplayBook(string title, string author, int copies, string genre)
        {
            Console.WriteLine("Title: ".PadRight(10) + title);
            Console.WriteLine("Author: ".PadRight(10) + author);
            Console.WriteLine("Copies: ".PadRight(10) + copies);
            Console.WriteLine("Genre: ".PadRight(10) + genre);
        }

        // Calculate Renewal Fee
        public static double RenewalFee(int days)
        {
            return Math.Round(Math.Ceiling(days * 1.5), 2);
        }

        public static double RenewalFee(int days, bool premium)
        {
            double fee = Math.Ceiling(days * 1.5);
            if (premium) fee /= 2;
            return Math.Round(fee, 2);
        }

        //Update Member Email 
        public static bool UpdateEmail(string email, out string cleanEmail)
        {
            cleanEmail = email.Trim();

            if (cleanEmail.Contains("@") && cleanEmail.Length > 5)
                return true;

            return false;
        }
        //Session Summary 
        public static void SessionSummary()
        {
            Console.WriteLine("Name: " + memberName);
            Console.WriteLine("Books Borrowed: " + totalBookBorrowed);
            Console.WriteLine("Total Fines: " + (totalFinesPaid, 2));
            Console.WriteLine("Date: " + Convert.ToString(DateTime.Now));
        }

        static void Main(string[] args)
        {
            bool exit = false;
            while(exit == false)
            {
                PrintMenu();
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    //register new member
                    case 0:
                        Console.WriteLine("================================");
                        Console.WriteLine("     Add member information ");
                        Console.WriteLine("================================");
                        if (memberIsRegister == true)
                        {
                            CheckMemberRegister();    
                            return;
                        }
                        else
                        {
                            RegisterMemnber();
                        }
                        break;
                    case 1:
                        if (memberIsRegister == false)
                        {
                            IsMemberRegister();
                        }
                        else
                        {
                            DisplayMemberProfile();
                        }
                        break;
                   //Search book by title
                    case 2:
                        Console.Write("Enter keyword book title: ");
                        string keyword = Console.ReadLine().Trim();
                        if (bookIsRegister == false)
                        {
                            Console.WriteLine("No book registered.");
                        }
                        else
                        {
                            if (SearchBook(keyword))
                            {
                                Console.WriteLine("Book title found: " + bookTitle);
                            }
                            else
                            {
                                Console.WriteLine("Book title not found.");
                            }
                        }
                        break;
                    //Borrow a Book
                    case 3:
                        if (bookIsRegister == false)
                        {
                            Console.WriteLine("No book registered.");
                        }
                        else
                        {
                            BorrowBook(ref numberBookCopies);
                            Console.WriteLine(numberBookCopies);
                        }
                        break;
                    //Return a Book
                    case 4:
                        if (bookIsRegister == false)
                        {
                            Console.WriteLine("No book registered.");
                        }
                        else
                        {
                            ReturnBook(ref numberBookCopies);
                            Console.WriteLine(numberBookCopies);
                        }
                        break;
                    //Calculate Late Fine 
                    case 5:
                        Console.Write("Enter number of Days: ");
                        int fine = int.Parse(Console.ReadLine());
                        CalculateFine(fine);
                        totalFinesPaid = totalFinesPaid + fine;
                        Console.WriteLine(fine);
                        break;
                    case 6:
                        Console.WriteLine(Discount(100, memberTier));
                        break;
                    //Check Borrowing  Eligibility
                    case 7:
                         Console.WriteLine(CheckEligibility(membershipExpiryDate));
                        break;

                    //Register Book 
                    case 8:
                            RegisterBook(out bookTitle, out bookAuthor, out numberBookCopies);
                        break;
                    //Generate Member ID 
                    case 9:
                        memberId = GenerateMemberID();
                        Console.WriteLine(memberId);
                        break;
                    //Display Book Details 
                    case 10:
                        DisplayBook(title: bookTitle, author: bookAuthor, copies: numberBookCopies, genre: bookGener);
                        break;
                        //Calculate Renewal Fee
                    case 11:
                        Console.WriteLine(RenewalFee(5, true));
                        break;
                    //Update Member Email 
                    case 12:
                        string clean;
                        if (UpdateEmail(Console.ReadLine(), out clean))
                            memberEmail = clean;
                        break;
                    //Session Summary 
                    case 13:
                        SessionSummary();
                        break;

                }
                Console.Write(" press any key to countinue...  ");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
