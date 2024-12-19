using System;
class Animal
{
    public string Name;
    public void display()
    {
        Console.WriteLine("Im an Animal");
    }
}
class Dog : Animal
{
    public void getName()
    {
        Console.WriteLine("My name is " + Name);
    }
}
class Program
{

    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Name = "test";
        dog.display();
        dog.getName();

    }
}