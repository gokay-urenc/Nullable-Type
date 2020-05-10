using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NullableType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // null = yok 
            // int sayi = null;
            // bool durum = null;

            // 1. yol 
            Nullable<int> sayi = null;
            Nullable<bool> durum = null;

            //2. yol 
            int? sayi1 = 8;
            bool? durum1 = null;

            int a = sayi1 ?? 2;
            if (sayi1.HasValue)
            {
                int sayi2 = sayi1.Value;
            }

            Urun urn = new Urun();
            urn.Adi = "Çay";
            urn.Stok = 4;

            Urun urn1 = new Urun();
            urn1.Adi = "Su";
        }
    }
}
// C# dilinde sadece referans tipler null olabilir. 
// Value tipler değer sakladıkları için null olamazlar. 
// Bir value tipin null olması istenirse nullable type devreye girer. 
// Bir nullable değişkenin içinde değer olup olmadığı HasValue ile öğrenilir.
// HasValue: Bool değer döner.
// Value: Tutulan değeri verir. 
// ?? Operatörü: Eğer soldaki değişken null ise atanacak diğer değişkene bu değişkenin değeri yerine ?? operatörünün sağında kalan atanır.