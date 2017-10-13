using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BBCF_PalEdit
{
    class PalFpac
    {
        public List<Palette> palettes;

        public PalFpac(int size, int hpalSize, List<byte> palpac)
        {
            int hpalCount = (size - 0x20) / 0x20;
            byte[] palpacB = palpac.ToArray();
            palettes = new List<Palette>(Int32.Parse(Encoding.ASCII.GetString(palpacB, hpalCount * 0x20 + 0x02, 0x02)) + 1);

            int[] hpalSub = new int[palettes.Capacity];
            for (int i = 0; i < hpalCount; i++)
            {
                hpalSub[Int32.Parse(Encoding.ASCII.GetString(palpacB, 0x20 + (i * 0x20) + 0x02, 0x02))]++;
            }

            for (int i = 0; i < palettes.Capacity; i++)
            {
                palettes.Add(new Palette(hpalSub[i]));
            }

            for (int i = 0; i < hpalCount; i++)
            {
                palettes[Int32.Parse(Encoding.ASCII.GetString(palpacB, 0x20 + (i * 0x20) + 0x02, 0x02))]
                    .subs.Add(new Hpal(palpac.Skip(size + (hpalSize * i)).Take(hpalSize).ToList()));
            }
        }
    }
}
