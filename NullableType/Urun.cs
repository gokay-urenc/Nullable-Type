using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableType
{
    public class Urun
    {
        public Urun()
        {
            Adi = null;
            Stok = null;
            Onaylimi = null;
        }

        public string Adi { get; set; }
        public Nullable<int> Stok { get; set; }
        public Nullable<bool> Onaylimi { get; set; }
        public Nullable<decimal> Fiyat { get; set; }
    }
}