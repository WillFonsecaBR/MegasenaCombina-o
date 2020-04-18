using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megasena___Combinação
{
    class Program
    {
        // n!/((n-p)! p!)
        
        static void Main(string[] args)
        {
            int[] Números = { 7, 12, 25, 32, 45, 47, 52, 59 };

            Console.WriteLine("Números para Combinação: {0}", Números.Length);
            Console.Write("\n==> ");

            foreach (int x in Números)
            {
                Console.Write("{0,4} ", x);
            }

            Console.WriteLine("\n-------------------------------------------");

            Combina(1, 2, 3, 4, 5, 6, 1, 1, Números);

            Console.ReadKey();
        }
        static void Combina(int a, int b, int c, int d, int e, int f, int Cont, int ContTotal, int[] Números)
        {
            if (f > Números.Length)
            {
                f = e + 1;

                e++;

                if (e > Números.Length-1)
                {
                    e = d + 1;

                    d++;

                    if (d > Números.Length-2)
                    {
                        d = c + 1;

                        c++;

                        if (c > Números.Length-3)
                        {
                            c = b + 1;

                            b++;

                            if (b > Números.Length-4)
                            {
                                b = a + 1;

                                a++;

                                if (a == Números.Length-4) 
                                    return;
                            }
                        }
                    }
                }
            }
            if (a < b && b < c && c < d && d < e && e < f)
            {
                Console.WriteLine("\n  Jogo {0,2} - {1,4} {2,4} {3,4} {4,4} {5,4} {6,4}", Cont, Números[a-1], Números[b-1], Números[c-1], Números[d-1], Números[e-1], Números[f-1]);
                Cont++;
            }
            ContTotal++;
            Combina(a, b, c, d, e, f + 1, Cont, ContTotal, Números);
        }
    }
}
