// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Напишите цифру, обозначающую день недели");
int number = Convert.ToInt32 (Console.ReadLine());
if (number > 5 & number < 8) Console.WriteLine("Этот день выходной");
else if (number > 0 & number < 6) Console.WriteLine("Это будний день");
else Console.WriteLine("Указаная цифра не соответствует дню недели");

