using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Player
    {
        public int Id { get; set; }

        public Player(int id)
        {
            Id = id;
        }
    }
}
