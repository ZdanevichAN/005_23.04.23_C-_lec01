// программа ввести имя,если имя==Alex, поприветсвовать/иначе послать
string userName = "Alex";
Console.WriteLine("Введите имя пользователя: ");
string input_userName = Console.ReadLine();
if (input_userName==userName)
{
    Console.Write("Ура! Это же Саня!");
}
else
{
    Console.Write("Вы кто такие? Я Вас не звал...");
}