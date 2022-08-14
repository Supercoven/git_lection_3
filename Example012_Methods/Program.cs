//Вид 1
void Method1()
{
    System.Console.WriteLine("Автор ...");
}
//Method1();

//Вид 2

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");

//Вид2.1

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}

// Method21(msg: "Текст сообщения", count: 4);
// Method21(count: 4, msg: "TEXT");

// 3 группа методов

int Method3()
{
    return DateTime.Now.Year;
}

//int year = Method3();
//Console.WriteLine(year);

// Вид 4

//string Method4(int count, string text)
//{
//      int i = 0;
//    string result = String.Empty;
//
//    while (i < count)
//    {
//        result = result + text;
//        i++;
//    }
//    return result;
//}
//string res = Method4(10, "asdf");
//Console.WriteLine(res);

// Цикл for

string Method4(int count, string text)
{
     string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;       
    }
    return result;
}
string res = Method4(10, "asdf");
//Console.WriteLine(res);

//Вывод таблицы умножения на экран
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++) //тело метода
    {
        Console.WriteLine($"{i} x {j} = {i*j}"); 
    }
    Console.WriteLine();
}
