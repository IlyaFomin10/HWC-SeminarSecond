// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число:");
int number = Convert.ToInt32 (Console.ReadLine());
int numberM = Math.Abs(number);

int Search3 (int arg1)
{
    if (arg1 < 1000 & arg1 > 100) arg1 = arg1 % 10;
    else if (arg1 > 1000) 
    { 
        while (arg1 > 1000) 
        {
            arg1 = arg1 / 10;
        }    
        arg1 = arg1 % 10;
    }
    return arg1;    
}

if (numberM < 100) Console.WriteLine("Третьего числа нет");
else
{   number = Search3 (numberM);
    Console.WriteLine($"Третья цифра числа: {number}");
}


