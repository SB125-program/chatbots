using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "JimmyBOT.exe";
            Console.WriteLine("HELLO! I will now be your assistant known as...");
            Console.WriteLine("JimmyBOT");
            Console.WriteLine("before you have access to the Tate_Assistant. I have to ask some questions");
            Console.WriteLine("Please enter your email...");
            string email = Console.ReadLine();
            Console.WriteLine("Please enter year of birth...");
            string year = Console.ReadLine();
            Console.WriteLine("Please Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Email is : " +email);
            Console.WriteLine("Year of birth is : "+ year);
            Console.WriteLine("Name is : " + name);
            Console.WriteLine($"account successfully activated {DateTime.Now}");
            Console.WriteLine("press any key to start...");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("I will be your assistant from now on");
        Assist:
            Console.WriteLine("how may I help?");
            string task = Console.ReadLine();
            if (task is "song")
            {
                var list = new List<string> { "Guns n roses", "Queen", "pink floyd", "Rick Astley", "Kokonut tree" };
                var random = new Random();

                int index = random.Next(list.Count);
                Console.WriteLine("I recommend songs from this band:");
                Console.WriteLine(list[index]);
                goto Assist;


            }

            else if (task is "close")
            {
                Console.Clear();
                Console.WriteLine("press any key to confirm shutdown...");
                Console.ReadKey(true);

            }
            else if (task is "motivate me")
            {
                var list = new List<string> { "Push yourself because no one else is going to do it for you", "Always believe that something wonderful is about to happen", "Failure is not the opposite of success. It is part of the success", "It's a beautiful day to go after your dreams", "Don't focus on the pain, focus on the progress" };
                var random = new Random();

                int index = random.Next(list.Count);
                //outputs a random quote from the library
                Console.WriteLine(list[index]);
                goto Assist;
            }
            else if (task is "tell me a joke")
            {

                var list = new List<string> { "whats the best thing about switzerland? I don't know but the flag is a big plus", "Where do you find a cow with no legs? Right where you left it", "Why can't a nose be 12 inches? Because then it'd be a foot", "What did the policeman say to the belly button? You're under a vest", "Why shouldn't you give Elsa a balloon? because she'll 'let it go!'" };
                var random = new Random();

                int index = random.Next(list.Count);
                //outputs a random quote from the library
                Console.WriteLine(list[index]);
                goto Assist;
            }

            else if (task is "how are you")
            {
                var list = new List<string> { "Great thanks. What about you?", "I'm alright thanks what about you?", "I'm not feeling to well today, what about you?", "Extremly stressed out dealing with you ;) sorry joking. What about you?", "Feeling rather sad today, what about you?" };

                var random = new Random();

                int index = random.Next(list.Count);
                //outputs a random quote from the library
                Console.WriteLine(list[index]);

                goto Assist;
            }

            else
            {
                Console.WriteLine("Sorry I do not know that one");
                goto Assist;

            }

        }
    }
}
