using System.Collections.Generic;
using Fuyu.Platform.Common.Http;
using Fuyu.Platform.Common.Models.EFT.Responses;
using Fuyu.Platform.Common.Serialization;
using Fuyu.Platform.Server.Databases;

namespace Fuyu.Platform.Server.Behaviours.EFT
{
    public class Locale : FuyuBehaviour
    {
        public Locale() : base("/client/locale/{languageId}")
        {
        }

        public override void Run(FuyuContext context)
        {
            var arguments = context.GetParameters(this);

            var languageId = arguments["languageId"];
            var locale = EftDatabase.Locales.GetGlobalLocale(languageId);
            var response = new ResponseBody<Dictionary<string, string>>
            {
                data = locale
            };

            SendJson(context, Json.Stringify(response));
        }
    }
}