//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.
Console.WriteLine("введите первое число: ");
int firstnumber = int.Parse(Console.ReadLine());
Console.WriteLine("введите второе число: ");
int secondnumber = int.Parse(Console.ReadLine());
int ostatok = secondnumber%firstnumber;
if (secondnumber%firstnumber==0)
{
    Console.WriteLine("второе число кратно первому");
}
else
{
    Console.WriteLine($"не кратно, остаток от деления: {ostatok}");
}