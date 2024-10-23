.NET Core Ürün Yönetim Sistemi
Bu proje, .NET Core kullanılarak geliştirilmiş bir ürün yönetim sistemidir. Kullanıcılar, giriş yaparak ürün ekleme, güncelleme, silme ve kategorilere ayırma işlemlerini gerçekleştirebilir. Ayrıca, ürün bilgilerini istatistiksel olarak da görüntüleyebilirler.

Bu proje, öğrenme aşamasında geliştirilmiş olup, yeni özellikler ekleyerek veya mevcut işlevleri iyileştirerek daha da geliştirilmeye açıktır.

Özellikler
Kullanıcı Girişi: Sisteme giriş yaparak kullanıcı doğrulaması gerçekleştirilir.
Ürün Yönetimi: Ürün ekleme, düzenleme ve silme işlemleri yapılabilir.
Kategorilendirme: Ürünler farklı kategorilere ayrılarak daha kolay yönetilebilir.
İstatistiksel Görüntüleme: Ürünlere ait bilgilerin istatistiksel verileri görüntülenebilir.
Kurulum
Projeyi yerel ortamınızda çalıştırmak için aşağıdaki adımları izleyin:

Proje Deposu: Bu projeyi klonlayın veya zip dosyasını indirip açın.

bash
Kodu kopyala
git clone https://github.com/kullanici-adi/proje-adi.git
Bağımlılıkları Yükleyin: .NET Core SDK ve gerekli bağımlılıkları yüklediğinizden emin olun.

Veritabanı Ayarları: Proje içinde bulunan appsettings.json dosyasındaki veritabanı bağlantı ayarlarını yapılandırın.

Veritabanı Migrasyonları: Aşağıdaki komutları kullanarak veritabanı migrasyonlarını uygulayın.

bash
Kodu kopyala
dotnet ef database update
Projeyi Çalıştırın: Projeyi başlatmak için aşağıdaki komutu kullanın.

bash
Kodu kopyala
dotnet run
Geliştirme ve Katkı
Proje açık kaynak olup, geliştirmelere ve yeni özellikler eklenmesine açıktır. İstek göndererek (Pull Request) veya hata bildirerek katkıda bulunabilirsiniz.

Bu taslak üzerinde istediğiniz değişiklikleri yapabilir veya eklemek istediğiniz başka bilgiler varsa paylaşabilirsiniz.

## Ekran Görüntüleri

### 1.
![Ana Sayfa](https://github.com/mehmetgorer/CoreAndFood/blob/main/CoreAndFoodFix/ScreenShots/Screenshot_1.png)

### 2. 
![Ürün Listesi](https://github.com/mehmetgorer/CoreAndFood/blob/main/CoreAndFoodFix/ScreenShots/Screenshot_2.png)

### 3. 
![Ürün Ekleme](https://github.com/mehmetgorer/CoreAndFood/blob/main/CoreAndFoodFix/ScreenShots/Screenshot_3.png)

### 4. 
![Ürün Güncelleme](https://github.com/mehmetgorer/CoreAndFood/blob/main/CoreAndFoodFix/ScreenShots/Screenshot_4.png)

### 5. 
![Ürün Kategorileri](https://github.com/mehmetgorer/CoreAndFood/blob/main/CoreAndFoodFix/ScreenShots/Screenshot_5.png)

### 6. 
![İstatistiksel Görüntüleme](https://github.com/mehmetgorer/CoreAndFood/blob/main/CoreAndFoodFix/ScreenShots/Screenshot_6.png)

### 7. 
![Kullanıcı Girişi](https://github.com/mehmetgorer/CoreAndFood/blob/main/CoreAndFoodFix/ScreenShots/Screenshot_7.png)

