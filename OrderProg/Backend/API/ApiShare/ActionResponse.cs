using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    public class ActionResponse<T>
    {
        public bool hasError  { get; set; }
        public string  responseMessage { get; set; }
        public T responseData { get; set; }
        public ActionResponse(bool _hasError,string msg, T _data)
        {
            hasError = _hasError;
            responseMessage = msg;
            responseData = _data;
        }
    }
    public class ActionResponseIds {
        public int orderId { get; set; }
    }
}
