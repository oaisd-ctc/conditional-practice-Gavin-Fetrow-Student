using System;
using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        FahrenheitToCelsius(68); // Test FahrenheitToCelsius Function with a random value

        // Test your functions by calling them below:
        CheckForPositiveNegativeZero(-1); // This should output: "Your number is negative"
        CheckForPositiveNegativeZero(0); // This should output: "Your number is zero"
        CheckForPositiveNegativeZero(1); // This should output: "Your number is positive"
        FindMinimum(4, 11, 6); // ...
        FindMaximum(30, 22, 47); // ...
        IsDivisibleBy5(31);
        CheckEvenOrOdd(18);
        CheckVowelOrConsonant('b');
        DisplayDayOfWeek(4); // This should output: "Thursday"

    }

    public static void FahrenheitToCelsius(double fahrenheit)
    {
        double celsiusDegree = (fahrenheit - 32) * 5/9; 
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsiusDegree} degrees Celsius.");
    }

    // Define your functions below:
    public static void CheckForPositiveNegativeZero (int number)
    {
        if (number < 0)
        {
            Console.WriteLine("Your number is negative.");
        }
        else if (number > 0)
        {
            Console.WriteLine("Your number is positive.");
        }
        else
        {
            Console.WriteLine("Your number is zero.");
        }
    }

    public static void FindMinimum (int num1, int num2, int num3)
    {
        // num1 is the smallest if:
        // num1 is less than or equal to num2, AND num1 is less than or equal to num3
        // 7 8 9
        // 7 7 8
        // 8 7 8
        // 7 7 6
        // 9 9 9
        if (num1 <= num2 && num1 <=num3)
        {
            Console.WriteLine("The minimum value is " + num1 + ".");
        }
        else if (num2 <= num1 && num2 <= num3)
        {
            Console.WriteLine("The minimum value is " + num2 + ".");
        }
        else
        {
            Console.WriteLine("The minimum value is " + num3 + ".");
        }
    }

    public static void FindMaximum (int num1, int num2, int num3)
    {
        if (num1 >= num2 && num1 >= num3)
        {
            Console.WriteLine("The maximum value is " + num1 + ".");
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            Console.WriteLine("The maximum value is " + num2 + ".");
        }
        else
        {
            Console.WriteLine("The maximum value is " + num3 + ".");
        }
    }

    public static void IsDivisibleBy5 (int number)
    {
        if (number % 5 == 0)
        {
            Console.WriteLine(number + " is divisible by 5.");
        }
        else
        {
            Console.WriteLine(number + " is not divisible by 5.");
        }
    }

    public static void CheckEvenOrOdd (int number)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine(number + " is an even number.");
        }
        else
        {
            Console.WriteLine(number + " is an odd number.");
        }
    }

    public static void CheckVowelOrConsonant (char letter)
    {
        switch (letter)
        {
            case 'a':
            case 'A':
            case 'e':
            case 'E':
            case 'i':
            case 'I':
            case 'o':
            case 'O':
            case 'u':
            case 'U':
                Console.WriteLine(letter + " is a vowel.");
                break;
            default:
                Console.WriteLine(letter + " is a consonant.");
                break;
        }
    }

    public static void DisplayDayOfWeek (int dayCode)
    {
        switch (dayCode)
        {
        case 0:
            Console.WriteLine("Sunday");
            break;
        case 1:
            Console.WriteLine("Monday");
            break;
        case 2:
            Console.WriteLine("Tuesday");
            break;
        case 3:
            Console.WriteLine("Wednesday");
            break;
        case 4:
            Console.WriteLine("Thursday");
            break;
        case 5:
            Console.WriteLine("Friday");
            break;
        case 6:
            Console.WriteLine("Saturday");
            break;
        }
    }
}