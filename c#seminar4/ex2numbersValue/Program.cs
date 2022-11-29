int readUserData (string text)
{
    Console.WriteLine (text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
void quantitiOfNumbers (int number)
{
    int quantiti=0;
    while (number > 0)
    {
        number = number/10;
        quantiti++;
    }
    Console.WriteLine($"количество цифр в числе = {quantiti}");
}
int userData= readUserData("введите число");
quantitiOfNumbers(userData);