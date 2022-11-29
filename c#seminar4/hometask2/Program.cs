int readUserData (string text)
{
    Console.WriteLine (text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int SuumOfNumbers (int number)
{
    int sum =0;
    while (number>0)
    {
    sum = number%10 + sum;
    number= number/10;
    }
    return sum;
}
int number=readUserData ("введите число");
Console.WriteLine(SuumOfNumbers(number));