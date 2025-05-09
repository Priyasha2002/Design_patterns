// Product interface
public interface IAnimal
{
    void Speak();
}

// Concrete Products
public class Dog : IAnimal
{
    public void Speak() => Console.WriteLine("Woof!");
}

public class Cat : IAnimal
{
    public void Speak() => Console.WriteLine("Meow!");
}

// Factory
public class AnimalFactory
{
    public IAnimal CreateAnimal(string animalType)
    {
        return animalType.ToLower() switch
        {
            "dog" => new Dog(),
            "cat" => new Cat(),
            _ => throw new ArgumentException("Invalid animal type")
        };
    }
}

// Usage
var factory = new AnimalFactory();
IAnimal animal = factory.CreateAnimal("dog");
animal.Speak(); // Output: Woof!
