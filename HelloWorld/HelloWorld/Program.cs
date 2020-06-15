using System; // using System means that we can use classes from the System namespace

namespace HelloWorld // namespace is used to organize your code, it is a container for classes and other namespaces
{
    class Program // class is a container for data and methods, which brings functionality to your program. Every line of code that runs in C# must be inside a class. In our example, we named the class Program.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}