using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {                                     //base demek temel sinif demek yani burdaki Result sinifi oluyo
        public SuccessResult(string message):base(true,message)
        {
                
        }
        public SuccessResult():base(true)
        {

        }
    }
}
