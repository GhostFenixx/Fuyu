using System;
using System.Collections.Generic;

namespace Fuyu.Common.Networking
{
    public class HttpRouter : Router<HttpController>
    {
        public HttpRouter() : base()
        {
        }

        public void Route(HttpContext context)
        {
            var matches = GetAllMatching(context);

            foreach (var match in matches)
            {
                match.Run(context);
            }
        }
    }
}