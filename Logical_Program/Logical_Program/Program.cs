using System;
namespace Logical_Program
{
    public class LogicalPrograms
    {
        public void Fibonacci_Series()
        {
            int num1 = 0, num2 = 1, num3, i, number;
            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            Console.Write(num1 + " " + num2 + " "); //printing 0 and 1    
            for (i = 2; i < number; i++) //loop starts from 2 because 0 and 1 are already printed    
            {
                num3 = num1 + num2;
                Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for problem");
            int Problem = Convert.ToInt32(Console.ReadLine());
            LogicalPrograms logicalProgram = new LogicalPrograms();
            
            switch (Problem)
            {
                case 1:
                    logicalProgram.Fibonacci_Series();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    
    }
}