Console.Clear();

// Поиск второго максимального элемента массива.
int[] numbers = {3,6,8,2,1,7};
int size = numbers.Length;
int firstMax = numbers[0];
int secondMax = numbers[0];
int currentIndex = 2;

if (numbers[1] > firstMax)
{
    firstMax = numbers[1];
}
else
{
    secondMax = numbers[1];
}

while (currentIndex < size)
{
    if (numbers[currentIndex] > firstMax)
    {
        secondMax = firstMax;
        firstMax = numbers[currentIndex];
    }
    else
    {
        if (numbers[currentIndex] > secondMax)
        {
            secondMax = numbers[currentIndex];
        }    
    }
    currentIndex++;
}
Console.WriteLine($"Second max element = {secondMax}");

// Work 

