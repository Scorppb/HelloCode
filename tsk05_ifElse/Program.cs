System.Console.Write("Ввелите ваше имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
} 
else 
{
    System.Console.Write("Привет, ");
    System.Console.WriteLine(username);
}