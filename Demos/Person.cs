namespace Demos;

public class Person
{
    public string name;
    public int age;
    protected int weight;

    //constructors
    public Person(string name, int age, int weight)
    {
        this.name = name;
        this.age = age;
        this.weight = weight;
    }
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public Person()
    {

    }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Weight { get; set; }

    //virtual method
    public virtual void SayHello()
    {
        Console.WriteLine("Hello from person!");
    }
}