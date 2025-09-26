namespace LambdaDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Action<string> action = delegate (string name) { Console.WriteLine("Hello " + name); };
            action("Wuhaitao");
            Action<string> action2 = name => Console.WriteLine("Hello " + name);
            action2("Seagull");
            Func<int, int, int> func = delegate (int a, int b) { return a + b; };
            Console.WriteLine(func(1, 2));
            Func<int, int, int> func2 = (a, b) => a + b;
            Console.WriteLine(func2(2, 3));
        }
    }
}
