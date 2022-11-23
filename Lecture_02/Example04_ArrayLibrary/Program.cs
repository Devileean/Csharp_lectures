void FillArray(int[] collection) //название нашего метода массива
{
    int lenght = collection.Length; // получить длинну массива
    int index = 0; //0 по умолчанию
    while (index < lenght) // будем чтото делать
    {
        collection[index] = new Random().Next(1, 10); // кладем случайные числа
        // index = index + 1;
        index++;
    }
}
void PrintArray(int[] col) // метод для распечатки информации
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOff(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOff(array, 4);
Console.WriteLine(pos);