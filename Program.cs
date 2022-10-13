// Задача 2: Напишите программу, которая на вход принимает
// два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Clear();
// Console.WriteLine("Task number 2");

// Console.WriteLine("Insert First Number");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Insert Second Number");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 > num2)
//     {
//         Console.WriteLine($"First number {num1} greater than second number {num2}");
//     }
// else if(num1 < num2)
//     {
//         Console.WriteLine($"Second nubmer {num2} greater then {num1} ");
//     }
// else
//     {
//         Console.WriteLine($"First number {num1} equal to Second number {num2}");
//     }

// Задача 4: Напишите программу, которая принимает
// на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.WriteLine("Task #8");

Console.WriteLine("Insert Number");
int num1 = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i < num1; i++)       
if (i%2==0)            
Console.Write($"{i},");
