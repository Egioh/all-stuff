Console.WriteLine ("Введите ваше имя: ");
string username = Console.ReadLine ();

if (username.ToLower() == "паша")
{
    Console.WriteLine ("Приветствую владыка!");
}
else
{
    Console.Write ("Как смеешь ты, ");
    Console.Write (username);
    Console.Write (" трогать этот ноутбук");
}