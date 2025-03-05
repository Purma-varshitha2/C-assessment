using System;
class Program
{
    static void Main()
    {
        Dog dog = new Dog("Huskey");
        Cat cat=new Cat("Persian");
        dog.DisplayInfo();
        dog.MakeSound();
        cat.DisplayInfo();
        cat.MakeSound();
    }
}