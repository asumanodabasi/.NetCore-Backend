using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public class SuuccessDataResult<T>:DataResult<T>
    {
        public SuuccessDataResult(T data,string message):base(data,true,message)
        {

        }

        public SuuccessDataResult(T data):base(data,true)
        {
        }
        public SuuccessDataResult(string message):base(default,true,message)
        {

        }

        public SuuccessDataResult():base(default,true)
        {

        }
    }
}
