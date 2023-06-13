Console.Clear();
Console.WriteLine("Enter a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 100 && num < 1000)
{
    int num2 = num / 10 % 10;
    Console.WriteLine(num2);
}
else
{
    Console.WriteLine("You did not enter a three-digit number");
}