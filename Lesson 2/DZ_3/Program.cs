void Num3(int num)
{
    Console.Write($"{num} --");
    if (num < 99){
        Console.WriteLine("Третьего числа нет");
        return;
    }

    while (num > 999) num = num / 10;
    Console.WriteLine (num % 10);
}
Num3(int.Parse(Console.ReadLine()));