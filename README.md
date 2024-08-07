Real Estate projesinde, bir admin, bir emlakçı bir de UI paneli yer alıyor.
Projemizi AspNet Core'un 8.0 sürümünde Api üzerinde geliştirdik.Backend tarafındaki kodlarımızın tamamını StackOverFlow firmasının geliştirdiği MicroOrm'lerden birisi olan Dapper Queryler ile hazırladık.
Emlakçı sisteme yeni ilan girişi yapıyor. Mevcut ilanlarında düzenlemeler yapıp pasif veya aktife çekebiliyor.dmin bütün sistemi yönetiyor. Hem emlakçı hem de admin tarafında Dashboard ve istatistik panelleri yer alıyor.
Admine atılan mesajlar SignalR ile anlık olarak görüntüleniyor.

Ana Sayfa Görünümü ;
![e1](https://github.com/enmertkaya/RealEstate_Dapper_Api/assets/151652097/8646e7f2-c4b7-4a40-b621-60ec8764207f)

Popüler Lokasyonlar icin Dapper ile yazmıs oldugum repository ;
![e3](https://github.com/enmertkaya/RealEstate_Dapper_Api/assets/151652097/81b3e704-bd85-4366-970e-294556ce9dea)

Popüler Lokasyonlar ana sayfada bu sekilde gözükür ;
![pL](https://github.com/enmertkaya/RealEstate_Dapper_Api/assets/151652097/a5148303-dbb9-42f0-b72d-962518c02f44)

Ana Sayfa içerisinde Günün favori ilanları,fırsatlar,hakkımızda,bize ulaşın alanları yer almaktadır.
![e2](https://github.com/enmertkaya/RealEstate_Dapper_Api/assets/151652097/a845a556-e28d-45fb-82ba-c4821463988f)

Modelimizden gelen değerleri alıp bir token olusturma islemi gerceklestirdik.
![e6](https://github.com/enmertkaya/RealEstate_Dapper_Api/assets/151652097/40265f86-e396-497c-8696-83bcaf062097)

Giriş yapan kullanıcı için Apide JWT oluşturma;
![e7](https://github.com/enmertkaya/RealEstate_Dapper_Api/assets/151652097/f1bd04c3-294e-4585-b2da-b5f85b4d5c70)

 Json Web Token Api Consume ile Giriş Yapma;
![e9](https://github.com/enmertkaya/RealEstate_Dapper_Api/assets/151652097/bb970126-a92b-4b1a-bfc8-0a4e0fd0c868)

Parametreli Trigger Kullanımı;
![image](https://github.com/user-attachments/assets/87f1cba0-818e-4862-8055-00fa9e913e9e)


 

Dashboard kısmında giris yapan kullanıcı bilgileri gelir.İstatistik bilgileri ve dinamik grafikler bu sekildedir.
![e4](https://github.com/enmertkaya/RealEstate_Dapper_Api/assets/151652097/b4f2d568-6eab-44be-a309-577f9ac560e5)

Son 5 kiralık ilan icin yazmıs oldugum sorgu ;
![e5](https://github.com/enmertkaya/RealEstate_Dapper_Api/assets/151652097/cdbf02ba-ff4c-48f0-83e7-b79b9d23b5fd)
