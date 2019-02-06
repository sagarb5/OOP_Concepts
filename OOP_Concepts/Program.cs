using System;

namespace OOP_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Student = new Person { salutation = "Well Congrats!", firstName = "Sagar", lastName = "Billore"};
            Console.WriteLine(Student.getName());
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(); // Exit Statement
        } // end of main
    }// end of class program
}
