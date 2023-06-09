//Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 

Console.WriteLine("Напишите первое число");
string input_string1 = Console.ReadLine();
Console.WriteLine("Напишите второе число");
string input_string2 = Console.ReadLine();
int number1 = Convert.ToInt32(input_string1);
int number2 = Convert.ToInt32(input_string2);
if (number2 == number1 * number1)
{
    Console.WriteLine($"Число {number2} является квадратом {number1}");
}
else
{
    Console.WriteLine($"Число {number2} не является квадратом {number1}");
}