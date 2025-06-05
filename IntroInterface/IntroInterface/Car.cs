using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroInterface
{
    internal class Car : ITransportation
    {
        public string Brand { get; set; }
        public string RegNumber { get; set; }
        public void Drive()
        {
            //press pedal
        }
    }
}
