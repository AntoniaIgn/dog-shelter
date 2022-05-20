using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dogShelter
{
    public class Spitz : Dog
    {
        /*readonly FurLengthOptions FurLength = FurLengthOptions.Long;*/

        public override double Feed(double kg)
        {
            return kg*5*2.2;
        }
    }
}
