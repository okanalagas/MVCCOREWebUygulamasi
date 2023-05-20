İlk önce ilgili kütüphaneleri indirmekle başlarız.

Entitiy Framework Core manage nuget ile indirilir.

ef core SQL server indirilir.

ef core tools indirilir.

ef core proxies indirilir (ef de relational propertiese virtual yazınca lazy loading aktif oluyordu burda olmadığı için indiriyoruz.)

connection string appsettingse yazılır.

klasörleri organize etmek adına models klasörünün altına context , entities , enums ve configuration klasörleri açılır 

context klasörüne mycontext adında bir class açılır ve dbcontexten miras alınır.

.net core da arka planda çalışan otomatik dependecy injection vardır.veritabanı tanıtınımı yapmak için program csye gidilir. 

program cs de mimari oluşturmak için ilgili ayarlar yapılır. 

mycontext classında ilgili ayarlar yapılır ve ctorlar oluştururlur.

enums klasörünün içine datastatus adında bir enum açılır ve veri tipleri tanımlanır.

Entities klasörüne classlar oluşturulur.

bire bir ve çoka çok ilişkiler için map yerine configuration kullanılır base mapi karşılayacak şekilde configuration klasörüne base configuration classı açılır.. bu class IEntityTypConfiguration classsından miras alır. ve implement edilir.

implement edilen metot polymorphisim prensibine maruz kaalbileceği için virtual kelimesiyle işaretlenir 

ilgili classlar için configuration classları açılır.(mapping işlemleri) ve baseconfigin metodu override edilir. bazı ayarlar opsiyoneldir.

ilişki tanımalamaları için kullanılacak olan ayarlar zaruridir....

tanımladığımız configurationlar mycontexte kullanılır.

mycontexte kullanılacak dbsetler yazılır..

add migration yazılır. update database yazılır.ve veritabanı gözlemlenir.

CRUD işlemleri için CategoryController oluşturulur.

Mycontext tipinde dp oluşturulur ve ctorunda atama işlemi yapılır.

iactionresult tipinde ilgili metotlar yazılır.

Viewların entities içindeki classları da tanıması için viewimporta @using entities yazılır..

Categorycontroller için viewlara klasör açılır ve viewlar oluşturulur.

view içinde model karşılanır.



