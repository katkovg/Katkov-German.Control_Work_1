void ShowArray (string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int DetermineArraySize (string[] array, int size)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            size++;
        }
    }
    return size;
}

string[] FillArray (string[] array1, string[] array2)
{
    for(int i = 0, k = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)
        {
            array2[k] = array1[i];
            k++;
        }
    }
    return array2;
}

int size = 0;
Console.Write("Введите число элементов в массиве: ");
size = Convert.ToInt32(Console.ReadLine());
while(size < 1)
{
    Console.Write("Число элементов в массиве должно быть больше нуля. Введите число элементов в массиве ещё раз: ");
    size = Convert.ToInt32(Console.ReadLine());
}

string[] arrayWords = new string [size];

int count = 0;
string word;
while(count < size)
{
    Console.Write($"Введите {count}-й элемент массива: ");
    word = Convert.ToString(Console.ReadLine());
    while(word == "")
    {
        Console.Write("Введите именно слово или символ: ");
        word = Convert.ToString(Console.ReadLine());
    }
    arrayWords[count] = word;
    count++;
}