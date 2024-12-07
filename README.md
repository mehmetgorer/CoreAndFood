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
git clone https://github.com/mehmetgorer/CoreAndFood.git
Bağımlılıkları Yükleyin: .NET Core SDK ve gerekli bağımlılıkları yüklediğinizden emin olun.

Veritabanı Ayarları: Proje içinde bulunan appsettings.json dosyasındaki veritabanı bağlantı ayarlarını yapılandırın.

Veritabanı Migrasyonları: Aşağıdaki komutları kullanarak veritabanı migrasyonlarını uygulayın.

bash
dotnet ef database update
Projeyi Çalıştırın: Projeyi başlatmak için aşağıdaki komutu kullanın.

bash
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

.NET Core Product Management System
This project is a product management system developed using .NET Core. Users can log in to add, update, delete, and categorize products. Additionally, product information can be viewed with statistical insights.

This project was developed as part of a learning process and is open to further development by adding new features or improving existing functionalities.

Features
User Authentication: Users can log in to the system for authentication.
Product Management: Allows adding, editing, and deleting products.
Categorization: Products can be organized into different categories for easier management.
Statistical View: Provides statistical insights related to the product information.
Installation
To run the project locally, follow these steps:

Clone the Repository: Clone this project or download the zip file and extract it.

bash
git clone https://github.com/mehmetgorer/CoreAndFood.git
Install Dependencies: Make sure you have .NET Core SDK and all necessary dependencies installed.

Database Configuration: Configure the database connection in the appsettings.json file located within the project.

Apply Database Migrations: Run the following commands to apply database migrations.

bash
dotnet ef database update
Run the Project: Start the project using the command below.

bash
dotnet run
Contribution
The project is open-source and contributions are welcome. You can contribute by submitting a pull request or reporting an issue.

