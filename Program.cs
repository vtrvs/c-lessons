//Добрый день, ознакомьтесь, пожалуйста, с моим домашним заданием!



//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input first number: ");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

if (num_1 > num_2) 
{
    Console.WriteLine($"The number {num_1} is bigger than the number {num_2}");
}
else if (num_1 < num_2) 
{
    Console.WriteLine($"The number {num_1} is smaller than the number {num_2}");
}
else
{
    Console.WriteLine($"The number {num_1} is equal to the number {num_2}");
}
*/



//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Input first number: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int second = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third number: ");
int third = Convert.ToInt32(Console.ReadLine());

if (first > second && first > third)
{
    Console.WriteLine($"{first} is bigger than {second} and {third}");
}

else if (second > first && second > third)
{
    Console.WriteLine($"{second} is bigger than {first} and {third}");
}

else if (first == second && first == third)
{
    Console.WriteLine($"All the numbers are equal");
}

else
{
    Console.WriteLine($"{third} is bigger than {first} and {second}");
}
*/



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input your number: ");
int yourN = Convert.ToInt32(Console.ReadLine());

if (yourN % 2 == 0)
{
    Console.WriteLine($"{yourN} is even number");
}
else 
{
    Console.WriteLine($"{yourN} is odd number");
}
*/



//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Input your number: ");
int ur_n = Convert.ToInt32(Console.ReadLine());
int start_n = 1;

while (start_n <= ur_n)
{
    if (start_n % 2 == 0) 
    {
        Console.Write(start_n + " ");
    }
start_n++;
}
*/