// Say Hi to favourite User
Console.Write("Введите ваше имя ");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
   Console.WriteLine("Здорова Машоооок!!!");
}
else
{
    Console.WriteLine("Привет, " + username);
}