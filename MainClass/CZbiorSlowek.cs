using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClass
{
    public class CZbiorSlowek
    {
        public int SlowoId;
        public string Slowo;
        public string Znaczenie;

        public CZbiorSlowek(int sSlowoId, string sSlowo, string sZnaczenie)
        {
            SlowoId = sSlowoId;
            Slowo = sSlowo;
            Znaczenie = sZnaczenie;
        }

    }
}
