Console.Write("Введите число:\n");
int a  = int.Parse(Console.ReadLine());
if (a % 2 ==0 ){
    Console.WriteLine($"Число {a} четное число");
}
else 
{
    Console.WriteLine($"Число {a} нечетное число");
}