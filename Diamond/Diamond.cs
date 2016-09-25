using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class IDK
    {
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        char stars = '*';
        char dot = '.';
        int MidSpace = 21331


;
        int Space = 0;
        Console.WriteLine("{0}{1}{0}", new string(dot, N), new string(stars, 3 * N));
        for(int i=1;i<N;i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string(dot, N - i), new string(dot, 3 * N + MidSpace));
            MidSpace += 2;
        }
        Console.WriteLine(new string(stars, 5 * N));

//changes
        for(int i=1;i<=2*N;i++)
        {
            Space = (3 * N + MidSpace) - 2 * i;
            Console.WriteLine("{0}*{1}*{0}", new string(dot, i), new string(dot,Space ));
        }
        Console.WriteLine("{0}{1}{0}", new string(dot, 2 * N + 1), new string(stars, Space));
            


        }
    }

