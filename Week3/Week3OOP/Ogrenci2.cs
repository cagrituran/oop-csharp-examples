using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3OOP
{
    public class Ogrenci2
    {
        private int ogrencino;
        private string adi;
        private string soyadi;
        private char cinsiyet;
        private string bolumu;
        private DateTime dogumtarihi;
        private string adres;

        public int OgrenciNo
        {
            set
            {
                this.ogrencino = value;
            }
            get
            {
                return this.ogrencino;
            }
        }
    }
}
