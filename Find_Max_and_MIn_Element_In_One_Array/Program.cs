Console.Clear();

int[] array = { 2, 4, 6, 23, 7, 8, 9};
int size = array.Length;
int i = 0;
int max = array[i];
int min = array[i];


while (i < size)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    else
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    i = i + 1;
}

Console.WriteLine($" Max = {max}");
Console.WriteLine($" Min = {min}");


// Work