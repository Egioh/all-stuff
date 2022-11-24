Console.WriteLine("Веддите вес арбуза: ");
int weith = int.Parse(Console.ReadLine());
int j = weith;
int i= 0;
if (weith%2 == 0)
{
    while (i<weith)
    {
        if (i+j==weith && i%2==0 && j%2==0 && i!=0)
        Console.WriteLine($"доли: {i} и {j}");
        i++;
        j--;

    }
    //i++;
    //j--;
}
else 
{
    Console.WriteLine("к сожалению на четные доли этот арбуз не поделить");
}