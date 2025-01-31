using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos;

//if sealed class - unable to inherit  //example: system class String is sealed and cannot be inherited // if sealed method, cannot be overriden
public sealed class Patient : Person
{
    //shadowing this and base fields
    protected float weight;

    public void ShowWeight()
    {
        double weight = 0.5;
        this.weight = 0.6f;
        base.weight = 1;

        Console.WriteLine($"Local var: {weight}");
        Console.WriteLine($"Current class: {this.weight}");
        Console.WriteLine($"Base: {base.weight}");
    }
    //method's override 
    public override void SayHello()
    {
        Console.WriteLine("Hello from patient!");
    }
    //override ToString method // base.ToString() = object.ToString(); 
    public override string ToString()
    {
        return "I'm a new patient.";
    }
}
