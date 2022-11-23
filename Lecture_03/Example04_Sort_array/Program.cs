// функция с циклом сортировки чисел

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 5, 9}; //некий массив чисел, могут повторятся

void PrintArray(int[] array) // метод вывовда массива
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array) // метод который будет упорядочивать наш массив
{
    for (int i = 0; i < array.Length ; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length - 1; j++) //ищет максимальную цифру
        {
            if (array[j] < array[minPosition]) 
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);