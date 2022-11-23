// Вид 1 -> ничего не принимают, ничего не возвращают.

void Method1()
{
    Console.WriteLine("Автор ..."); //например добавлять авторство где либо
}
Method1(); //   вызов метода, обязательно с круглыми скобками


// Вид 2 -> что-то принимают, ничего не возвращают.

//пример 1
void Method2(string msg) // в скобках какое-то кол-во аргументов
{
    Console.WriteLine(msg);
}
Method2("какой-то текст");

//пример 2
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method21("Текст", 4); // можем указать текст и сколько раз хотим увидеть текст
Method21( count: 3, msg: "text"); // можем явно указать текст и 
// сколько раз хотим увидеть текст, можно не попорядку записывать аргументы


// Вид 3 -> ничего не принимают, что-то возвращают.

int Method3() // обязатель указать тип, который принимает метод
{
    return DateTime.Now.Year; // обязательное использование оператора return
                              // это просто пример DateTime.Now.Year;
} 

int year = Method3(); // присваеваем результат работы метода переменной year
Console.WriteLine(year);


// Вид 4 -> что-то принимают, что-то возвращают. (Самая важная группа методов)

//пример 1 (цикл while)
string Method4(int count, string text)
{
    string result = String.Empty; //класть сюда конечный результат,
                                  // тоже самое что и string result = "";
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(7, "много текста, ");
Console.WriteLine(res);

//пример 2 (цикл for)
string Method41(int count, string text)
{
    int i = 0;
    string result = String.Empty; //класть сюда конечный результат,
                                  // тоже самое что и string result = "";
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res1 = Method41(5, "many text, ");
Console.WriteLine(res1);