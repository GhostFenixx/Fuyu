using Fuyu.Platform.Common.Http;
using Fuyu.Platform.Common.IO;
using Fuyu.Platform.Common.Models.EFT.Locations;
using Fuyu.Platform.Common.Models.EFT.Responses;
using Fuyu.Platform.Common.Serialization;

namespace Fuyu.Platform.Server.Behaviours.EFT
{
    public class Locations : FuyuBehaviour
    {
        private readonly ResponseBody<WorldMap> _locations;

        public Locations()
        {
            var text = Resx.GetText("eft", "database.eft.client.locations.json");
            _locations = Json.Parse<ResponseBody<WorldMap>>(text);
        }

        public override void Run(FuyuContext context)
        {
            var response = Json.Stringify(_locations);
            SendJson(context, response);
        }
    }
}