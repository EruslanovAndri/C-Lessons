Console.Clear();
int[] array = {1,3,63,7,3,1,4};
int FindMaxInArray(int[] array)
{
    int size = array.Length;
    int index = 0;
    int max = array[0];
    while(index < array.Length)
    {
        if(array[index] > max)
        {
            max = array[index];
        }
        index++;
    }
    return max;
}

int res = FindMaxInArray(array);
Console.WriteLine(res);