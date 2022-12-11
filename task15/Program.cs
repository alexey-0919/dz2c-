int[] array = {1, 2, 3, 4, 5, 6, 7};

Console.WriteLine("Input number 1-7");
int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 || day > 7)
    Console.WriteLine("Вы ввели неверное число");
else if (day > array[4])
    Console.WriteLine("Да, это выходной");
else
    Console.WriteLine("Нет, это рабочий день");


