namespace zad2
{
    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("speak");
        }
    }

    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Hau Hau");
        }
    }

    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Miau Miau");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] a = [new Dog(), new Cat()];

            a[0].Speak();
            a[1].Speak();
        }
    }
}
