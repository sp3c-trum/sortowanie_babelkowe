using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj rozmiar tablicy: ");
        string input = Console.ReadLine();
        int size = 1;
        try
        {
            size = int.Parse(input);
        }
        catch (FormatException)
        {
            Console.WriteLine("Zły wybór.");
        }
        int[] array = new int[size];
        WypelnijTablice(array);
        Console.WriteLine("\nTablica przed posortowaniem:");
        PrintArray(array);
        Sortuj(array);

        Console.WriteLine("\nTablica po posortowaniu:");
        PrintArray(array);
    }

    static void WypelnijTablice(int[] array)
    {
        Random randNum = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = randNum.Next(1, 100);
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static void Sortuj(int[] array)
    {
        bool swapped;
        for (int i = 0; i < array.Length - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    Zamien(ref array[j], ref array[j + 1]);
                    swapped = true;
                }
            }
            if (!swapped)
            {
                break;
            }
        }
    }

    static void Zamien(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
}
