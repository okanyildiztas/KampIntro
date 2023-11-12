using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string urunAdi = "Elma";
            double fiyat = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };
            */

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Urunaciklamasi = "Amasya Elması";


            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 50;
            product2.Urunaciklamasi = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Adi + " Fiyatı: " + product.Fiyati);
            }


            Console.WriteLine("-----------------Metotlar-----------------------");

            // instance - örnek
            // encapsulation - kapsülleme - ayrı ayrı yazacağın, düzensiz yapıyı bir düzenin kapsülün içine alma olayı

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 45, 20);
            sepetManager.Ekle2("Elma", "Amasya Elması", 27, 15);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 80, 25);
        }
    }
}
