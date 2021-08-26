using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public abstract class Animals
    {
        public abstract void eat();

        public void sound()
        {
            Console.WriteLine("Animals make funny sounds");
        }


    }

    class Dog : Animals
    {
        public override void eat()
        {
            Console.WriteLine("Some animals eat at night");
        }
    }
}
