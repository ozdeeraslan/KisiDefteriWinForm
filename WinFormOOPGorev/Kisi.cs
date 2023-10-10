using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormOOPGorev
{
    public class Kisi
    {
        public string Ad { get; set; } = "";
        public string Soyad { get; set; } = "";

        public string TamAd => $"{Ad} {Soyad}"; // read-only, 2.yöntem

        public override string ToString()
        {
            return $"Kisi ({Ad} {Soyad})";
        }


    }
}
