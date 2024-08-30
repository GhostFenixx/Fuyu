using Fuyu.Platform.Common.Http;
using Fuyu.Platform.Common.Models.EFT.Responses;
using Fuyu.Platform.Common.Serialization;
using Fuyu.Platform.Server.Databases;

namespace Fuyu.Platform.Server.Behaviours.EFT
{
    public class MenuLocalePo : FuyuBehaviour
    {
        public override void Run(FuyuContext context)
        {
            var locale = EftDatabase.Locales.GetMenuLocale("po");
            var response = new ResponseBody<MenuLocaleResponse>
            {
                data = locale
            };

            SendJson(context, Json.Stringify(response));
        }
    }
}