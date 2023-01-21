using System;

class Variables{
    static void Main(string[] args){

        int n = 4;
        Console.WriteLine("Value of n is {0}",n);
        Console.WriteLine($"Value of n is {n}");

        Console.WriteLine($"Sum of 2 and 3 is {2+3}");

        int a = 4;
        float b = 2.2f;
        double c = 2.54;
        char d = 'a';
        bool e = true;
        uint f = 43;
        short g = 2;
        ushort h = 19;
        long i = 123;
        ulong j = 34;

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(e);
        Console.WriteLine(f);
        Console.WriteLine(g);
        Console.WriteLine(h);
        Console.WriteLine(i);
        Console.WriteLine(j);


        Console.WriteLine(int.MinValue);
        Console.WriteLine(int.MaxValue);

        Console.WriteLine(); // to print new line

        Console.WriteLine(float.MinValue);
        Console.WriteLine(float.MaxValue);

        Console.WriteLine(); // to print new line

        Console.WriteLine(double.MinValue);
        Console.WriteLine(double.MaxValue);

        Console.WriteLine(); // to print new line

        Console.WriteLine(uint.MinValue);
        Console.WriteLine(uint.MaxValue);

        Console.WriteLine(); // to print new line

        Console.WriteLine(short.MinValue);
        Console.WriteLine(short.MaxValue);

        Console.WriteLine(); // to print new line

        Console.WriteLine(ushort.MinValue);
        Console.WriteLine(ushort.MaxValue);

        Console.WriteLine(); // to print new line

        Console.WriteLine(long.MinValue);
        Console.WriteLine(long.MaxValue);

        Console.WriteLine(); // to print new line

        Console.WriteLine(ulong.MinValue);
        Console.WriteLine(ulong.MaxValue);
    }
}