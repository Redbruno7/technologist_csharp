// BRUNO C. RODGERS, 12/03/2025
// Receive 3 numbers and determine biggest number

using System;

class Act02
{
    static void Main()
    {
        // Receive 3 numbers
        Console.Write("Enter 1º number: ");
        double num_1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter 2º number: ");
        double num_2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter 3º numver: ");
        double num_3 = Convert.ToDouble(Console.ReadLine());

        // Determine biggest number
        double biggest;

        if (num_1 >= num_2 && num_1 >= num_3)
        {
            biggest = num_1;
        }
        else if (num_2 >= num_1 && num_2 >= num_3)
        {
            biggest = num_2;
        }
        else
        {
            biggest = num_3;
        }

        // Show biggest number
        Console.WriteLine($"The biggest number is: {biggest}");
    }
}