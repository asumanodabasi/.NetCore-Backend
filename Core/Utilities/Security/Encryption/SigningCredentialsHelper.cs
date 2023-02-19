using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
  public  class SigningCredentialsHelper
    {                        //Credentials: kullanici bilgileri
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        {                              //AspNet e hangi anahtari ve algoritmayi vericegimizi soyledik
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
        }
    }
}
