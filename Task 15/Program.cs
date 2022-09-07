// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Напишите цифру, обозначающую день недели");
int number = Convert.ToInt32 (Console.ReadLine());
void Day ( int arg1)
{
if (arg1 > 5 & arg1 < 8) Console.WriteLine("Этот день выходной");
else if (arg1 > 0 & arg1 < 6) Console.WriteLine("Это будний день");
else Console.WriteLine("Указаная цифра не соответствует дню недели");
}

Day(number);

