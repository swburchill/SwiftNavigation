using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftNavigationChallange
{
   public class Program
   {
      public bool isNumberPrime(int n)
      {
         bool isPrime = false;
         for (int i = 2; i < n; i++)
         {
            if(n%i == 0)
            {
               return isPrime;
            }
         }
         isPrime = true;
         return isPrime;
      }

      public void updateFibonacciNumbers(ref int c, ref int n)
      {
         int temp = c;
         c = n;
         n += temp;
      }

      public string chooseString(int number)
      {
         string output = "";
         if (isNumberPrime(number))
         {
            output += "BuzzFizz";
         }
         else
         {
            if (number % 5 == 0)
            {
               output += "Fizz";
            }
            if (number % 3 == 0)
            {
               output += "Buzz";
            }
            if (output == "")
            {
               output += number.ToString();
            }
         }
         return output;
      }

      public int fibonacci(int n)
      {
         //Assuming that we want to start fibonacci from 1,1 instead of 0,1 as it makes
         //the algorithm more efficient to not always check if dividing by 0.
         int current = 1;
         int next = 1;
         int count = 0;
         string output = "";

         while (count < n)
         {
            output = chooseString(current); 
            Console.WriteLine(output);          
            updateFibonacciNumbers(ref current, ref next);
            count++;
         }
         return count;
      }

      static void Main(string[] args)
      {
         Console.WriteLine("This program generates the first n Fibonacci numbers F(n), printing\n"
            + "\"Buzz\" when F(n) is divisible by 3\n"
            + "\"Fizz\" when F(n) is divisible by 5\n"
            + "\"BuzzFizz\" when F(n) is prime\n"
            + "the value F(n) otherwise.\n");
         Console.WriteLine("Enter an integer n to generate the Fibonacci numbers or q to exit:");
         string input = Console.ReadLine();
         int n;
         Program p = new Program();

         while(input != "q")
         {
            if(int.TryParse(input, out n))
            {
               p.fibonacci(n);
               Console.WriteLine("\nEnter an integer n to generate the Fibonacci numbers or q to exit:");
            }
            else
            {
               Console.WriteLine("Invalid Input. Enter an integer n to generate the Fibonacci numbers or q to exit:");
            }
            input = Console.ReadLine();
         }
      }
   }
}
