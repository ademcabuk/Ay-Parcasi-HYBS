# 🌙 Ay Parçası HYBS (Hastane Yönetim ve Bilgi Sistemi)

.NET Windows Forms ve Microsoft SQL Server mimarisi üzerine inşa edilmiş; Hasta, Doktor ve Sekreter rollerine özel yetkilendirmeler barındıran rol bazlı bir masaüstü hastane otomasyonudur.

## 🛠️ Teknoloji Yığını

* **Dil & Platform:** C#, .NET 10.0 Windows Desktop SDK
* **Arayüz:** Windows Forms (WinForms)
* **Veritabanı:** Microsoft SQL Server (T-SQL, Stored logic)
* **Veri Erişimi:** ADO.NET (`SqlCommand`, `SqlDataReader`, Parametreli Sorgular)
* **IDE:** Visual Studio 2022

## 🚀 Temel Özellikler ve Modüller

Proje, 3 temel kullanıcı rolü üzerinden işlemektedir:

### 🧑‍🦱 Hasta Modülü
* **Güvenli Kimlik Doğrulama:** TC Kimlik numarası ve şifre ile giriş/kayıt işlemleri.
* **Randevu Yönetimi:** Dinamik branş ve doktor seçimi ile randevu alma. 
* **Randevu Geçmişi:** Aktif ve geçmiş randevuları ayrı ayrı filtreleyip görüntüleme.
* **Profil Yönetimi:** TC numarası kilitli olacak şekilde iletişim ve şifre bilgilerini güncelleyebilme.

### 👨‍⚕️ Doktor Modülü
* **Randevu Takibi:** Giriş yapan doktora ait güncel randevuların anlık listelenmesi.
* **Şikayet İnceleme:** Randevu listesindeki hastaya tıklandığında (`CellClick` event) hasta şikayetinin ekrana yansıması.
* **Bilgi Güncelleme:** Doktora ait branş, telefon ve şifre gibi bilgilerin yönetimi.

### 👩‍💼 Sekreter (Yönetici) Modülü
* **Sistem Yönetimi (CRUD):** Yeni doktor ve branş ekleme, silme ve güncelleme işlemleri.
* **Randevu Planlama:** TC doğrulaması ve branş/doktor filtrelemesi ile sistem üzerinden hasta adına randevu oluşturma veya güncelleme.
* **Duyuru Sistemi:** Hastane geneline tarih damgalı (timestamp) duyuru yayınlama (Maksimum 300 karakter).
* **Genel Takip:** Hastanedeki tüm randevuları branş, doktor ve hasta bazlı filtreleyerek listeleyebilme.

## 🏗️ Veritabanı Mimarisi

Sistem, ilişkisel veritabanı kurallarına uygun 6 ana tablo üzerinde çalışır:
* `Tbl_Hastalar`
* `Tbl_Doktorlar`
* `Tbl_Sekreterler`
* `Tbl_Brans`
* `Tbl_Randevular`
* `Tbl_Duyurular`

## 💡 Geliştirici Notları ve Güvenlik

* **SQL Injection Koruması:** Sistemdeki tüm veritabanı işlemleri `SqlParameter` kullanılarak parametrik sorgularla (Parameterized Queries) yazılmıştır.
* **Hata Yönetimi ve Tip Güvenliği:** T-SQL tarafında `TRY_CAST` ve `ISNULL` yapıları kullanılarak tip uyuşmazlıklarının önüne geçilmiş, C# tarafında `try-catch-finally` blokları ile güvenli bağlantı yönetimi sağlanmıştır.
* **Event-Driven UI:** Modallar arası veri transferinde ve form kapanışlarında tetiklenen dinamik UI yenileme mantığı (`FormClosed`, `SelectedIndexChanged`) kurgulanmıştır.

---
*Adem Çabuk*
