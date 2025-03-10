using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odevlerim.odev28._02
{
    public class Bmw : Araba
    {
        public override double Yakıt()
        {
            return 80.0;
        }
    }
    public abstract class Araba : IYakıt
    {
        public string Brand { get; set; }
        public abstract double Yakıt();
    }


}
