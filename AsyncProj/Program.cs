Random r = new Random();
int[] mas = new int[30];
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = r.Next(-9, 10);
    Console.Write(mas[i] + " ");
}

Console.WriteLine();

int sum = mas.Where(x => x < 0 && x % 2 != 0).Sum();

Console.WriteLine($"Сумма элементов, которые являются нечетными и отрицательными: {sum}");