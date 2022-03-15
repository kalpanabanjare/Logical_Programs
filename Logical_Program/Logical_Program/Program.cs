using System;
namespace Logical_Program
{
    public class LogicalPrograms
    {
        // UC1 for Fibonacci Series
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

        // UC2 for Perfect Number

        public void PerfectNumber()
        {
            Console.WriteLine("Check whether a given number is perfect number or not:");
            Console.Write("Input the  number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            Console.WriteLine("The positive divisor  : ");
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                    Console.Write("{0}  ", i);
                }
            }
            Console.WriteLine("The sum of the divisor is : {0}", sum);
            if (sum == num)
                Console.WriteLine("The number is perfect.");
            else
                Console.WriteLine("The number is not perfect.");
        }

        // UC3 Prime Number

        public void PrimeNumber()
        {
            int result = 0;
            int flag = 0;
            Console.Write("Enter the Number to check Prime: ");
            int num = int.Parse(Console.ReadLine());
            result = num / 2;
            for (int i = 2; i <= result; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Number is not Prime");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine("Number is Prime");
        }

        // UC 4 Reverce Number

        public void ReverceNumber()
        {
            int reverse = 0;
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                int rem = num % 10;
                reverse = reverse * 10 + rem;
                num /= 10;
            }
            Console.WriteLine("Reversed Number: " + reverse);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for problem");
            Console.WriteLine("1 for Fibonacci Series");
            Console.WriteLine("2 for Perfect Number");
            Console.WriteLine("3 for Prime Number");
            Console.WriteLine("4 for Reverce Number");
            int Problem = Convert.ToInt32(Console.ReadLine());
            LogicalPrograms logicalProgram = new LogicalPrograms();
            
            switch (Problem)
            {
                case 1:
                    logicalProgram.Fibonacci_Series();
                    break;
                case 2:
                    logicalProgram.PerfectNumber();
                    break ;
                case 3:
                    logicalProgram.PrimeNumber();
                    break;
                case 4:
                    logicalProgram.ReverceNumber();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    
    }
}