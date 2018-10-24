using System;
public class Test
{

    public static void Main(String[] args)
    {

        int[] array1 = { 10, 56, 22, 50, 10000, 63, 15,9999999 };
        int highest = 0;
        for(int i = 0; i<array1.Length; i++)
        {
            int num = array1[i];
            if (num > highest)
            {
                highest = num;
            }
        }
        Console.WriteLine(highest);


    }
}
