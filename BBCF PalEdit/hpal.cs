using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBCF_PalEdit
{
    class Hpal
    {
        public List<byte> header;
        public List<byte> colorData;

        public Hpal(List<byte> data)
        {
            header = data.Take(32).ToList();
            colorData = data.Skip(32).Take(data.Count - 32).ToList();
        }
    }
}
