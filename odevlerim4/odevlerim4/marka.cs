using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odevlerim4
{
    public class Marka
    {
        public string Ad { get; set; }
        public string Model { get; set; }

        public Marka(string ad, string model)
        {
            Ad = ad;
            Model = model;
        }
    }
}