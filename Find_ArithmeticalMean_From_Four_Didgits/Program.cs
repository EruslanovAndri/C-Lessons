Console.Clear();
int[] array = { 13, 11, 1, 6 };
int size = array.Length;
int index = 0;
double average = 0;

while (index < size)
{
    average = average + array[index];
    index = index + 1;
}
Console.WriteLine($"The arethmetical mean is = {average / index}");

// Work