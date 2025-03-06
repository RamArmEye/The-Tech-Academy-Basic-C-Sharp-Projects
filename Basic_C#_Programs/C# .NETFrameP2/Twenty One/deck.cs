using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twenty_One
{
    class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            List<string> Suits = new List<string>() { "Hearts", "Diamonds", "Spades", "Clubs" };
            List<string> Faces = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8",
                "9", "10", "Jack", "Queen", "King" 
            };
            
            foreach (string suit in Suits)
            {
                //foreach (string face in Faces)
                //{
                //    Card card = new Card();
                //    card.Suit = suit;
                //    card.Face = face;
                //    Cards.Add(card);
                    
                //}
            }



        } public List<Card> Cards { get; set; }

        public  void Shuffle(int times = 1)
        {
            
            for (int i = 0; i < times; i++)
            {
                
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 1)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);

                }
                Cards = TempList;
            }

        }
    }
}
