﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeBerlin.Data
{
    public class Siparis
    {
        public int MasaNo { get; set; }

        public SiparisDurum Durum { get; set; }

        public decimal OdenenTutar { get; set; }

        public DateTime? AcilisZamani { get; set; }

        public DateTime? KapanisZamani { get; set; }

        public List<SiparisDetay> SiparisDetaylar { get; set; }

        public string ToplamTutarTL { get;  }
        public string ToplamTutar2TL { get;  }

        public decimal ToplamTutar()
        {
            return 0;
        }
    }
}
