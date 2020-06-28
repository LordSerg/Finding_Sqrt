using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finding_Sqrt
{
    class Program
    {
        static void Main(string[] args)
        {
            long a=8;
            int q=3;
            long k =5;
            Console.WriteLine("Введите целое число, из которого будете извлекать корень: ");
            a=Convert.ToInt64(Console.ReadLine());
            long aa=a;
            Console.WriteLine("Введите степень извлекаемого корня из {0}: ", a);
            q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество знаков после запятой:");
            k = Convert.ToInt64(Console.ReadLine());
            long []d;
            long w =1;
            if(a<0)
            {
                if (q % 2 == 1)
                    a = -a;
                else
                    Console.WriteLine("Низя так");
            }
            for (int i = 0; i < q; i++)
                w *= 10;
            int j = 0;
            d = new long[100];
            do
            {
                d[j] = a % (w);
                a =(a-(a%w))/w;
                j++;
            }
            while (a>0);
            Console.Write("{0}-й корень из {1} = ",q,aa);
            long zz =1;
            long answer =0;
            for (int z=9; z>=0;z--)
            {
                zz = z;
                for (int l = 0; l < q-1; l++)
                    zz *= z;
                if (d[j - 1] - zz >= 0)
                {
                    Console.Write(z);
                    answer = z;
                    break;
                }
            }
            zz = d[j - 1] - zz;
            bool b = true;
            for (int i = j - 2; i >= 0 || k > 0; i--)
            {
                zz *= w;
                if (i >= 0)
                {
                    zz += d[i];
                }
                else if (b == true)
                {
                    k--;
                    Console.Write(".");
                    b = false;
                }
                else
                    k--;
                for (int x = 9; x >= 0; x--)
                {
                    if (zz-(x * ((answer*20)+x))>=0)
                    {
                        zz = zz - (x * ((answer * 20) + x));
                        Console.Write(x);
                        answer = answer * 10 + x;
                        break;
                    }
                }
            }
            float THEanswer = answer;
            for (int i = j; i > 0; i--)
                THEanswer /= 10;

            //Console.WriteLine("\nAnswer = " + Math.Pow(a, 0.3333));
            Console.ReadKey();
        }
    }
}
