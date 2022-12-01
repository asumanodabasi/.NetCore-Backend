using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{                 //mesaj,islem sonucu ve data icercek
   public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
