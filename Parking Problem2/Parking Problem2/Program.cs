using System;

namespace Parking_Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Client C1 = new Client("Kate", 1);
            Client C2 = new Client("Elliot", 4);
            Client C3 = new Client("Leonor", 10);
            Client C4 = new Client("Michael", 24);
            
            Console.WriteLine(C1);
            Console.WriteLine("Total charge is {0} $", C1.calculateCharges(C1.Time_Spent));
            Console.WriteLine(C2);
            Console.WriteLine("Total charge is {0} $",C2.calculateCharges(C2.Time_Spent));
            Console.WriteLine(C3);
            Console.WriteLine("Total charge is {0} $", C3.calculateCharges(C3.Time_Spent));
            Console.WriteLine(C4);
            Console.WriteLine("Total charge is {0} $", C4.calculateCharges(C4.Time_Spent));
            
            
            
        }
    }
}