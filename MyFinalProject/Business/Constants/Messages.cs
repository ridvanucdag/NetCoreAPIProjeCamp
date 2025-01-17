﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductNameAlreadyExists = "Aynı isimde ürün vardır. Lütfen farklı ürün ismi giriniz";
        public static string CategoryLimitExceded = "Kategori sınırı aşıldı";
    }
}
