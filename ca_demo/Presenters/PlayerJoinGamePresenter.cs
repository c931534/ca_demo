using Application.Common;
using Application.UseCases;
using ca_demo.Presenters;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Presenters
{
    public class PlayerJoinGamePresenter : IPresenter
    {
        public PlayerJoinGameViewModel? ViewModel { get; private set; }

        public void ShowGame(Game game)
        {
            ViewModel = new PlayerJoinGameViewModel(game);
        }
    }
}
