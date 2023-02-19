using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    //Erisim Anahtari
   public class AccessToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; } //bitis zamani
    }
}
