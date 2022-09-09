Console.Clear();

int n = 10;
int factorial = 1;
int size = 0;

while (size < 10)
{
    if (n != 0)
    {
        factorial = factorial * n;
        n = n - 1;
    }
    size = size + 1;
}
Console.WriteLine(factorial);
