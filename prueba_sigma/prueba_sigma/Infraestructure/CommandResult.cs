using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba_sigma.Infraestructure
{
    public class CommandResult<T, MT> where T : class
    {
        public bool Result { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

        public MT MetaData { get; set; }

        public CommandResult() { }

        public CommandResult(bool Result, string Message, T Data, MT MetaData)
        {
            this.Result = Result;
            this.Message = Message;
            this.Data = Data;
            this.MetaData = MetaData;
        }
    }

    public class CommandResult<T> where T : class
    {
        public bool Result { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

        public CommandResult(bool Result, string Message, T Data)
        {
            this.Result = Result;
            this.Message = Message;
            this.Data = Data;
        }
    }

    public class CommandResult
    {
        public bool Result { get; set; }
        public string Message { get; set; }

        public CommandResult(bool Result, string Message)
        {
            this.Result = Result;
            this.Message = Message;
        }
    }
}
