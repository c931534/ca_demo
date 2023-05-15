using Application.Common;
using Application.Presenters;
using Application.UseCases;
using ca_demo.Presenters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ca_demo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        //Field
        private readonly PlayerJoinGameUseCase _playerJoinGameUseCase;

        //Constructor
        public GameController(PlayerJoinGameUseCase playerJoinGameUseCase)
        {
            _playerJoinGameUseCase = playerJoinGameUseCase;
        }

        [HttpPost]
        public async Task<PlayerJoinGameViewModel?> PlayerJoinGameAsync(PlayerJoinGameRequest request)
        {
            //TODO：需要try catch回傳error
            try
            {
                var presenter = new PlayerJoinGamePresenter();
                //針扎：覺得這邊需要判斷執行成功或失敗，原本是回傳void，先改成回傳bool
                await _playerJoinGameUseCase.ExcueteAsync(request, presenter);
                return presenter.ViewModel ?? null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
