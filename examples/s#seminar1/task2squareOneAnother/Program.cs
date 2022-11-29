Console.Write("Введите первое число: ");
int firstnumber = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondnumber = int.Parse(Console.ReadLine());

if (firstnumber == secondnumber*secondnumber)
{
    Console.WriteLine ("первое число квадрат второго");
}
else
{
    Console.WriteLine("не квадрат");
}