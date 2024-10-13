using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230827_HazirLinqMetodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>()
            {
                45,6,78,254,96,-60,30,456,854,6545,41,26,65,-87,3
            };

            //Linq sorgulamaları esnasında bir takım işlemleri daha hızlı ve pratik şekilde yapabilmemiz için hazır linq metodları vardır
            //BU metodların bazılarını örnekler halinde işleyelim

            Console.Write("Sayılar = ");
            foreach (var item in sayilar)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n\n--------------\n");

            #region Take()
            //Koleksiyon içerisindeki verilerin sadece belirtildiği kadarını listeler

            var tListe = sayilar.Take(5);
            foreach (var item in tListe)
            {
                Console.Write(item + " ");
            }

            #endregion
            Console.WriteLine("\n\n--------------\n");
            #region Sum()
            //Koleksiyon içerisindeki verilerin toplamını alır
            //Sadece sayısal ifadelerde işlem yapar
            //Geriye int veri tipinde değer döndürür
            var toplam = sayilar.Sum(s => s);
            Console.WriteLine("Sayıların Toplamı = "+toplam);
            #endregion
            Console.WriteLine("\n\n--------------\n");
            #region Min()
            //Koleksiyon içerisindeki verilerden en küçük olanını geri döndürür
            //Sadece sayısal veri tiplerinde kullanılır
            //Karşılaştırılan sayısal veri tipi hangi tipte ise o değerde veriyi geri döndürür
            var enKucuk = sayilar.Min(s => s);
            Console.WriteLine("Sayıların En Küçüğü = "+enKucuk);
            #endregion
            Console.WriteLine("\n\n--------------\n");

            #region Max()
            //Koleksiyon içerisindeki verilerden en büyüğünü geri döndürür
            var enBuyuk = sayilar.Max(s => s);
            Console.WriteLine("Sayıların En büyüğü ="+enBuyuk);
            #endregion
            Console.WriteLine("\n\n--------------\n");

            #region Any()
            //Koleksiyon içerisinde sorgulama sonucunda herhangi bir veri var mı yok mu sorgulamasını yapar
            //Any() metodu içerisinde filtreleme işlemleri yapılabilir
            //Geriye bool veritipinde değer döndürür
            var varMi = sayilar.Any(s=>    s>=6800 && s<=7000);
            Console.WriteLine(varMi ? "Değer Var":"Değer Yok"); //if kısa yazımı

            #endregion
            Console.WriteLine("\n\n--------------\n");
            #region First()
            //Koleksiyon içerisinde bulunan değerleri sorgulama sonucunda ilk değerini geriye döndürür
            //Sorgulama sonucunda herhangi bir veri yok ise hata verir
           var first = sayilar.First(s => s >= 500 && s <= 7000);
            Console.WriteLine("İlk sayı "+first);

            #endregion

            #region FirstOrDefault()
            //Sourgulama sonucunda herhangi bir veri yok ise 0 değeri döndürür uygulama hata vermez
            var firstorDef = sayilar.FirstOrDefault(s => s >= 6800&& s <= 7000);
            Console.WriteLine("İlk sayı (firstorDefault)" + firstorDef);
            #endregion
            Console.WriteLine("\n\n--------------\n");
            #region TakeWhile()
            //Koleksiyon içerisindeki verileri TakeWhile metodu içerisindeki koşul doğruluğu sağlayana kadar okuma yapar
            var takeWhile = sayilar.TakeWhile(s => s <= 4000);
            foreach (var item in takeWhile)
            {
                Console.Write(item + " ");
            }
            #endregion
            Console.WriteLine("\n\n--------------\n");

            #region Average()
            //Koleksiyon içerisinde belirtilen property nin ortalamasını alır
            //Geriye double veri tipinde değer döndürür
            var ortalama =sayilar.Average(s => s);
            Console.WriteLine("Sayıların Ortalaması = "+ortalama);
            #endregion
            Console.WriteLine("\n\n--------------\n");

            #region Count()
            //Koleksiyon içerisinde bulunan elemanların toplam sayısını verir
            //Geriye int veri tipinde değer döndürür
            //Count() metodu içerisinde koşula bağlı olarak işlem yapılabilir
            var elemanSayisi = sayilar.Count(s => s<=400);
            Console.WriteLine("400 e eşit ve küçük eleman sayısı = "+elemanSayisi);
            #endregion
            Console.WriteLine("\n\n--------------\n");

            #region ToList()
            //Koleksiyon içerisindeki verileri list yapısına döndürür
            var list=sayilar.Where(s=> s<1000).ToList();

            #endregion
            #region ToArray()
            //Koleksiyon içerisindeki verileri array yapısına döndürür
            var array=sayilar.Where(s=> s<1000).ToArray();
            #endregion

            Console.ReadKey();
        }
    }
}
