void RandomNumber()
{
    int num = new Random().Next(100, 1000);
    Console.WriteLine($"{num} удаление второй цифры это {num / 100}{num % 10}");
}
RandomNumber();