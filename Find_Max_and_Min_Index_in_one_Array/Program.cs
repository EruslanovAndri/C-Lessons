Console.Clear();
//     index  [0, 1, 2, 3, 4,]
int[] array = {2299,11,99,4, 2};
int size = array.Length;
int i = 0;
int maxElemIndex = array[i];
int minElemIndex = array[i];
int maxIndex = 0;
int minIndex = 0;

while (i < size)
{
    if (array[i] > maxElemIndex)
    {
        
        maxElemIndex = array[i]; 
        maxIndex = i;    
    }
    else
    {
        if (array[i] < minElemIndex)
        {
            minElemIndex = array[i]; 
            minIndex = i;      
        }
    }
    i++;
}
Console.WriteLine($"Max index is = {maxIndex}");
Console.WriteLine($"Min index is = {minIndex}");
Console.WriteLine($"Max elememt is = {maxElemIndex}");
Console.WriteLine($"Min element is = {minElemIndex}");


