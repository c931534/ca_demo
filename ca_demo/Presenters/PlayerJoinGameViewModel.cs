using Application.Common;
using Domain.Entities;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace ca_demo.Presenters
{
    public class PlayerJoinGameViewModel
    {
        public int GameId { get; set; }
        public ICollection<Player> Players { get; private set; } = new List<Player>();

        //TODO：前端需要的資料格式轉換
        public PlayerJoinGameViewModel(Game game)
        {
            GameId = game.Id;
            Players = game.Players;
        }
    }
}
