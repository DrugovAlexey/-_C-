Console.WriteLine("Напишите целое положительное число: ");
string input_string1 = Console.ReadLine();
int number1 = Convert.ToInt32(input_string1);
int number2 = -number1;
while (number2 <= number1)
{
    Console.Write($"{number2} ");
    number2++;  // Увеличение на единицу, -- уменьшает на единицу, % деление на целое, += прибавляет определенное число
}