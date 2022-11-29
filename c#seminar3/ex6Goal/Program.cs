//У нас есть кеш - N $ , мы хотим сохранить его от инфляции, кладем в банк и получаем раз 
//в год M % , через сколько лет у нас получится купить квартиру за K $ , при том , что цена квартиры
//также растет на Q % если этот процент больше или равен N , то вывести в консоль безысходность 
Console.WriteLine("Сколько у Вас денг? ");
double cash = int.Parse(Console.ReadLine());
Console.WriteLine("Какова Доходность ваших инвестиций? ");
double profit = int.Parse(Console.ReadLine());
double years=0;
Console.WriteLine("Сколько стоитВаша цель?");
double goal = int.Parse(Console.ReadLine());
Console.WriteLine("Каков рост стоимости цели в % в год?");
double cost = int.Parse(Console.ReadLine());

if (cash<goal)
{
    if  (profit>cost)
    {
        while (cash<goal)
        {
        cash=cash + (cash/100 * profit);
        goal=goal + (goal/100 * cost);
        years++;
        }
        Console.WriteLine($"Вы накопите на цель за {years} лет");
    }
    else
    {
        Console.WriteLine ("печалька");
    }
} 
else 
{
    Console.WriteLine("Идите и приобретите");
}