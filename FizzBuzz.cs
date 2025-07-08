internal class Program
{
    private static void Main(string[] args)
    {
        FizzBuzz(5);
        FizzBuzz(3);
        FizzBuzz(7);
        FizzBuzz(15);
    }

    // Write a public method that accepts a number
    public static string FizzBuzz(int number)
    {

        if (number == null)
        {
            return "";
        }

        if (number % 5 == 0 && number % 3 == 0)
        {
            Console.WriteLine("fizzbuzz");
            return "fizzbuzz";
        }
        if (number % 3 == 0)
        {
            Console.WriteLine("fizz");
            return "fizz";
        }
        if (number % 5 == 0)
        {
            Console.WriteLine("buzz");
            return "buzz";
        }
        else
        {
            Console.WriteLine("Your number did not work. Please try again.");
            return "";
        }
    }
}
