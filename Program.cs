// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine ("Введите цифру от 1 до 7: ");
int day = int.Parse(Console.ReadLine());

string s = "не день недели";
if (day == 1)
{
    s = "нет";
}
else if (day == 2)
{
    s = "нет";
}
else if (day == 3)
{
    s = "нет";
}
else if (day == 4)
{
    s = "нет";
}
else if (day == 5)
{
    s = "нет";
}
else if (day == 6)
{
    s = "да";
}
else if (day == 7)
{
    s = "да";
}
Console.WriteLine(s);