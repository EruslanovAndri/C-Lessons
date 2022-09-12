Console.Clear();

int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    var rnd = new Random();
    int index = 0;

    while (index < array.Length)
    {
        array[index] = rnd.Next(1, 10);
        index++;
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[ ");
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + " ]");
    }
}

void ReversArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
}

int[] array = CreateArrayRndInt(3);
PrintArray(array);
ReversArray(array);
Console.WriteLine();
PrintArray(array);


