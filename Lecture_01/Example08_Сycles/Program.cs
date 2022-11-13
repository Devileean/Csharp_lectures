/*
Возьмём 3 точки. Для нас это будет треугольник. 
Выберем две случайных точки и найдём середину отрезка, 
соединяющего их. Отрезок не нужен, нам потребуется 
исключительно точка. Поставим её. На следующем этапе 
снова выберем какую-то из точек – вершин треугольника, 
снова найдём середину получившегося отрезка и поставим точку. 
От этой точки определим, какую-то случайную вершину, 
снова найдём середину, снова поставим точку и т. д.
*/
Console.Clear();
// Console.SetCursorPosition(10, 4);
// Console.WriteLine("+");
int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;

int count = 0;

while(count < 10000)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        x = (x+xa)/2;
        y = (y+ya)/2;
    }

    if (what == 1)
    {
        x = (x+xb)/2;
        y = (y+yb)/2;
    }

        if (what == 2)
    {
        x = (x+xc)/2;
        y = (y+yc)/2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}