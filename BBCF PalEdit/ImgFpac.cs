using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBCF_PalEdit
{
    class ImgFpac
    {
        public List<Anim> anims;

        public ImgFpac(int size, List<int> hipSize, List<byte> imgpac)
        {
            int hipCount = (size - 0x20) / 0x30;
        }

        /*public int size;
        public int hpalSize;
        public List<Palette> palettes;
        public List<Hpal> hpals;
        private List<Thread> threads;

        public PalFpac(int size, int hpalSize, List<byte> palpac)
        {
            this.size = size;
            this.hpalSize = hpalSize;
            int hpalCount = size / 0x20 - 1;
            byte[] palpacB = palpac.ToArray();
            palettes = new List<Palette>(Int32.Parse(Encoding.ASCII.GetString(palpacB, hpalCount * 0x20 + 0x02, 0x02)) + 1);

            int[] hpalSubA = new int[hpalCount];
            int[] hpalSubB = new int[hpalCount];
            for (int i = 0; i < hpalCount; i++)
            {
                hpalSubA[i] = Int32.Parse(Encoding.ASCII.GetString(palpacB, 0x20 + (i * 0x20) + 0x02, 0x02));
                hpalSubB[i] = Int32.Parse(Encoding.ASCII.GetString(palpacB, 0x20 + (i * 0x20) + 0x05, 0x02));
            }

            int[] hpalSubC = new int[palettes.Capacity];
            for (int i = 0; i < hpalCount; i++)
            {
                hpalSubC[Int32.Parse(Encoding.ASCII.GetString(palpacB, 0x20 + (i * 0x20) + 0x02, 0x02))]++;
            }

            hpals = new List<Hpal>(hpalCount);
            threads = new List<Thread>(hpalCount);

            for (int i = 0; i < palettes.Capacity; i++)
            {
                palettes.Add(new Palette(hpalSubC[i]));
            }

            for (int i = 0; i < hpalCount; i++)
            {
                palettes[Int32.Parse(Encoding.ASCII.GetString(palpacB, 0x20 + (i * 0x20) + 0x02, 0x02))]
                    .subs.Add(new Hpal(palpac.Skip(size + (hpalSize * i)).Take(hpalSize).ToList()));
            }
        }*/
    }
}
