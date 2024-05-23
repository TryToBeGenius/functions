int[] array = { 1, 2, 3, 4, 5};


void PrintArray()
{
    
    int tempArr = 0;
    
    for (int i = 0; i < array.Length/2; i++)
    {   tempArr = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = tempArr;
           
        
    }
    Console.Write("[");
    for(int j = 0; j < array.Length-1; j++)
        {
            Console.Write(array[j] + ",");
        }
    Console.Write(array[array.Length-1]);
    Console.Write("]");
}

PrintArray();

