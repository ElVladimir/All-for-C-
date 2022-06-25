Console.Write("Введите первое число\n");
int a  = int.Parse(Console.ReadLine());
Console.Write("Введите второе число\n");
int b = int.Parse(Console.ReadLine());
if(a < b){
    Console.WriteLine($"Самое большое число: {b}");
}
else if (a > b){
    Console.WriteLine($"Самое большое число: {a}");
}
else if (a == b)
{
    Console.WriteLine($"Выпей-ка яду и съешь еще этих мягких французских булок");
}