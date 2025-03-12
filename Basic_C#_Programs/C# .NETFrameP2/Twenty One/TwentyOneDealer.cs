using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twenty_One
{
    public class TwentyOneDealer : Dealer
    {
        public List<Card> Hand { get; set; }
        public bool Stay { get; set; }
        public bool IsBusted { get; set; }

        public static implicit operator string(TwentyOneDealer v)
        {
            throw new NotImplementedException();
        }
    }
}