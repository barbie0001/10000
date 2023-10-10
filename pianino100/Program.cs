using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

Console.WriteLine("super puper pianino");
int[] k = new int[12] { 1635, 1732, 1835, 1945, 2060, 2183, 2312, 2450, 2596, 2705, 2914, 3087 };
int[] d = new int[12] { 1635, 1732, 1835, 1945, 2060, 2183, 2312, 2450, 2596, 2705, 2914, 3087 };
while (true) 
 {
    ConsoleKeyInfo key = Console.ReadKey();
    int q = 0;
    if (key.Key == ConsoleKey.Z)
    {
        q = 1;
    }
    if (key.Key == ConsoleKey.X)
    {
        q = 2;
    }
    if (key.Key == ConsoleKey.C)
    {
        q = 3;
    }
    if (key.Key == ConsoleKey.V)
    {
        q = 4;
    }
    if (key.Key == ConsoleKey.B)
    {
        q = 5;
    }
    if (key.Key == ConsoleKey.N)
    {
        q = 6;
    }
    if (key.Key == ConsoleKey.M)
    {
        q = 7;
    }
    if (key.Key == ConsoleKey.A)
    {
        q = 8;
    }
    if (key.Key == ConsoleKey.D)
    {
        q = 9;
    }
    if (key.Key == ConsoleKey.F)
    {
        q = 10;
    }
    if (key.Key == ConsoleKey.G)
    {
        q = 11;
    }
    if (key.Key == ConsoleKey.J)
    {
        q = 12;
    }
    if (key.Key == ConsoleKey.F1)
    {
        q = 13;
        Console.WriteLine('1');
    }
    if (key.Key == ConsoleKey.F2)
    {
        q = 14;
        Console.WriteLine('2');
    }
    octav(q);
    klav(d, q);
    if (key.Key == ConsoleKey.Escape)
    { break; }
}
static void octav(int q)
{
    int[] octave1 = new int[12] { 1635, 1732, 1835, 1945, 2060, 2183, 2312, 2450, 2596, 2705, 2914, 3087 };
    int[] octave2 = new int[12] { 2616, 2772, 2937, 3111, 3296, 3492, 3700, 3920, 4153, 4400, 4662, 4939 };



    if (q == 13)
    {
        int[] d = { 1635, 1732, 1835, 1945, 2060, 2183, 2312, 2450, 2596, 2705, 2914, 3087 };

    }
    if (q == 14)
    {
        int[] d = { 2616, 2772, 2937, 3111, 3296, 3492, 3700, 3920, 4153, 4400, 4662, 4939 };
    }


}
static void klav(int[] d,int q)
{
    if (q == 1)
    {
        Console.Beep(Convert.ToInt32(d[1]),400);
    }
    if (q == 2)
    {
        Console.Beep(Convert.ToInt32(d[5]), 400);
    }
    if (q == 3)
    {
        Console.Beep(Convert.ToInt32(d[3]), 400);
    }
    if (q == 4)
    {
        Console.Beep(Convert.ToInt32(d[4]), 400);
    }
    if (q == 5)
    {
        Console.Beep(Convert.ToInt32(d[5]), 400);
    }
    if (q == 6)
    {
        Console.Beep(Convert.ToInt32(d[7]), 400);
    }
    if (q == 7)
    {
        Console.Beep(Convert.ToInt32(d[6]), 400);
    }
    if (q == 8)
    {
        Console.Beep(Convert.ToInt32(d[2]), 400);
    }
    if (q == 9)
    {
        Console.Beep(Convert.ToInt32(d[9]), 400);
    }
    if (q == 10)
    {
        Console.Beep(Convert.ToInt32(d[8]), 400);
    }
    if (q == 11)
    {
        Console.Beep(Convert.ToInt32(d[11]), 400);
    }
    if (q == 12)
    {
        Console.Beep(Convert.ToInt32(d[12]), 400);
    }
}

