using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    interface IWalkAway
    {
        void ListPlayers();
        void WalkAway(Player player);
    }
}
