using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4
{
    internal class DauSi : BinhLinh
    {
        protected override double TinhSucManh() => TrangBi ? sm *= 1.7 : sm;
    }
}
