Console.Clear();
Console.WriteLine("Fill your name:");
string user_name = Console.ReadLine();

if(user_name.ToLower() == "masha")
{
    Console.WriteLine($"Great! It's Masha");
}
else
{
    Console.WriteLine($"Hello, {user_name}");
}