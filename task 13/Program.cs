// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int ReadInt(string msg) //объявляем функцию readint и строковый параметр msg
{
    System.Console.Write(msg);
    string a = Console.ReadLine();
    int num = int.Parse(a);
    return num; //возврат из функции значения num
}
int num = ReadInt("Введите число ");
if (num>99)
{
    int thirddigit = num;
    while (thirddigit > 999)
    {
        thirddigit = thirddigit/10;
    }
    int result = thirddigit%10;
    System.Console.Write(+num+ " -> " +result);
}
else
{
    System.Console.WriteLine(+num+ " -> третьей цифры нет ");
}
