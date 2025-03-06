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


            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Jesse";
            //game += player;
            //game -= player;

            Card card = new Card(); 
            card.Suit = Suit.Clubs;
            int underlyingValue = Convert.ToInt32(Suit.Diamonds);
            Console.WriteLine(underlyingValue);

            Deck deck = new Deck();
            deck.Shuffle(5);


            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();

        }
        
    }

}
