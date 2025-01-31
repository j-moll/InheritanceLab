using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos;

public class StartUp
{
    static void Main()
    {
        Person person = new Person();
        Patient patient = new Patient();
        patient.ShowWeight();
        patient.SayHello();
        person.SayHello();
    }
}