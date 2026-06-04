namespace ListPracticeTaskSheet1
{
    internal class Program
    {
        public static void BrowserHistoryTracker()
        {
            Stack<string> browserHistory = new Stack<string>();
            browserHistory.Push("page1");
            browserHistory.Push("page2");
            browserHistory.Push("page3");
            browserHistory.Push("page4");
            browserHistory.Push("page5");
            foreach (string browser in browserHistory)
            {
                Console.WriteLine(browser);
            }
            Console.WriteLine("current page ");
            Console.WriteLine(browserHistory.Peek());
            Console.WriteLine("Back Navigation ");
            string removePage1 = browserHistory.Pop();
            Console.WriteLine(removePage1);
            string removePage2 = browserHistory.Pop();
            Console.WriteLine(removePage2);

            Console.WriteLine("remaining history ");
            foreach (string browser in browserHistory)
            {
                Console.WriteLine(browser);
            }
            string searchUrl = "page2";
            Console.WriteLine(searchUrl + " exists in history: " + browserHistory.Contains(searchUrl));
            Console.WriteLine("Total Pages Remaining");
            Console.WriteLine(browserHistory.Count);
        }
        public static void HotelCheckInQueue()
        {
            Queue<string> checkInQueue = new Queue<string>();
            checkInQueue.Enqueue("Ahmed");
            checkInQueue.Enqueue("Sara");
            checkInQueue.Enqueue("Hidaya");
            checkInQueue.Enqueue("Nasser");
            checkInQueue.Enqueue("Salim");
            foreach (string Q in checkInQueue)
            {
                Console.WriteLine(Q);
            }
            Console.WriteLine("current page ");
            Console.WriteLine(checkInQueue.Peek());
            Console.WriteLine("Back Navigation ");
            string removePage1 = checkInQueue.Dequeue();
            Console.WriteLine(removePage1);
            string removePage2 = checkInQueue.Dequeue();
            Console.WriteLine(removePage2);
            Console.WriteLine("remaining queue ");
            foreach (string Q in checkInQueue)
            {
                Console.WriteLine(Q);
            }
            string searchGuest = "Hidaya";
            Console.WriteLine("Guest Search");
            Console.WriteLine(searchGuest + " is still waiting: " + checkInQueue.Contains(searchGuest));
            Console.WriteLine("Total Guests Remaining ");
            Console.WriteLine(checkInQueue.Count);


        }
        static void Main(string[] args)
        {
            Console.WriteLine("================================= ");
            Console.WriteLine("           Proplems ");
            Console.WriteLine("================================= ");
            Console.WriteLine("1:  Browser History Tracker ");
            Console.WriteLine("2: Hotel Check-In Queue ");
            Console.WriteLine("3: Text Editor Undo System   ");
            Console.WriteLine("4:  Hospital Emergency Room Triage   ");
            Console.WriteLine("5:Parenthesis Validator   ");
            Console.WriteLine("6:  Print Spooler with Priority Re-Insertion ");
            Console.WriteLine("7:  Reverse a Sentence Word by Word");
            Console.WriteLine("8: Multi-Level Undo with Redo ");
            Console.WriteLine("9:  Ticket Counter Simulation ");
            Console.WriteLine("10: Order Processing Pipeline with Statistics");
            Console.WriteLine("================================= ");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            { case 1:
                    BrowserHistoryTracker();
                    break;
                case 2:
                    HotelCheckInQueue();
                    break;
                case 3:
                    break;
            }
        }
    }
}