using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MiniCloud.Main.Helpers.Exceptions
{
    public class ApiErrorException : Exception
    {
        public HttpStatusCode Status { get; }
        public override string Message { get; }

        public ApiErrorException(HttpStatusCode status, string message)
        {
            Status = status;
            Message = message;
        }
    }
}
