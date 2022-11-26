int readUserData (string text)
{
    Console.WriteLine (text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
void suumForN (int number)
{
    int summ =0;
    for (int i=0; i<=number; i++)
    {
        summ = summ+i;
    }
    Console.WriteLine($"сумма чисел от 1 до {number} = {summ}");
}
int a = readUserData("введите число");
suumForN (a);
