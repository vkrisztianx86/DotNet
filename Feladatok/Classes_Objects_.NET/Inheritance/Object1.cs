using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    interface IMoving
    {
        public int Y { get; set; }

        public void Moving(int distance);
    }

    public abstract class Living_Organismus
    {
        public int X {  get; set; }
        public abstract void Move(int x);
    }
    public class Human : Living_Organismus, IMoving
    {
        public int Age { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return "I am a human";
        }
        public virtual void Read()
        {
            Console.WriteLine("Can't read yet");
        }
        public override void Move(int x)
        {
            X += x;
            Console.WriteLine($"I went {x} meters. Where am I? {X}");
        }

        public void Moving(int distance)
        {
            Y += distance;
            Console.WriteLine($"Where am I? {Y}");
        }
    }
    public class Student : Human
    {
        public override string ToString()
        {
            return "I am a student";
        }
        public override void Read()
        {
            Console.WriteLine("Trying to read");
        }
    }
    
        public class Teacher : Human
        {
            public override void Read()
            {
                Console.WriteLine("Reading a lot");
            }

            public void Teach()
            {
            Console.WriteLine("I teach");
            }

        }

    public class Auto : IMoving
    {
        public int Y { get; set; }

        public void Move(int x)
        {
            Console.WriteLine($"Where am I? {x}");
        }

        public void Moving(int distance)
        {
            Y += distance;
            Console.WriteLine($"Where am I? {Y}");
        }
    }

    
    
}
