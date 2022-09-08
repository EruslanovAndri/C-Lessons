Console.Clear();
int[] numbers = { 31, 5, 6, 6 };
int size = numbers.Length;
int index = 0;
int min = numbers[0];

while (index < size)
{
    if (numbers[index] < min)
    {
        min = numbers[index];

    }
    index++;
}
Console.WriteLine(min);