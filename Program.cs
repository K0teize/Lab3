using System;

public class Program
{
    static void Main()
    {
        int count = 0; int countch = 0;
        int n = int.Parse(Console.ReadLine());
        int minc = n + 1; int makc = 0, sled=0,max=0,posl2=0;
        for (int i = 0; i < n; i++)
        {
            int posl = int.Parse(Console.ReadLine());
            //подпоследовательность из 1
            if (posl == 1)
            {
                count++;

            }
            else
            {
                if (count > 0)
                {
                    minc = Math.Min(count, minc);
                    count = 0;
                }
            }
            //Макс сумма четных
            if (posl % 2 == 0)
            {
                countch += posl;
                makc = Math.Max(makc, countch);
            }
            else
            {
                countch = 0;
            } 
            //Макс размер из одинаковых четных
            if(posl%2==0 && posl != sled)
            {
                sled = posl;
                max = Math.Max(max, posl2);
                posl2 = 0;
            }
            if (posl%2==0 && posl == sled)
            {
                posl2++;
            }
            if (posl % 2 != 0)
            {
                max = Math.Max(max, posl2);
                posl2 = 0;
            }
            
        }
        Console.WriteLine("Минимальный размер подпоследовательности из 1: " + minc);
        Console.WriteLine("Максимальная сумма подпоследовательности четных элементов: " + makc);
        Console.WriteLine("Максимальный размер подпоследовательности, состоящей из одинаковых четных элементов: "+max);
    }
}


