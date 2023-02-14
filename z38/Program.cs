double [] newarray()
{
    double max = 0;
    double [] array = {3.0, 7.1, 22.5, 2.7, 78.8};
    double min = array[0];
    for (int i = 0; i <array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    double res = max - min;
    Console.WriteLine(res);
    return array;
}


newarray();
