// See https://aka.ms/new-console-template for more information

abstract class Animal
{
    public abstract void MakeSound();  //abstract method

    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }

}
class Dog:Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks");
    }
}
class Cat:Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The cat meows");
    }
}

/*class Program
{
    public static void Main()
    {
        Dog d = new Dog();
        Cat c = new Cat();
        c.MakeSound();
        d.MakeSound();
        c.Eat();
        d.Eat();
    }
}
class Animal
{
    public void MakeSound()
    {
        Console.WriteLine("Animal voice");
    }  //abstract method

    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }

}
class Dog:Animal
{
    public new void MakeSound()
    {
        Console.WriteLine("The dog barks");
    }
}
class Cat:Animal
{
    public new void MakeSound()
    {
        Console.WriteLine("The cat meows");
    }
}

class Program
{
    public static void Main()
    {
        Animal d = new Dog();   //Here we are creating an object of type dog but assigning it to a variable of type animal
        Animal c = new Cat();   
        c.MakeSound();
        d.MakeSound();
        c.Eat();
        d.Eat();
    }
}*/