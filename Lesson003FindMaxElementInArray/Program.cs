Console.Clear();
int[] numbers = { 2, 5, 6, 12, 8, 999 }; // задаем массив из чисел типа int
int size = numbers.Length; // определяем длину массива 
int index = 0; // инициализируем счетчик под названием index
int max = numbers[index]; //присваиваем первому элементу под индесом 0 максимальное значение.

while (index < size)
{
    if (numbers[index] > max)
    {
        max = numbers[index];
    }
    index++;
}
Console.WriteLine(max);