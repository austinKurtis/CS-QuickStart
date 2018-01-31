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

            string message = "        Hello World!         ";
            Console.WriteLine($"[{message}]");

            string trimmedMessage = message.TrimStart();
            Console.WriteLine($"[{trimmedMessage}]");

            trimmedMessage = message.TrimEnd();
            Console.WriteLine($"[{trimmedMessage}]");

            trimmedMessage = message.Trim();
            Console.WriteLine($"[{trimmedMessage}]");

            string messageHW = "Hello World!";
            Console.WriteLine(messageHW);

            messageHW = messageHW.Replace("Hello", "Greetings");
            Console.WriteLine(messageHW);

            string whatUp = "What Up, Yo!";
            Console.WriteLine(whatUp);
            Console.WriteLine(whatUp.ToUpper());
            Console.WriteLine(whatUp.ToLower());
        }
    }
}
