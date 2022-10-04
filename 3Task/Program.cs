/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */
Console.WriteLine ("Введите число");
string Number = Console.ReadLine();
int Num = int.Parse(Number);
if (Num%2 == 0)
    Console.WriteLine ("четное");
else
    Console.WriteLine ("нечетное");