Console.Clear();

int[] array = { 1, 5, 100, 67, 1, 8, 9 };
int size = array.Length;
int index = 0;
int max_index = 0;
int max = array[max_index];

while (index < size)
{
    if (array[index] > max)
    {
        max_index = index;
        max = array[index];
    }
    index++;
    array[max_index] = array[size - 1];
    array[size - 1] = max;
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
PrintArray(array);