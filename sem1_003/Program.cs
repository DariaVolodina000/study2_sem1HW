// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("Давайте проверим число на четность!");
Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());

int num =a%2;
if (num == 0) Console.WriteLine("Да");
else Console.WriteLine("Нет");

