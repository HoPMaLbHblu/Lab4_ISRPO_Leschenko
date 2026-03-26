System.Console.WriteLine("Приветствую");

System.Console.WriteLine("Лещенко Даниил");
System.Console.WriteLine("ИСП-233");
System.Console.WriteLine(DateTime.Now);
System.Console.WriteLine("1 — Показать ФИО");
System.Console.WriteLine("2 — Показать группу");
System.Console.WriteLine("3 — Показать дату");
System.Console.WriteLine("4 — Выход");

string? choice = Console.ReadLine();

if (choice == "1")
{
    System.Console.WriteLine("Лещенко Даниил");
}
else if (choice == "2")
{
    System.Console.WriteLine("ИСП-233");
}
else if (choice == "3")
{
    System.Console.WriteLine(DateTime.Now);
}
else if (choice == "4")
{
    return;
}
else
{
    System.Console.WriteLine("Цифру от 1 до 4!");
}
