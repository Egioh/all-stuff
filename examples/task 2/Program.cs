Console.WriteLine("введите число: ");
int number = int.Parse(Console.ReadLine());

if (number%7 == 0 && number% 23 == 0)
{
    Console.Write("число кратно 7 и 23");
}
else 
{
    Console.Write("не кратно");
}