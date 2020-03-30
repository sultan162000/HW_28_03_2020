using System;

namespace HW_28_03
{
    class Program
    {
        static void Main(string[] args)
        {
                //////////////Задание 2
                int a = 1, b = 6;
                int sum = 0;
                for(int i = ++a;i<b;sum+=i++);
                System.Console.WriteLine($"Сумма всех чисел: {sum}");

                for(int i = ++a; i<b; i++){
                    if(i%2!=0)Console.Write($"{i} ");
                }
                System.Console.WriteLine();
                /////////////////Задание 3
                
                for (int i = 0; i <= 5; i++)
                {
                    System.Console.Write("*");
                    for (int x = 0; x <= 8; x++)
                    {
                        System.Console.Write("*");
                        
                    }
                    System.Console.Write("*");
                    System.Console.WriteLine();
                }
                System.Console.WriteLine();


                for (int i = 0; i < 10; i++)
                {
                    for (int x = 0; x <= i; x++)
                    {
                        System.Console.Write("*");
                    }
                    System.Console.WriteLine();
                }
                System.Console.WriteLine();


                int k = 0, o = 10;
            for (int i = o; i >= 0; i--)
            {
                k++;
                for (int x = o; x >= 0; x--)
                {
                    Console.Write(" ");
                }
                o--;
                for (int y = 0; y < k; y++)
                {
                    Console.Write("* ");
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine();

            int N=13;
            int cent = N/2;
            for (int i = 0; i < N; i++)
            {
                for(int j = 0; j<N; j++){
                    if(i<=cent){
                        if(j>=cent-i&&j <= cent +i)System.Console.Write("*");
                        else System.Console.Write(" ");
                    }else{
                        if(j >= cent + i - N + 1 && j <= cent - i + N - 1)System.Console.Write("*");
                        else System.Console.Write(" ");
                    }
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine();



            double v = 1000, p = 3.5, k1 = 0;
            
            for (v = 1000; v <= 1100;)
            {
                k1++;
                v += (v*p)/100;
                
            }
            System.Console.WriteLine(v);
            System.Console.WriteLine(k1);

                Console.ReadKey();
        }
    }
}
