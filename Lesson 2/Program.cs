int [] array = { 1, 12 , 35, 85, 4, 83, 16, 81};
int n = array.Length;
int find = 4;
int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}