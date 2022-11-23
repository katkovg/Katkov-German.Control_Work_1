void ShowArray (string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
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