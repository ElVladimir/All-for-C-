void Holydays(int dig)
{
    string message = "не вых";
    if (dig ==7 || dig == 6) message = "вых";
    Console.WriteLine ($"{dig} - {message}");

}
Holydays(6);
Holydays(7);
Holydays(1);