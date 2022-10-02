//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число");
int Num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int Num2 = int.Parse(Console.ReadLine()!);
if (Num1 == Num2)
{
    Console.WriteLine("Введенне числа равны");
}
else
{
    if (Num1 > Num2)
    {
        Console.WriteLine($"{Num1} больше чем {Num2}");
    }
    else
    {
        Console.WriteLine($"{Num2} больше чем {Num1}");
    }
}


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число");
int Number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int Number2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число");
int Number3 = int.Parse(Console.ReadLine()!);
int maxNumber = Number1;
if (Number2 > maxNumber)
{
    maxNumber = Number2;
}
if (Number3 > maxNumber)
{
    maxNumber = Number3;
}
Console.WriteLine($"Максимальное число: {maxNumber}");


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
int Num = int.Parse(Console.ReadLine()!);
if (Num % 2 == 0)
{
    Console.WriteLine($"Число {Num} чётное");
}
else
{
        Console.WriteLine($"Число {Num} нечётное");
}


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
int i = 1;
while (i <= N)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
    }
i++;
}