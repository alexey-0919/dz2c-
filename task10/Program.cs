Console.WriteLine("Input three-digit number");
int A = Convert.ToInt32(Console.ReadLine());

if (A >99 && A < 1000)
{
    int result1 = A / 10;
    int result2 = result1 % 10;
    Console.WriteLine ("Second number = " + result2);
}
else
    Console.WriteLine("Введите трехзначное число");