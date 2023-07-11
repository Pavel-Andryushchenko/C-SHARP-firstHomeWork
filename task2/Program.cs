Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2) Console.WriteLine("Числа равны");
else
{
    if (number1 < number2)
    {
        Console.WriteLine($"{number2} больше чем {number1}");
    }
    else
    {
        Console.WriteLine($"{number1} больше чем {number2}");
    }
}