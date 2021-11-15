using System;

namespace Zhousy.SourceGenerator.Net5.Demo
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            HelloFrom("Generated Code");
            HelloWorldGenerated.HelloWorld.SayHello();
        }

        static partial void HelloFrom(string name);
    }
}
