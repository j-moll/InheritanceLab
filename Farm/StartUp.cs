using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm;
//practice inheritance
public class StartUp
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.Eat();
        dog.Bark();

        Puppy puppy = new Puppy();
        puppy.Eat();
        puppy.Bark();
        puppy.Weep();

        Cat cat = new Cat();
        cat.Eat();
        cat.Meow();
    }
}

