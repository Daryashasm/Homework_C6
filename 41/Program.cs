Console.Write("Введите кол-во задаваемых чисел, М = ");
int M = Convert.ToInt32(Console.ReadLine());
int [] mass = new int [M];
for (int i = 0; i < M; i++)
    {
    Console.Write($"Введите число, N =  ");
    mass[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("Ваши числа: ");
    for (int i = 0; i < M; i++)
    {
    Console.Write($"{mass[i]}, ");
    }
    Console.WriteLine();
    int sum = 0;
    for (int i = 0; i < M; i++)
    {
    if (mass[i] > 0)
    {
        sum = sum + 1;
    }
    }
    Console.WriteLine($"Среди введеных чисел, {sum} больше 0 ");