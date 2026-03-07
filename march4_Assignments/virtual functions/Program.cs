namespace virtual_functions
{
    class base_class
    {
        public virtual void Display()
        {
            Console.WriteLine("Display from base class");
        }
    }

    class derived_class : base_class
    {
        public override void Display()
        {
            Console.WriteLine("Display from derived class");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            base_class obj= new ();
            obj.Display(); // Calls base class method
            Console.ReadLine();
        }
    }
}
