Console.Clear();
int[] array = {1,3,4,7,8};
int size = array.Length;
int index = 0;
int result = 0;

while( index < size)
{
    result = result + array[index];
    index = index + 1;
}
Console.WriteLine(result);

// WORK