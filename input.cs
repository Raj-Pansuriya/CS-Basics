using System;

class Input{
    static void Main(string[] args){
        string sentence;
        int a;
        Console.WriteLine("Enter a multiple word input");
        sentence = Console.ReadLine();

        Console.WriteLine("Enter a single character input");
        a=Console.Read();

        Console.WriteLine("\n\n{0}",sentence);
        Console.WriteLine(a);
    }
}