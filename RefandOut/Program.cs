using System;

namespace RefandOut
{
    class Program
    {

        public static int health = 3;
        

        static void Main(string[] args)
        {
            TestSubtractHealth();
            Console.ReadKey();
            TestSubtractHealth();
            Console.ReadKey();
            TestSubtractHealth();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Now we will test out the Sum method.");
            bool isEven;
            Console.WriteLine($"3 + 5 = {Sum(3, 5, out isEven)} and it is {isEven} that this sum is even.");

            Console.ReadKey();
            Console.Clear();
        }


        public static void TestSubtractHealth()
        {
            if (SubtractHealth(ref health))
            {
                Console.WriteLine($"Health is now {health}");
            }
            else
                Console.WriteLine("Health is not larger than zero.");
        }

        //TODO implement this ref method by returning a bool and subtracting from the parameter.
        //So it will have two outputs. the bool of true if health is > 0. and also set x to decrease by 1.
        //TODO Call the method in the main and make sure the method changes the number of a initialized variable and returns a bool.
        public static bool SubtractHealth(ref int x)
        {
            Console.WriteLine($"Subtracting one from current health ({health})");
            return --x > 0;
        }

        //TODO create method that uses the out keyword. Call the method in the main.



        public static int Sum(int x, int y, out bool even)
        {
            even = (x + y) % 2 == 0;
            return x + y;
            //use this method or make your own.

        }


    }
}
