Console.Clear();
Console.Write("Enter the day of the week (1-7): ");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());

if (dayOfWeek == 6 || dayOfWeek == 7)
{
    Console.WriteLine("It's a day off!");
}
else if (dayOfWeek >= 1 && dayOfWeek <=5)
{
    Console.WriteLine("It's not a day off.");
}
else
{
    Console.WriteLine("There is no such day.");
}