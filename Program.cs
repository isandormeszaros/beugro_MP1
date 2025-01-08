using System;

public class Program
{
    public static void Main(string[] args)
    {
        //ELJARAS MEGHIVASA
        Console.WriteLine("Adj meg egy számot: ");
        int inputNum = Convert.ToInt32(Console.ReadLine());
        pozitivE(inputNum);

        //FUGGVENY MEGHIVASA
        Console.WriteLine("A legkisebb szám: " + smallestNum());
        smallestNum();
    }

    //ELJARAS 
    static void pozitivE(int inputNum)
    {
        if (inputNum > 0)
        {
            Console.WriteLine("A szám pozitív.");
        }
        else if (inputNum < 0)
        {
            Console.WriteLine("A szám negatív.");
        }
        else Console.WriteLine("A szám nulla.");
    }

    //FUGGVENY
    static int smallestNum()
    {
        int smallest = int.MaxValue;
        List<int> numbers = new List<int> { 5, 6, 7, 4, 8, 9, 10 };

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] < smallest)
                smallest = numbers[i];
        }
        return smallest;
    }
}