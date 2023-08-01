# Öğrenci Bilgi Sistemi (OBS)

Visual Studio 2022 'de C# forms ve MS-SQL Server 2019 programlarını kullanarak projeyi oluşturdum.
C# forms arayüzümü oluştururken, MS-SQL Server ise veritabanımı oluşturur iken kullandım.
3 tablom var bunlar: dbo.BackupOgrenci, dbo.OgrenciBilgiler, dbo.OgrenciNotlar olmak üzere.
dbo.OğrenciBilgiler tablosunda öğrenciye ait genel bilgileri, dbo.OğrenciNotlar tablosunda öğrencinin Vize, Final notlarını ve Vizenin % 30 'u , Finalin ise %70'ini 
alarak toplayıp ortalamasını elde ediyoruz yani öğrencinin notları ile ilgili bilgiyi içeren tablo.
dbo.BackupOgrenci tablosu ise dbo.OgrenciBilgiler tablosundan silinen öğrencilerin tüm bilgilerini tutan tablodur.

Öncelikle tabloları oluşturdum daha sonra Form'un tasarımını yaptım bkz: label, textbox, maskedtextbox, datagridview, button vs. kullanarak tasarımı gerçekleştirdim.
MS-SQL Veritabanım ile C# Forms'un veri bağlantısını sağladım.
Daha sonra ise ana formum ile oluşturmuş olduğum diğer formları bağladım , ve kullanmış olduğum araçlarla (tools) fonksiyonalitesini gerçekleştirdim.
ve Öğrenci Bilgi Sisteminde kısaca OBS diyebiliriz. OBS'de 7 tane fonksiyonalitem var bunlar; Kayıt ekleme, Not girme, Kayıt Listeleme, Kayıt Güncelleme, Kayıt Silme,
Raporlama ve Kayıt Arama gibi fonksiyonaliteler oluşturdum.

