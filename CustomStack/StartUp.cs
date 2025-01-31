
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack;

public class StartUp
{
    static void Main()
    {
        StackOfStrings stack = new();
        Console.WriteLine(stack.IsEmpty());
        stack.AddRange(new List<string> { "Ivan", "Asen", "Peter" });
        Console.WriteLine(stack.IsEmpty());
        while (!stack.IsEmpty())
        {
            Console.WriteLine(stack.Pop());
        }
    }
}
