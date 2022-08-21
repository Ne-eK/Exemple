Console.WriteLine("Введите имя пользователя");
string UserName = Console.ReadLine();

if (UserName.ToLower() == "маша")
{
    Console.WriteLine("Ура, этоже Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(UserName);
}
