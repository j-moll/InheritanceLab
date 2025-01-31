using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList;

public class StartUp
{
    static void Main()
    {
        RandomList list = new();

        list.Add("Ivan");
        list.Add("Pesho");
        list.Add("Gosho");
        list.Add("Tosho");
        list.Add("Dimi");

        Console.WriteLine("Removed item");
        Console.WriteLine(list.RandomString());
        Console.WriteLine();

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}

