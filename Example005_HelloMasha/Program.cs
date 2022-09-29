Console.WriteLine ("Введите ваше имя");
string username = Console.ReadLine ();
if (username.ToLower()=="вася")
{
    Console.WriteLine ("Славабогутыпришел");
}

else
{
    Console.Write ("Снова ты,");
    Console.WriteLine (username);
}
