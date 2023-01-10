// See https://aka.ms/new-console-template for more information

namespace CshIntermediate.Assignment1
{
    abstract class Pet
    {
        public abstract string PetType { get; }
        public string name { get; private set; }
        public string sound { get; private set; }

        public Pet(string _name, string _sound) { name = _name; sound = _sound; }

        public abstract int move();
        public abstract void sleep(int hours);

        public void makeSound(int repeats)
        {
            for (int i = 0; i < repeats; i++) Console.Write(sound + " ");
            Console.Write("\n");
        }
    }

    class Dog : Pet
    {
        public override string PetType { get { return "Dog"; } }

        public Dog(string _name, string _sound) : base(_name, _sound) { }

        public override int move()
        {
            Console.WriteLine($"The dog {name} trotted 10 meters");

            return 10;
        }

        public override void sleep(int hours)
        {
            Console.WriteLine($"The dog {name} slept for {hours} hours");
        }
    }

    class Bird : Pet
    {
        public Bird(string _name, string _sound) : base(_name, _sound) { }
        public override string PetType { get { return "Bird"; } }

        public override int move()
        {
            return 50;
        }

        public override void sleep(int hours)
        {
            Console.WriteLine($"The bird {name} slept for {hours} hours");
        }
    }

    class Lizzard : Pet
    {
        public Lizzard(string _name, string _sound) : base(_name, _sound) { }
        public override string PetType { get { return "Lizzard"; } }

        public override int move()
        {
            return 3;
        }

        public override void sleep(int hours)
        {
            Console.WriteLine($"The lizzard {name} slept for {hours} hours");
        }
    }

    class Fish : Pet
    {
        public Fish(string _name, string _sound) : base(_name, _sound) { }
        public override string PetType { get { return "Fish"; } }

        public override int move()
        {
            return 1;
        }

        public override void sleep(int hours)
        {
            Console.WriteLine($"The fish {name} slept for {hours} hours");
        }
    }

}
