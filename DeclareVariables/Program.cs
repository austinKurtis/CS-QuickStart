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

            string firstFriend = "Maria";
            string secondFriend = "Sage";

            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}.");
            Console.WriteLine($"The name of {firstFriend} has {firstFriend.Length} letters.");
            Console.WriteLine($"The name of {secondFriend} has {secondFriend.Length} letters.");
        }
    }
}
