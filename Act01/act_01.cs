// BRUNO C. RODGERS, 12/03/2025
// Receive "x" value and show the firsts "x" prime number.

// Import NameSpace System
using System;

class ShowPrimeNums
{
    static void Main(string[] args)
    {
        // Iterate - qtt prime nums to show
        Console.Write("Enter desired number of prime numbers: ");
        int x = int.Parse(Console.ReadLine());

        int count = 0; // Counter display
        int number = 2; // Start: 2

        // Initialize iterate loop
        while (count < x)
        {
            // Call IsPrime function
            if (IsPrime(number))
            {
                // Print number and increment counter
                Console.WriteLine(number);
                count++;
            }

        // Next number
        number++;
        }
    }

    // Verify function
    static bool IsPrime(int num)
    {
        // x < 2 isn't prime
        if (num < 2) return false;

        // Verify divisos betwen 2 and square root
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            // If has divisor, isn't prime
            if (num % i == 0) return false;
        }

        // If divisor not found, is prime
        return true;
    }
}