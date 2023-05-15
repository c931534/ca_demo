using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    //聚合根(Aggregate Root)
    public class Game
    {
        public int Id { get; private set; }
        public Game(int id)
        {
            Id = id;
        }

        public ICollection<Player> Players { get; private set; } = new List<Player>();

        public void PlayerJoin(Player player)
        {
            if (Players.Count > 10)
                throw new Exception("too many players.");

            Players.Add(player);
        }
    }
}
