// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int ReadInt(string msg) //объявляем функцию readint и строковый параметр msg
{
    System.Console.WriteLine(msg);
    string a = Console.ReadLine();
    int num = int.Parse(a);
    return num; //возврат из функции значения num
}
int num = ReadInt("Введите трехзначное число ");
if (num >99 && num <1000)
{
    int midl = (num%100-num%10)/10;
    System.Console.WriteLine(+num+ " -> " +midl);
}
else
{
    System.Console.WriteLine("Вы ввели не трехзначное число");
}