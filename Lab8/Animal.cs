using System;

// Базовий клас
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Тварина видає звук.");
    }
}

// Похідний клас Dog
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Собака гавкає.");
    }
}

// Похідний клас Cat
class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Кіт муркоче.");
    }
}

class Program
{
    static void Main()
    {
        // Створюємо об'єкти
        Animal myAnimal = new Animal();  // Базовий клас
        Animal myDog = new Dog();        // Похідний клас Dog
        Animal myCat = new Cat();        // Похідний клас Cat

        // Викликаємо метод MakeSound для кожного об'єкта
        myAnimal.MakeSound();  // Виведе "Тварина видає звук."
        myDog.MakeSound();     // Виведе "Собака гавкає."
        myCat.MakeSound();     // Виведе "Кіт муркоче."
    }
}