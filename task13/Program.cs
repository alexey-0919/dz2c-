
Console.WriteLine("Input number");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 99)
{
    while (a / 10 > 100)
    {
        int result = a / 10;
        a = a / 10;
    }
    {
        Console.WriteLine($"The third digit: {a % 10}");   // int result = a % 10; 
                                                           // Console.WriteLine("The third digit " + result);
    }
}
else
    Console.WriteLine("There is no third digit");