int[]numbers = new int[15];
Console.WriteLine("Введите 15 целых чисел");
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}
int max = numbers.Max();
int min = numbers.Min();
int sum = max + min;
int difference = max - min;
Console.WriteLine($"Сумма максимального и минимального элиментов:{sum}");
Console.WriteLine($"Разность максимальногои минимального элиментов:{difference}");