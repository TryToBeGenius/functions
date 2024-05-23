
int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(100, 999);
    }
    return array;
}

int CountArrayDel2(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
    
}
void PrintArray(int[] array)
{
    Console.Write("[");
   for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write(array[i]);
        }

    }
    Console.Write("]");
}

Console.WriteLine("Введите размер массива");

int input = Convert.ToInt32(Console.ReadLine());
int [] array = CreateArrayRndInt(input);
PrintArray(array);
int output = CountArrayDel2(array);
Console.WriteLine($"Четных чисел => {output}");