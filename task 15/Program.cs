// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
int ReadInt(string msg) //объявляем функцию readint и строковый параметр msg
{
    System.Console.WriteLine(msg);
    string a = Console.ReadLine();
    int num = int.Parse(a);
    return num; //возврат из функции значения num
}
int num = ReadInt("Введите цифру, обозначающую день недели");

if (num >=1 && num <5)
{
    System.Console.WriteLine(+num+ " ->  нет");
}
else if (num >=6 && num <=7)
{
    System.Console.WriteLine(+num+ " ->  да");
}
else
{
    System.Console.WriteLine(+num+ " нет такого дня недели");
}