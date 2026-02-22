# Site Yönetim Programı 🏢

Bu proje, bir konut sitesinin günlük yönetim süreçlerini dijitalleştirmek ve kolaylaştırmak amacıyla geliştirilmiş bir **C# Windows Forms** masaüstü uygulamasıdır. Nesne Yönelimli Programlama (OOP) prensipleri temel alınarak tasarlanmıştır.

## 🌟 Özellikler

* **Kişi ve Daire Yönetimi:** Sitede oturan kişilerin, aile reislerinin ve dairelerin sisteme kaydedilmesi ve yönetilmesi.
* **Sosyal Tesis (Mekan) Takibi:** Site içerisindeki havuz ve spor salonu (fitness) gibi aktivite alanlarının durumlarının ve kullanımlarının takibi.
* **Misafir İşlemleri:** Siteye dışarıdan gelen misafirlerin kayıt altına alınması ve hangi daireye geldiklerinin izlenmesi.
* **Aidat ve Ödeme Takibi:** Site sakinlerinin yapması gereken ödemelerin sisteme girilmesi ve güncel durumlarının takip edilmesi.
* **Veri Saklama:** Tüm veriler sistem üzerinde yerel metin (.txt) dosyaları kullanılarak güvenle saklanır ve program kapatılıp açıldığında kaybolmaz.

## 💻 Kullanılan Teknolojiler

* **Programlama Dili:** C#
* **Geliştirme Ortamı:** Visual Studio 2022
* **Arayüz (UI):** Windows Forms (.NET 8.0)
* **Veri Saklama:** Yerel Text (.txt) dosyaları (Örn: `data.txt`, `Mekan.txt`, `Oturan.txt`)
* **Mimari:** Nesne Yönelimli Programlama (Kalıtım, Kapsülleme, Çok Biçimlilik)

## 📐 Sınıf Yapısı (Mimari)

Proje, genişletilebilir bir yapıya sahip olması için temel Nesne Yönelimli Programlama mantığıyla kurulmuştur.
* `Mekan` temel sınıfından türeyen `Havuz` ve `Fitness` sınıfları.
* `Oturan` temel sınıfı ve alt dalları.
* *(Proje dizininde yer alan `NDPProjectUMLClassDiagram.PDF` dosyasını inceleyerek uygulamanın detaylı sınıf diyagramına (UML) göz atabilirsiniz.)*

## 🚀 Kurulum ve Kullanım

Projeyi kendi bilgisayarında denemek istersen şu adımları takip edebilirsin:

1. Bu projeyi bilgisayarına indir veya Git ile klonla:
   ```bash
   git clone [https://github.com/enescagri34/site_management_program.git](https://github.com/enescagri34/site_management_program.git)
