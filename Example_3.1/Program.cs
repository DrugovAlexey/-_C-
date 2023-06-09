string[] week = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

Console.Write("Введите номер дня недели: ");
string weekday = Console.ReadLine();
int daynumber = Convert.ToInt32(weekday);
if (daynumber < 0 || daynumber > 6)
{
    Console.WriteLine("Нет такого дня недели!");

}
else
{
    Console.WriteLine(week[daynumber - 1]);
}
