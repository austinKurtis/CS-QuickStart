using System;

namespace DeclareVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string aFriend = "Bill";
                Console.WriteLine("Hello " + aFriend);

            aFriend = "Maria";
            Console.WriteLine("Hello " + aFriend);

            Console.WriteLine($"Hello {aFriend}");
        }
    }
}
