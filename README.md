# DividendProject
 Borsa istanbul'da bulunan hisselerin temettü bilgilerini çekmek için kullanabileceğiniz backend projesi

# İçindekiler
- [Commit Standartı](#commit)
- [API](#api)
- [Teknolojiler](#Teknolojiler)
- [To-Do Task](#To-Do-Tasks)
- [Done Task](#Gerceklestirilenler)
- [Kütüphaneler](#Kutuphaneler)



#### Commit
`[Commit Id][commit message]` şeklindedir. 

#### API
-------- Hisseler -----------
- Endpoint: https://api.collectapi.com/economy/hisseSenedi
- Headers: Authorization -> apikey collectApiKey'iniz
- Type: GET

#### Teknolojiler;
- .Net
- MongoDB

#### To-Do Tasks
- 

#### Gerceklestirilenler
- Proje Oluşturulması(C'in-1)
- Readme.md dosyasının güncellenmesi(C'in-1)
- Proje'nin api'ye bağlanıp hisseleri çekmesi(C'in-1)
- İşyatırım sitesinde hisseler için tek tek dolanıp temettü bilgileri çekildi.(C'in-1)
- Hazırlanan veriler mongoDB üzerinde tabloya kaydedildi.(C'in-1)


#### Kutuphaneler
- HtmlAgilityPack --> WebSitesi üzerinden verileri getirmek için.

#### Hata yorumlamaları
Api çağırımlarında gelen cevaplar aşağıdaki gibidir bu kontroller eklenmelidir.
- Success (Status Code 200)
- Unauthorized (Status Code 401)
- Internal Server Error (Status Code 500)
