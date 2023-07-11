Console.Write("Введите положительное число: ");
try                                                                           // в try описываем 
{
    int number =int.Parse(Console.ReadLine());
    if (number <= 0) 
    {
        Console.WriteLine("Число не положительное!");
    }
    else
    {
        Console.WriteLine($"Четные числа в интревале от 1 до {number} ");
        for (int i=1; i < number; i++) 
        {
            if (i % 2 == 0)
            {
                Console.Write( i + ", ");
            }
        }
        Console.Write(number);
    }
}
catch 
{
     Console.WriteLine("Недопустимые значения!");
}

