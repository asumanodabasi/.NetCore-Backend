using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün adi gecersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride max 10 urun olabilir";
        public static string ProductNameAlreadyExist = "Bu urunde zaten urun var";
        public static string CategoryLimitExceded="Category sınırı aşildi";
    }
}
