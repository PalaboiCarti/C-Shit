using System;
public class WholeThing
{
    //part 1
    static void iterator(int num)
    {
         for (int i = 1; i <= num; i++)
         {
            for(int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine("");
        }
    }
    static void iteration()
    {
        Console.WriteLine("Please input an integer: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num <= 0)
        {
            Console.WriteLine("Integer must not be lower than 0");
            iteration();
        }else
        {
            iterator(num);
        }
    }
    //part 2
    static void thingDoer()
    {
        Console.WriteLine("Please input an integer: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num <= 0)
        {
            Console.WriteLine("Integer must not be lower than 0");
            thingDoer();
        }else
        {
            Console.Write("Formula: ");
            int sum = 0;
            for(int i=1; i<=num; i++)
            {
                Console.Write(i);
                if(i < num){
                    Console.Write("+");
                }
                sum = sum + i;
            }
            Console.WriteLine(" ");
            Console.WriteLine(sum);
        }
    }
    //part 3
    static void decrementStuff(int num)
    {
         for (int i = num; i >= 0; i--)
         {
            for(int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine("");
        }
    }
    static void decrementation()
    {
        Console.WriteLine("Please input an integer: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num <= 0)
        {
            Console.WriteLine("Integer must not be lower than 0");
            decrementation();
        }else
        {
            decrementStuff(num);
        }
    }
    //main
    public static void Main(string[] args)
    {
        Console.WriteLine("Part 2 - 1");
        iteration();
        Console.WriteLine("===============================");
        Console.WriteLine("Part 2 - 2");
        thingDoer();
        Console.WriteLine("===============================");
        Console.WriteLine("Part 2 - 3");
        decrementation();
    }
}
