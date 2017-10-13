using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBCF_PalEdit
{
    class Palette
    {
        public List<Hpal> subs;

        public Palette(int size)
        {
            subs = new List<Hpal>(size);
        }
    }
}
