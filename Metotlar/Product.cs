using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class Product
    {
        //Property =  özellik(ürünün özelliği)
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Urunaciklamasi { get; set; }
        public int StokAdedi { get; set; }
    }
}
