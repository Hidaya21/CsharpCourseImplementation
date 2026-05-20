


using Microsoft.VisualBasic;
using System.Diagnostics.Metrics;
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
            //if(bookIsRegister == false)
            //{

            //    Console.Write("book is not registered ");
            //}
            //else {
            Console.Write("Enter book title: ");
            bookTitle = Console.ReadLine().Trim();
            Console.Write("Enter book author: ");
            bookAuthor = Console.ReadLine();
            Console.Write("Enter number of copies: ");
             numberBookCopies = int.Parse(Console.ReadLine());
            Console.Write("Enter genre (press Enter to skip): ");
             bookGener = Console.ReadLine();
            bookIsRegister = true;
            //}
      

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
                        //if (bookIsRegister == false)
                        //{
                          //  Console.WriteLine("No book registered.");
                        //}
                        //else
                        //{
                            if (SearchBook(keyword))
                            {
                                Console.WriteLine("Book title found: " + bookTitle);
                            }
                            else
                            {
                                Console.WriteLine("Book title not found.");
                            }
                        //}
                        break;

                    //Register Book 
                    case 8:
                        

                        RegisterBook( out bookTitle,  out bookAuthor, out numberBookCopies);
                        break;

                }            
            }
        }
    }
}
