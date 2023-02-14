int [] newarray()
{
    int [] array = new int[4];
    int sum = 0;
    for (int i=0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,100);
        Console.Write($"{array[i]} ");
        if(i % 2 != 0)
        {
           sum = sum + array[i]; 
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма элеменетов с нечетными индексами: {sum}");
    return array;
}    

newarray ();
