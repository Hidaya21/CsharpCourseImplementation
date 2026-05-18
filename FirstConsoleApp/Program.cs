using System.Net;

namespace FirstConsoleApp
{
    internal class Program
    {
 
        static void Main(string[] args)
        {
            string patientName = "";
            string patientEmail = "";
            int patientPhone = 0000;
            string pStatus = "";
            bool isPatientActive = false;
            bool exit = false;
            while(exit == false)
            {
                Console.WriteLine("          Main Menu ");
                Console.WriteLine("================================");
                Console.WriteLine("1) Add patient information");
                Console.WriteLine("2) View patient information ");
                Console.WriteLine("3) Edit patient information ");
                Console.WriteLine("4) Cancle patient information ");
                Console.WriteLine("0) Exit ");
                Console.WriteLine("Please select an option from the menu: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    //add patient information
                    case 1:
                        Console.WriteLine("     Add patient information ");
                        Console.WriteLine("================================");
                        if (isPatientActive == true)
                        {
                            Console.WriteLine("account information already exists please edit account information if you want to change it");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("1) Enter patient Name: ");
                            patientName = Console.ReadLine();
                            Console.WriteLine("2) Enter patient Email: ");
                            patientEmail = Console.ReadLine();
                            Console.WriteLine("3) Enter patient phone: ");
                            patientPhone = int.Parse(Console.ReadLine());
                            isPatientActive = true;
                            Console.WriteLine("account information added successfully.");
                        }

                        break;
                    //view patient information
                    case 2:
                        if (isPatientActive == false)
                        {
                            Console.WriteLine("no account information found please add account information first");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Patient Name: " + patientName);
                            Console.WriteLine("Patient Email: " + patientEmail);
                            Console.WriteLine("Patient Phone: " + patientPhone);
                        }
                        break;
                    //edit patient information
                    case 3:
                        Console.WriteLine("Choose an option to edit:");
                        Console.WriteLine("1) Edit Patient Name");
                        Console.WriteLine("2) Edit Patient Email");
                        Console.WriteLine("3) Edit Patient Phone");
                        Console.WriteLine("Please enter your choice ");
                        int choice = int.Parse(Console.ReadLine());

                        if (choice == 1)
                        {
                            Console.WriteLine("Enter New Patient Name: ");
                            patientName = Console.ReadLine();
                            Console.WriteLine("Patient Name Updated Successfully! ");
                        }
                        else if (choice == 2)
                        {
                            Console.WriteLine("Enter New Patient Email: ");
                            patientEmail = Console.ReadLine();
                            Console.WriteLine("Patient Email Updated Successfully! ");
                        }
                        else if (choice == 3)
                        {
                            Console.WriteLine("Enter New Patient Phone: ");
                            patientPhone = int.Parse(Console.ReadLine());
                            Console.WriteLine("Patient Phone Updated Successfully! ");
                        }
                        else
                        {
                            Console.WriteLine("invalid option please try again");
                        }

                        break;
                    case 4:
                        //Cancle patient information
                        Console.WriteLine("1) Enter patient Name: ");
                        string pName = Console.ReadLine();
                        Console.WriteLine("2) Enter patient Email: ");
                        string pEmail = Console.ReadLine();
                        Console.WriteLine("3) Enter patient phone: ");
                        int pPhone = int.Parse(Console.ReadLine());
                        if (isPatientActive && patientName == pName && patientEmail == pEmail && patientPhone == pPhone)
                        {
                            pStatus = "Canceled";
                            Console.WriteLine("patient information cancelled.");
                        }
                        else
                        {
                            Console.WriteLine("patient information not found! ");
                        }
                        break;
                    case 0:
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
