namespace function_overloading
{
    class abcd
    {
        public void add(int x, int y)
        {
            Console.WriteLine("Sum of two integers: " + (x + y));
        }  
        //public int add(int x, int y, int z)
        //{
        //    return x + y + z;
        //}
        public void add(double x, double y)
        {
            Console.WriteLine("Sum of two doubles: " + (x + y));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
