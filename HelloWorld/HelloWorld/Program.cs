using System; // using System means that we can use classes from the System namespace

namespace HelloWorld // namespace is used to organize your code, it is a container for classes and other namespaces
{
    class Program // class is a container for data and methods, which brings functionality to your program. Every line of code that runs in C# must be inside a class. In our example, we named the class Program.
    {
        static void Main(string[] args)
        {
            // Take extra care with cases in C#
            Console.WriteLine("Hello World!");
            
            // Console.Write() writes on the same line
            Console.Write("This sentence is");
            Console.Write(" connected!");
            
            /* VARIABLES */
            
            // TYPE     VALUE
            // int      stores integers (whole numbers), without decimals, such as 123 or -123
            // double   stores floating point numbers, with decimals, such as 19.99 or -19.99
            // char     stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
            // string   stores text, such as "Hello World". String values are surrounded by double quotes
            // bool     stores values with two states: true or false
            
            // Syntax – type variableName = value;

            string name = "John";
            Console.WriteLine(name);
            int age = 35;
            double money = 7568.49;
            char bloodType = 'a';
            bool employed = true;
            Console.WriteLine("What is your name? " + name + ".");
            Console.WriteLine("How old are you? " + age + ".");
            Console.WriteLine("How much money do you have? $" + money + "NZD.");
            Console.WriteLine("What is your blood type? " + bloodType + ".");
            Console.WriteLine("You are currently employed: " + employed + ".");


        }
    }
}