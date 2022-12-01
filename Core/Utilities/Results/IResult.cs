using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler icin baslangic
   public interface IResult //kullaniciya islemin sonucunu ve basarili olup olmadigini gostermek icin olusturduk.Encapsulation icin kullanacaz
    {
        bool Success { get; } //sadece okunabilir
        string Message { get; }  //kulaniciya mesaj vercem
    }
}
