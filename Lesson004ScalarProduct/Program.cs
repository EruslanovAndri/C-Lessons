

Console.Clear();

int[] firstVector = { 1, 8, 7 };
int[] secondVector = { 4, 9, 5 };
int size = firstVector.Length;
int scalarProduct = 0;
int index = 0;


while (index < size)
{
    scalarProduct = scalarProduct + firstVector[index] * secondVector[index];
    index++;
}

Console.WriteLine(scalarProduct);