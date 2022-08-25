// See https://aka.ms/new-console-template for more information
public class Exercise2
{
    static void Main()
    {
        int a, b;
        Console.Write("Enter the a value: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the b value: ");
        b = Convert.ToInt32(Console.ReadLine());
        var result = a > b ? "a is greater than b" : "a is less than b";
        Console.WriteLine(result);
    }
}