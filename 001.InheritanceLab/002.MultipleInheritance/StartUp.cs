using System;

namespace Farm
{
    public class StartUp
    {
        static void Main()
        {
            Dog dog = new Dog();
            Puppy puppy = new Puppy();

            dog.Eat();
            dog.Bark();

            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
        }
    }
}
