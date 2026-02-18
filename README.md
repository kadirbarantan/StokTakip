
#  Stok Takip Sistemi

Bu uygulama, modern yazılım geliştirme prensipleri ve işletme yönetimi ihtiyaçları doğrultusunda hazırlanmış basit seviye bir envanter yönetim aracıdır. İşletmelerin stok süreçlerini dijitalleştirmesi, veri bütünlüğünü koruması ve operasyonel verimliliği artırması için tasarlanmıştır.

##  Kullanılan Teknolojiler
* **Dil:** C# (Windows Forms)
* **Veritabanı:** MS SQL Server
* **Sürüm Kontrolü:** Git

##  Temel Özellikler
* **Dinamik Envanter Yönetimi:** Ürünlerin eklenmesi, güncellenmesi ve silinmesi (CRUD) işlemlerini kapsar.
* **Hızlı Arama:** Ürün adına göre veritabanı üzerinde anlık filtreleme yaparak istenen veriye saniyeler içinde ulaşılmasını sağlar.
* **Veri Güvenliği:** SQL parametreleri kullanılarak veri tabanı sorgularının güvenli ve stabil çalışması sağlanmıştır.
* **Akıllı Arayüz:** DataGridView üzerinden satır seçimi ile verilerin form alanlarına otomatik aktarılması.



##  Kurulum ve Kullanım
1.  **Veritabanı Kurulumu:** `vt.sql` dosyasını SQL Server Management Studio (SSMS) üzerinde çalıştırarak tablo yapısını oluşturun.
2.  **Bağlantı Ayarı:** `UrunVT.cs` dosyasındaki bağlantı adresini (Connection String) kendi SQL Server bilgilerinizle güncelleyin.
3.  **Başlatma:** Visual Studio ile projeyi çalıştırabilirsiniz.

---
*Bu proje Kadir Baran TAN tarafından, yazılım geliştirme prensipleri ve modern veritabanı yönetim teknikleri uygulanarak geliştirilmiştir.*
