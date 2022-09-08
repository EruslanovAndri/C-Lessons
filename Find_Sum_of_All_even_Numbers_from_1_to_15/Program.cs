
Console.Clear();
int didgit = 2;
int sum = 0;

while(didgit <= 15)
{
    if(didgit % 2  == 0)
    sum += didgit;
    didgit = didgit + 1;
}
Console.WriteLine(sum);
// WORK