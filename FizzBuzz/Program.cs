using System;

namespace FizzBuzz
{
    public class Program

    {

        /* Your challenge:

        Write a public method that accepts a number

        when the number is divisible by 3 return the word fizz

        when the number is divisible by 5 return the word buzz

        when the number is divisible by both, return the word fizzbuzz*/



        public static string FizzBuzz(int x)
        {
            
           
             
            if (x%3 ==0 && x%5==0)
            {
                return "fizzbuzz";
       
            }
            else if (x%5==0)
            {
                return "buzz";

            }
            else if (x%3==0)
            {
                return "fizz";
            }
            else
            {
                return "neither";
            }
        }
        static void Main (string[]args)
        {
            Console.WriteLine("Enter a Number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FizzBuzz (x));
        }
           


        

           
            


        

            
        

    
    }
}
