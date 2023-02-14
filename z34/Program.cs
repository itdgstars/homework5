int [] newarray()
{
    int [] array = new int[4];
    int sum = 0;
    for (int i=0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
        Console.Write($"{array[i]} ");
        if (array[i]%2 == 0)
        {
            sum++;
        }
        
    }
    Console.WriteLine();
    Console.WriteLine ("Количество четных чисел в массиве: " + sum);
    return array;
    
}

newarray();