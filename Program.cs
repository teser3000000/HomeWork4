Random random = new Random();
int[,] evaluations = new int[5, 3];
int[] numbres = new int[5];

int positionX = 11;
Console.WriteLine("Ученик Информатика        Разработка игр      Основы алгоритмизации");

for (int i = 0; i < evaluations.GetLength(0); i++)
{
    Console.Write($"{i + 1}");
    for (int j = 0; j < evaluations.GetLength(1); j++)
    {
        Console.SetCursorPosition(positionX, i + 1);
        evaluations[i, j] = int.Parse(Console.ReadLine());
        positionX += 21;
        if (positionX > 53) positionX = 11;
    }
}
Console.WriteLine("Вы заполнили таблицу!\n Для продолжения проверки, нажмите Enter");
//Console.ReadKey(true);


Console.WriteLine("Вывод массива:");
for (int i = 0; i < numbres.Length; i++)
{
    numbres[i] = random.Next(-1, 9);
    Console.Write(numbres[i] + " ");
}
Console.WriteLine("\n");
Console.WriteLine("Вывод элементов массива в обратном порядке:");
for (int i = numbres.Length - 1; i >= 0; i--)
{
    Console.Write(numbres[i] + " ");
}
Console.WriteLine("\n");
Console.WriteLine("Вывод элементов массива через 1:");
for (int i = 0; i < numbres.Length; i += 2)
{
    Console.Write(numbres[i] + " ");
}
Console.WriteLine("\n");
Console.WriteLine("Остановить цикл, когда встретися -1:");
for (int i = 0; i < numbres.Length; i++)
{
    if (numbres[i] == -1) break;
    Console.Write(numbres[i] + " ");
}
