using System;

namespace our_to_console;

class Program
{
    static void Main(string[] args)
    {
        //string text = "It's easy to win forgiveness for being wrong;\n" +
        //    "being right is what gets you\ninto real trouble.";
        //Console.WriteLine(text);

        //Console.WriteLine("Enter first number: ");
        //int a=int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter second number: ");
        //int b=int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter third number: ");
        //int c=int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter fourth number: ");
        //int d=int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter fiveth number: ");
        //int e=int.Parse(Console.ReadLine());
        //int sum=a+b+c+d+e;
        //int min = 0;
        //int max = 0;
        //if (a < b && a < c&&a<d&&a<e)min = a;
        //if (b < a && b < c&&b<d&&b<e)min = b;
        //if (c < b && a > c&&c<d&&c<e)min = c;
        //if (d < b && d < c&&a>d&&d<e)min = d;
        //if (e < b && e < c&&e<d&&a>e)min = e;
        //if (a > b && a > c && a > d && a > e) max = a;
        //if (a < b && b > c && b > d && b > e) max = b;
        //if (c > b && a < c && c > d && c > e) max = c;
        //if (d > b && d > c && a < d && d > e) max = d;
        //if (e > b && e > c && e > d && a < e) max = e;
        //Console.WriteLine(a+" "+b+" "+c+" "+d+" "+e);
        //Console.WriteLine("Summa is: "+sum);
        //Console.WriteLine("Maximum is: " + max);
        //Console.WriteLine("Minimum is: " + min);        {
        //Console.Write("Enter six-digit numbeer: ");
        //int inputNumber = int.Parse(Console.ReadLine());

        //int reversedNumber = ReverseNumber(inputNumber);

        //Console.WriteLine($"Result: {reversedN
        //umber}");


        //static int ReverseNumber(int number)
        //{
        //    int reversedNumber = 0;

        //    while (number > 0)
        //    {
        //        reversedNumber = reversedNumber * 10 + number % 10;
        //        number /= 10;
        //    }

        //    return reversedNumber;
        //}


        //    Console.Write("Enter the start of range: ");
        //    int startRange = int.Parse(Console.ReadLine());

        //    Console.Write("Enter thr end of range: ");
        //    int endRange = int.Parse(Console.ReadLine());

        //    DisplayFibonacciNumbersInRange(startRange, endRange);
        //}

        //static void DisplayFibonacciNumbersInRange(int start, int end)
        //{
        //    int a = 0, b = 1, c = 0;

        //    Console.Write("Fibonaci numbers in range: ");

        //    while (c <= end)
        //    {
        //        if (c >= start)
        //        {
        //            Console.Write($"{c}, ");
        //        }

        //        a = b;
        //        b = c;
        //        c = a + b;
        //    }

        //    Console.WriteLine();


        //    Console.Write("Enter number A: ");
        //    int a = int.Parse(Console.ReadLine());

        //    Console.Write("Enter number B (B > A): ");
        //    int b = int.Parse(Console.ReadLine());

        //    DisplayNumbersWithRepetition(a, b);
        //}

        //static void DisplayNumbersWithRepetition(int start, int end)
        //{
        //    for (int i = start; i <= end; i++)
        //    {
        //        for (int j = 0; j < i; j++)
        //        {
        //            Console.Write($"{i} ");
        //        }

        //        Console.WriteLine();
        //    }

        Console.Write("Enter length of line: ");
        int length = int.Parse(Console.ReadLine());

        Console.Write("Enter character: ");
        char fillCharacter = char.Parse(Console.ReadLine());

        Console.Write("Enter direction (h - horizontal, v - vertical): ");
        char direction = char.Parse(Console.ReadLine());

        DisplayLine(length, fillCharacter, direction);
    }

    static void DisplayLine(int length, char fillChar, char direction)
    {
        if (direction == 'h')
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(fillChar);
            }
        }
        else if (direction == 'v')
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(fillChar);
            }
        }
        else
        {
            Console.WriteLine("Wrong direction. Enter hг' for horizontal line or 'v' for vertical line.");
        }
    }
}