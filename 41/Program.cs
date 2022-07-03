// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
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