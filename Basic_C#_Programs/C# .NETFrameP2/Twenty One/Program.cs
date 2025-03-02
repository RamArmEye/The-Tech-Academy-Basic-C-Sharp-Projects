using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twenty_One
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Game> games = new List<Game>();    
            //Game GAME = new TwentyOneGame();
            //games.Add(game);                   if creating list of games

            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Jessie", "Bob", "Bill" };
            game.ListPlayers();
            Console.ReadLine();


            //Deck deck = new Deck();
            //deck.Shuffle(5);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();

        }



        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
