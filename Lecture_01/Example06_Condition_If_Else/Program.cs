Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же " + username);
}
else
{
    Console.Write("привет " + username);
  //  Console.WriteLine(username);
}
