using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDo.Menu
{
    internal static class Texts
    {
        public static void Period()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("🔻");
            Console.ResetColor();
        }

        public static void IntroOak()
        {
            Console.Clear();

            PokeAscii.ShowAscii("Oak");
            Thread.Sleep(3000);
            Console.Clear();
            Console.Write("Hello, there! Glad to meet you!");
            Period();
            Console.ReadLine();

            Console.Write("Welcome to the world of POKEMON. My name is OAK.");
            Period();
            Console.ReadLine();

            Console.Write("People affectionately refer to me as the POKEMON PROFESSOR.");
            Period();
            Console.ReadLine();
            Console.Clear();

            Console.Write("This world is inhabited far and wide by creatures called POKEMON.");
            Period();
            Console.ReadLine();

            Console.Write("For some people, POKEMON are pets. Others use them for battling.");
            Period();
            Console.ReadLine();

            Console.Write("As for myself… I study POKEMON as a profession.");
            Period();
            Console.ReadLine();
            Console.Clear();

            Console.Write("Your very own POKEMON legend is about to unfold!");
            Period();
            Console.ReadLine();

            Console.Write("A world of dreams and adventures with POKEMON awaits!");
            Period();
            Console.ReadLine();

            Console.Write("Oh! But first, you need your own POKEMON! Here, come with me!");
            Period();
            Console.ReadLine();
            Console.Clear();

            Console.Write("Here, there are three POKEMON.");
            Period();
            Console.ReadLine();

            Console.Write("When I was young, I was a serious POKEMON TRAINER.");
            Period();
            Console.ReadLine();

            Console.Write("But now, in my old age, I have only these three left.");
            Period();
            Console.ReadLine();
            Console.Clear();
        }

        public static void BrockBefore()
        {
            Console.Clear();

            PokeAscii.ShowAscii("Brock");
            Thread.Sleep(3000);
            Console.Clear();

            Console.Write("Brock >> So, you’re here. I’m BROCK. I’m PEWTER’s GYM LEADER.");
            Period();
            Console.ReadLine();

            Console.Write("My rock-hard willpower is evident even in my POKEMON.");
            Period();
            Console.ReadLine();

            Console.Write("My POKEMON are all rock hard, and have true-grit determination.");
            Period();
            Console.ReadLine();

            Console.Write("That’s right - my POKEMON are all the ROCK type!");
            Period();
            Console.ReadLine();
            Console.Clear();

            Console.Write("Fuhaha! You’re going to challenge me knowing that you’ll lose?");
            Period();
            Console.ReadLine();

            Console.Write("That’s the TRAINER’s honor that compels you to challenge me.");
            Period();
            Console.ReadLine();

            Console.Write("Fine, then! Show me your best!");
            Period();
            Console.ReadLine();
            Console.Clear();

            for (int i = 0; i < 500; i++)
            {
                Console.Write("@");
                Thread.Sleep(1);

            }

            Thread.Sleep(2000);
            Console.Clear();

            Console.Write("LEADER BROCK would like to battle!");
            Period();
            Console.ReadLine();

            Console.Write("LEADER BROCK sent out GEODUDE");
            Period();
            Console.ReadLine();
            Console.Clear();

            PokeAscii.ShowAscii("Geodude");
            Thread.Sleep(2000);
            Console.Clear();
        }

        public static void BrockAfter()
        {
            Console.Clear();

            Console.Write("Brock >> I took you for granted and so I lost.");
            Period();
            Console.ReadLine();

            Console.Write("As proof of your victory, I confer on you this the official POKEMON LEAGUE BOULDERBADGE.");
            Period();
            Console.ReadLine();
            Console.Clear();

            Console.Write("You’ve received the BOULDERBADGE from BROCK!");
            Period();
            Console.ReadLine();
            Console.Clear();
        }
    }
}
