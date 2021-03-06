﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarPriceInvalid = "Araba fiyatı geçersiz";
        public static string CarsListed = "Arabalar listelendi";

        public static string BrandAdded = "Marka başarıyla eklendi.";
        public static string BrandDeleted = "Marka başarıyla silindi.";
        public static string BrandUpdated = "Marka başarıyla güncellendi.";
        public static string FailedBrandAddOrUpdate = "Lütfen marka isminin uzunluğunu 2 karakterden fazla giriniz.";

        public static string ColorAdded = "Renk başarıyla eklendi.";
        public static string ColorDeleted = "Renk başarıyla silindi.";
        public static string ColorUpdated = "Renk başarıyla güncellendi.";

        public static string CustomerAdded = "Müşteri başarıyla eklendi.";
        public static string CustomerDeleted = "Müşteri başarıyla silindi.";
        public static string CustomerUpdated = "Müşteri başarıyla güncellendi.";


        public static string UserAdded = "Kullanıcı başarıyla eklendi.";
        public static string UserDeleted = "Kullanıcı başarıyla silindi.";
        public static string UserUpdated = "Kullanıcı başarıyla güncellendi.";


        public static string RentalAdded = "Araba Kiralama işlemi baraşıyla gerçekleşti.";
        public static string RentalDeletedRental = "Araba Kiralama işlemi iptal edildi.";
        public static string RentalUpdatedRental = "Araba Kiralama işlemi güncellendi.";
        public static string FailedRentalAddOrUpdate = "Bu araba henüz teslim edilmediği için kiralayamazsınız.";
        public static string RentalReturned = "Kiraladığınız araç teslim edildi.";

        public static string MaintenanceTime = "Sistem bakımda";
       
        public static string CheckIfImageLimitExceded = "Bir Araba'ya ait en fazla 5 resim olabilir";
        public static string ImageAdded = "Resim eklendi";
        public static string ImageUpdated = "Resim güncellendi";
        public static string ImageDeleted = "Resim silindi";

        public static string AuthorizationDenied = "Yetkiniz Yok";
        public static string UserRegistered = "Kayıt Başarılı";
        public static string UserNotFound = "Mail adresi bulunamadı";
        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Hesap başarılı oluştruldu";
    }
}
