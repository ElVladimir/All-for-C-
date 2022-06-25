Console.Write("Введите число:\n");
int mod = int.Parse(Console.ReadLine());
if (mod < 0){
    Console.WriteLine($"Результат: {-mod}");
}
else if(mod > 0){
    Console.WriteLine($"Результат: {mod}");
}
return;