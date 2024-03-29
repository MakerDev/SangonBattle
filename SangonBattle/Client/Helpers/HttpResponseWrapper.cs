﻿using System.Net.Http;
using System.Threading.Tasks;

namespace SangonBattle.Client.Helpers
{
    public class HttpResponseWrapper<T>
    {
        public HttpResponseWrapper(T response, bool success, HttpResponseMessage httpResponseMessage)
        {
            Response = response;
            Success = success;
            HttpResponseMessage = httpResponseMessage;
        }

        public T Response { get; set; }
        public bool Success { get; set; }
        public HttpResponseMessage HttpResponseMessage { get; set; }

        public async Task<string> GetBodyAsync()
        {
            return await HttpResponseMessage.Content.ReadAsStringAsync();
        }

    }
}
