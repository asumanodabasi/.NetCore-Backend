using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
       

        public Result(bool success, string message):this(success)  //this demek sinifin kendisi demek icine success verince success parametreli(tek parametreli) ctor bul ve calistir demis olduk
        {
            Message = message;  //message set ettik
            
        }
        public Result(bool success) //ctor  overloading
        {
            Success = success;
        }

        public bool Success { get; } 

        public string Message { get; } //getter redonly dir redonlyler constructorda set edilir
    }
}
