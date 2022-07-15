int[] array = new int[20];
fillArrayWithRandomNumbers(array);
printArray(array);
Console.WriteLine("Max element is " + findMax(array));


void fillArrayWithRandomNumbers(int[] array)
{
    int i = 0;
    while (i < array.Length)
    {
        array[i] = new Random().Next(0, 100);
        i++;
    }
}

void printArray(int[] array)
{
    int i = 0;
    while (i < array.Length)
    {
        Console.Write(array[i] + " ");
        i++;
    }
    Console.WriteLine();
}

int findMax(int[] array)
{
    int i = 1;
    int max = array[0];
    while (i < array.Length)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        i++;
    }
    return max;
}