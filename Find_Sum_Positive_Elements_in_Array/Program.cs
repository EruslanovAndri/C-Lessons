Console.Clear();

int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    var rnd = new Random();
    int index = 0;

    while (index < array.Length)
    {
        array[index] = rnd.Next(-50, 50);
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

int FindSumPozitiveElement(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count = count + array[i];
        }
    }
    return count;
}


int[] array = CreateArrayRndInt(4);
PrintArray(array);
int res = FindSumPozitiveElement(array);
Console.WriteLine();
Console.WriteLine($"Sum of pozitive elements is = {res}");



