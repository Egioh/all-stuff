int factorialFromN ( int number)
{
    int factorial =number;
    for (int i=number; i>1; i--)
    {
        factorial = factorial*(i-1);
    }
return factorial;
}

Console.WriteLine(factorialFromN(9));
