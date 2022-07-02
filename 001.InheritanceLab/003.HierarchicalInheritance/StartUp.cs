using System;

namespace Farm
{
    public class StartUp
    {
        static void Main()
        {
            Cat cat = new Cat();
            Dog dog = new Dog();

            cat.Meow();
            dog.Bark();
        }
    }
}
