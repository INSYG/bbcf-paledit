using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBCF_PalEdit
{
    class Anim
    {
        public List<Frame> frames;

        public Anim(int size)
        {
            frames = new List<Frame>(size);
        }
    }
}
