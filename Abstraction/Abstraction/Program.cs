using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals myPet = new Dog();

            //Dog dg = new Dog();

            myPet.sound();
            myPet.eat();
        }
    }
}
