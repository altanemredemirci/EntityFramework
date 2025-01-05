using EF_CodeFirst_1.ORM.Context;
using EF_CodeFirst_1.ORM.Entities;

namespace EF_CodeFirst_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  **** MICRO ORM(Object Relation Mapping) ****
                ORM yazılım dili ile SQL yapısını entegre eden ve kodlama cümlelerini basitleştirerek geliştirmeye yardımcı olan sistemlerdir.
                ** .Net için popüler ORMler
                * Ado.Net 44ms 
                       SqlConnection connect = new SqlConnection("Data Source =.; Initial Catalog =AdoNet; User Id = sa; Password=1;");

                        Musteri M1 = new Musteri();
                        M1.MusteriID = 2;
                        M1.Isim = "Ahmet";
                        M1.Soyisim = "Gökmen";


                        SqlCommand command = new SqlCommand("insert into Musteri values (@ID,@Isim,@Soyisim)",  connect);
                        command.Parameters.Add("@ID", SqlDbType.Int).Value = M1.MusteriID;
                        command.Parameters.Add("@Isim", SqlDbType.NVarChar).Value = M1.Isim;
                        command.Parameters.Add("@Soyisim", SqlDbType.NVarChar).Value = M1.Soyisim;

                        connect.Open();
                        int EtkilenenKayitSayisi =  command.ExecuteNonQuery();
                        connect.Close();

                * Entity Framework 682ms
                    SqlConnection connect = new SqlConnection("Data Source =.; Initial Catalog =AdoNet; User Id = sa; Password=1;");

                        Musteri M1 = new Musteri();
                        M1.MusteriID = 2;
                        M1.Isim = "Ahmet";
                        M1.Soyisim = "Gökmen";

                    connect.Musteri.Add(M1)

                * DAPPER - Stackoverflow 46ms
                 
                
                
             **** Entity Framework ****
             * Code First
             * Database First
             * Model First
             * Code First (Varolan Database)
              
             *** Code First: Yazılım şirketlerinin kullandığı en popüler modeldir. C# üzerinden sıfırdan bütün mimariyi kurmamızı ve veritabanını yönetmemizi sağlar. 
                Projede kullanılan classlar bir tabloyu temsil eder ve Entity olarak adlandırılır.


            ****** ADIMLAR ******
            * Projede ORM klasörü açıldı.
            * ORM içinde Entities(Proje nesnelerini-tabloları tanımlanacak.) ve Context(SQL connection bilgisi tanımlanacak.) klasörleri açıldı.
            * Entities içine Product ve Category class'ları açıldı.
            * Context içine DataContext class'ı açıldı.
            * DataContext:DbContext classından miras aldı.(EF Core paketini yüklendi.)
            * Sql bağlantısını tanımlamak için OnModelCreateing() metodu override edildi.
            * OnModelCreating() metodunda UseSqlServer() metodu kullanılması için EFCoreSqlServer paketi yüklendi.
            * DataContext.cs altında DbSet<> komutuyla tablo olmasını istediğimiz classları tanımladık.
            * Migration alarak projenin database krokisini çıkardık
                * Proje -> Open In Terminal -> dotnet ef migrations add CreateDatabase
                * Tools -> Package Manager Console m -> Add-Migration CreateDatabase
                
            * Migration database aktararak database oluşturuldu.
                *  Proje -> Open In Terminal -> dotnet ef database update
                *  Tools -> Package Manager Console m -> Update-Database
             */



            /* *** EF DATABASE DATA MANUPÜLASYON İŞLEMLERİ - CRUD - DML */

            DataContext db = new DataContext();

            // category = new Category();
            //category.Name = "Giyim";

            //db.Categories.Add(category);

            //db.SaveChanges(); //Entity değişikliklerinin hepsini database aktar.

            Category category2 = new Category();
            category2.Name = "Elektronik";

            Product p = new Product()
            {
                Name = "Laptop",
                Price = 1000,
                Stock = 100
            };
            //category2.products = new List<Product>();
            category2.products.Add(p);

            db.Categories.Add(category2);
            db.SaveChanges();
        }
    }
}
