Console.Write("Введите первое число:\n");
int a  = int.Parse(Console.ReadLine());
Console.Write("Введите второе число:\n");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число:\n");
int c = int.Parse(Console.ReadLine());
if(a > b && a > c){
    Console.WriteLine($"Самое большое число: {a}");
}
else if (a < b && b > c){
    Console.WriteLine($"Самое большое число: {b}");
}
else if (a < b && b < c)
{
    Console.WriteLine($"Самое большое число: {c}");

}

//супермегаальфаговнокодdetected

//подсмотрел у модных посонов что можно логическое И запихать в код и будет счастье

//но с подключением библиотек типа Math.Min и Math.Math все конечно веселее идет, но это уже совсем другая история
 
