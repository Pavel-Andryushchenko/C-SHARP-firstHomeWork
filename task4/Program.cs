Console.WriteLine("Введите колличество сравниваемых чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[size];
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите {i+1} чисо: ");
    mas[i] = Convert.ToInt32(Console.ReadLine());
}
int max = 0;
for (int i = 0; i < size; i++)
{
    if (mas[i] > max) max = mas[i];
}
Console.WriteLine("Максимальное из введенных вами чисел: " + max);