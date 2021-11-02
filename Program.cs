using System;

namespace SwitchStatements2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter student's roll numbers:  ");
            int RollNo = Convert.ToInt32(Console.ReadLine());


            switch(RollNo)
            {
                case 1:
                    Console.WriteLine("Name: StudentA");
                    Console.WriteLine("Age: 18");
                    break;
                case 2:
                    Console.WriteLine("Name: StudentB");
                    Console.WriteLine("Age: 17");
                    break;
                case 3:
                    Console.WriteLine("Name: StudentC");
                    Console.WriteLine("Age: 16");
                    break;
                case 4:
                    Console.WriteLine("Name: StudentD");
                    Console.WriteLine("Age: 15");
                    break;
                case 5:
                    Console.WriteLine("Name: StudentE");
                    Console.WriteLine("Age: 14");
                    break;
                default:
                    Console.WriteLine("No student found.");
                    break;
            }
        }
    }
}
