using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;
using Hayalpc.Dcb.Common.Helpers.Interfaces;
using Hayalpc.Dcb.Common.Helpers;

namespace Hayalpc.Dcb.Common.Helpers
{
    public class HttpClientCreator : Library.Common.Helpers.Interfaces.IHtttpClientCreator
    {
        public HttpClientCreator()
        {
        }

        public HttpClient Create()
        {
            var client = new HttpClient();
            
            return client;
        }
    }
}
