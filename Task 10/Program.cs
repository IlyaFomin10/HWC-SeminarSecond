// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32 (Console.ReadLine());
int SecondNumber (int numb)
{
    int arg1 = numb / 10;
    int arg2 = arg1 % 10;
    return arg2;
}
int result = SecondNumber (number);
Console.WriteLine($"Вторая цифра числа: {result}");
