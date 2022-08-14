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
Method21(count: 4, msg: "TEXT");