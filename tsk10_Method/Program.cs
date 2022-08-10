int[] array = { 21, 62, 53, 18, 34, 45, 76, 97, 18, 89 };

int n = array.Length;
int find = 18;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    index++;
}