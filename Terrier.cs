using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dogShelter
{
    public class Terrier : Dog
    {
        public override double Feed(double kg)
        {
            return (kg*10*2.7)/3;
        }
    }
}
