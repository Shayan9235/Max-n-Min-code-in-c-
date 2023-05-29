using System.Transactions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("enter a number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter another number: ");
        int number2 = int.Parse(Console.ReadLine());
        int max = Math.Max(number1, number2);
        Console.WriteLine(max);


        }
        
}