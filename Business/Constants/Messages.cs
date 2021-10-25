using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Core.Entities.Concrete;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInValid = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime = "Şuan bakımdayız";
        public static string ProductsListed = "Ürünler Listelendi";

        public static string ProductCountOfCategoryError = "Ürün yükleme sınırını aştınız.";

        public static string ProductNameAlreadyExists = "Ürün ismi daha önce kullanıldı";
        public static string CategoryLimitExceded = "Maksimun kategori limitine ulaştınız.";
        public static string AuthorizationDenied = "Yetkilendirme Hatası";
        public static string UserRegistered = "Kullanıcı kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı!";
        public static string PasswordError = "Şifre Hatalı";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten kayıtlı.";
        public static string AccessTokenCreated = "Token Üretildi.";
    }
}
