// See https://aka.ms/new-console-template for more information

Human Jeff = new Human();
Jeff.name = "Jeff";
Jeff.age = 15;
Console.WriteLine(Jeff.name + Jeff.age);
Jeff.Speak();

public class Human
{
    public string name;
    public int age;
    public void Speak()
    {
        Console.WriteLine("Hello, my name is " + name);
    }
}



// Console.WriteLine("Give me a sentence:");
// string sentance = Console.ReadLine();
// Console.WriteLine(CountWords(sentance));

// static int CountWords(string sentance)
// {
//     string[] words = sentance.Split(' ');
//     return words.Length;
// }

// double s = Sqr(2);
// Console.WriteLine(s);

// static void PrintNumber(int a, int b)
// {
//     Random rnd = new Random();
//     int n = rnd.Next(a, b);
//     Console.WriteLine(n);
// }

// double Sqr(int a)
// {
//     double ret = Math.Pow(a, 2);
//     return ret;
// }
// Console.WriteLine("How many students?");
// int n = int.Parse(Console.ReadLine());
// string[] arr = new string[n];
// Console.WriteLine("What are their names?");
// for (int i = 0; i < n; i++)
// {
//     arr[i] = Console.ReadLine();
// }
// Array.Sort(arr);
// Console.WriteLine("Here are the names sorted:");
// for (int i = 0; i < n; i++)
// {
//     Console.WriteLine(arr[i]);
// }