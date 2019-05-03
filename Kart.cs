using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Kart
    {
        
        public int ID { get; set; }



        


        public string renk { get; set; }
        public int kartno { get; set; }
        public bool AcikMi { get; set; }
        public bool YerlestiMi { get; set; }
        public string tur;

        public string GetResimYol()
        {
            return AcikMi ? @"C:\kartlar\" + tur + this.kartno + ".png" : @"C:\kartlar\kapali.png";
            //maca1,maca2..maca13
        }
    }
}
        
        //kartları karşılaştıralım
      
