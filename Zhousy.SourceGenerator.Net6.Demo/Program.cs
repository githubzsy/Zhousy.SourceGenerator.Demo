// See https://aka.ms/new-console-template for more information

namespace Zhousy.SourceGenerator.Net6.Demo
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1111");
            HelloFrom("Generated Code");
            HelloWorldGenerated.HelloWorld.SayHello();
        }

        static partial void HelloFrom(string name);
    }
}

