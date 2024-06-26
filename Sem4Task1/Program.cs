﻿int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
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

int DetectOriginDigit(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++) 
    {
        if (IsOriginDigit(array[i]))
        {
            count++;
        }
    }

    return count;
}

bool IsOriginDigit(int num)
{
    for(int i = 2; i <= Math.Sqrt(num); i++) 
    {
        if (num % i == 0) 
        {
            return false;
        }
    }
    return true;
        
}


int [] arr = CreateArrayRndInt(10, 1, 100);
PrintArray(arr);

int countOrigin = DetectOriginDigit(arr);
Console.Write($"  => {countOrigin}");
