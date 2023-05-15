using Application.Common;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public class PlayerJoinGameRequest
    {
        public int GameId { get; set; }
        public int PlayerId { get; set; }
    }

    public class PlayerJoinGameUseCase
    {
        private readonly IRepository _repository;

        public PlayerJoinGameUseCase(IRepository repository)
        {
            _repository = repository;
        }

        //UseCase(Input,Output)
        //如果是這樣的話，那usecase不需要有output的參數，只要定義好output就好？
        //已下面的例子來說的話，我只需要指定回傳IPresenter型別，不用傳一個presenter近來???
        //筆記：presenter裡面時作方法叫做XXXX，在presenter轉成前端的格式，
        //在conroller那層拿到轉完的資料，丟前端
        public async Task ExcueteAsync(PlayerJoinGameRequest request, IPresenter presenter)
        {
            //查
            var game = _repository.FindById(request.GameId);
            //改
            game.PlayerJoin(new Player(request.PlayerId));
            //存
            _repository.Save(game);
            //推
            presenter.ShowGame(game);

            await Task.CompletedTask;
        }
    }
}
