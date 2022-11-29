int readUserData (string text)
{
    Console.WriteLine (text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
void NaturePow ()
{
    double firstNumber=readUserData("Введите число А:");
    double secondNumber=readUserData("ВВедите число b:");
    firstNumber = Math.Pow(firstNumber,secondNumber);
    Console.WriteLine(firstNumber);
}
NaturePow();