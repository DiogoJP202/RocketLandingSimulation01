using System;

class Program
{
    static void Main(string[] args)
    {
        Thread.Sleep(500);
        Console.WriteLine("/ \\");
        Thread.Sleep(500);
        Console.Clear();
        Console.WriteLine("|_|\n/ \\");
        Thread.Sleep(500);
        Console.Clear();
        Console.WriteLine("| |\n|_|\n/ \\");
        Thread.Sleep(500);
        Console.Clear();
        Console.WriteLine("| |\n| |\n|_|\n/ \\");
        Thread.Sleep(500);
        Console.Clear();
        Console.WriteLine("/ \\\n| |\n| |\n|_|\n/ \\");
        Thread.Sleep(500);
        Console.Clear();
        Console.WriteLine(" | \n/ \\\n| |\n| |\n|_|\n/ \\");
        Thread.Sleep(500);
        Console.Clear();
        Console.WriteLine("\n | \n/ \\\n| |\n| |\n|_|\n/ \\");
        Thread.Sleep(100);
        Console.Clear();
        Console.WriteLine("\n\n | \n/ \\\n| |\n| |\n|_|\n/ \\\n***\n");

        Console.WriteLine("*** The rocket has landed. Woohoo! Another successful landing! :3 ***");
        Thread.Sleep(5000);
        Console.Clear();

        string rocket = "    \n     | \n    / \\\n    | |\n    | |\n    |_|\n    / \\";

        for (int i = 10; i >= 0; i--)
        {
            Console.Clear();
            Console.WriteLine(rocket);
            rocket = "\n" + rocket;
            Thread.Sleep(500);
        }
        Console.WriteLine("    ***\n");
        Console.WriteLine("***The rocket has landed agaiiin! Another successful landing! :3 ***");

        Console.ReadKey();
    }
}