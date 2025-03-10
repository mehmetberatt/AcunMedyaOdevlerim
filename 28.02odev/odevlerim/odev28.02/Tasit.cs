using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odevlerim.odev28._02;
public class Tasit
{
    public string Marka { get; set; }
    public double YakıtTüketimi { get; set; } // 100 km başına litre
    public double Mesafe { get; set; } // km cinsinden
    public object Brand { get; private set; }

    public Tasit(string marka, double yakıtTüketimi, double mesafe)
    {
        Marka = marka;
        YakıtTüketimi = yakıtTüketimi;
        Mesafe = mesafe;
    }

    public double ToplamYakıtTüketimi()
    {
        return (Mesafe / 100) * YakıtTüketimi;
    }

}
