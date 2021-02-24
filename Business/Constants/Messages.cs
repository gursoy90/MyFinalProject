using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProdutsListed = "Ürünler Listelendi";
        public static string ProductDeleted = "Ürün Silindi";
        public static string ProductUpdated="Ürün Güncellendi";
        public static string ProductCountOfCategoryError= "Bir Kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists="Bu isimde zaten başka bir ürün var";
        internal static string CategoryLimitExceded="Kategori Limiti aşıldığı için yeni ürün eklenemiyor";
    }
}
