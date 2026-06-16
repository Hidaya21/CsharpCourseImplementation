//Write a C# program to create a class named Student that represents a student in an institute. The class should contain appropriate fields and properties, using different access modifiers (public, private, etc.).
//The class must include methods to:
//Change the student's password.
//Add a course/subject.
//Remove a course/subject.
//Update the student's GPA.
//Display the GPA only after entering the correct password.
//In the Main method, create one or more objects of the Student class and test all the methods to demonstrate their functionality.

namespace OOP
{
    public class Student
    {
        public string Name;
        public int StudentId;
        private string password;
        private double gpa;
        private List<string> subjects;


        //Constructor
        public Student(string name, int studentId, string password)
        {
            name = name;
            StudentId = studentId;
            this.password = password;
            subjects = new List<string>();
        }
        //change password
        public void changPassword(string oldPassword, string newPassword)
        {
            if (oldPassword == newPassword)
            {
                password = newPassword;
                Console.WriteLine("password changed successfully");
            }
            else
            {
                Console.WriteLine("password not change");
            }
        }
        //Add Subject 
        public void AddSubject(string subject)
        {
            subjects.Add(subject);
            Console.WriteLine(subject + "added successfully");
        }
        //Remove Subject
        public void RemoveSubject(string subject)
        {
            subjects.Remove(subject);
            Console.WriteLine(subject + "Removed successfully");
        }
        //update GPA
        public void UpdateGPA(double newGPA)
        {
            gpa = newGPA;
            Console.WriteLine("GPA updated successfully");
        }
        //display GPA with password verification
        public void DisplayGPA(string enteredPassword)
        {
            if (enteredPassword == password)
            {
                Console.WriteLine("GPA: " + gpa);
            }
            else
            {
                Console.WriteLine("Inccorect password");
            }

        }
        public void DisplaySubjects()
        {
            Console.WriteLine("subjects");
            foreach (string subject in subjects)
            {
                Console.WriteLine("- " + subject);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // create student object
            Student s = new Student("Hidaya", 101, "1234");

            //Test methods
            s.AddSubject("C#");
            s.AddSubject("Java");
            s.DisplaySubjects();
            s.RemoveSubject("C#");
            s.DisplaySubjects();
            s.UpdateGPA(3.8);
            s.DisplayGPA("1111"); // Wrong password
            s.DisplayGPA("1234"); // Correct password
            s.changPassword("1234", "abcd");
            s.DisplayGPA("1234"); // Old password
            s.DisplayGPA("abcd"); // New password



        }
    }
}