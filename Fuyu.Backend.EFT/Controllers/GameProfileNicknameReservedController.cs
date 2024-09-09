using Fuyu.Common.Networking;
using Fuyu.Common.Serialization;
using Fuyu.Backend.BSG.DTO.Responses;

namespace Fuyu.Backend.EFT.Controllers
{
    public class GameProfileNicknameReservedController : HttpController
    {
        public GameProfileNicknameReservedController() : base("/client/game/profile/nickname/reserved")
        {
        }

        public override void Run(HttpContext context)
        {
            var sessionId = context.GetSessionId();
            var account = EftOrm.GetAccount(sessionId);

            var response = new ResponseBody<string>()
            {
                data = account.Username
            };

            context.SendJson(Json.Stringify(response));
        }
    }
}