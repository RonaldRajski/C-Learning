using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);

            Console.WriteLine($"{Environment.NewLine} Hello again, {name}, Please meet these crazy guys:");


        Console.WriteLine(" .-.");
      // This is a redundant code
      Console.WriteLine("(o o)");
      Console.WriteLine("| O |");
      Console.WriteLine("|   |");
      Console.WriteLine("'~~~'");
      Console.WriteLine("Johnnie Da Ghost");


      Console.WriteLine("c_      ___");
      Console.WriteLine("   \\\\__|__|__");
      Console.WriteLine("    \\( o_o)");
      Console.WriteLine("      > ~  >");
      Console.WriteLine("     /    /\\\\");
      Console.WriteLine("    /    /  \\\\");
      Console.WriteLine("    \\    )  c/");
      Console.WriteLine("    /   /");
      Console.WriteLine("   /   /|");
      Console.WriteLine("   (   (\\ ");
      Console.WriteLine("   |   | \\ ");
      Console.WriteLine("   |  / \\ ) ");
      Console.WriteLine("   |  |  ) | ");
      Console.WriteLine("  /   )(_/");
      Console.WriteLine("(_ /");

        string name = "Shadow";
      string breed = "Golden Retriever";

      int age;
      age = 5;

      double weight;
      weight = 65.22;

      bool spayed = true;

      Console.WriteLine(name);
      Console.WriteLine(breed);
      Console.WriteLine(age);
      Console.WriteLine(weight);
      Console.WriteLine(spayed);



      }
    }
}
