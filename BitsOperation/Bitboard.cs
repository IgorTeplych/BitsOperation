using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsOperation
{
    public static class Bitboard
    {
        public static (int, ulong) KingSteps(int pos)
        {
            ulong inptPos = 1UL << pos;
            ulong walkMask = 0;

            ulong Ka = inptPos & 0xfefefefefefefefe;
            ulong Kh = inptPos & 0x7f7f7f7f7f7f7f7f;

            walkMask = (Ka << 7) | (inptPos << 8) | (Kh << 9) |
                       (Ka >> 1) | (Kh << 1) |
                       (Ka >> 9) | (inptPos >> 8) | (Kh >> 7);

            return (BitsCount(walkMask), walkMask);
        }

        public static (int, ulong) HorseSteps(int pos)
        {
            ulong inptPos = 1UL << pos;

            ulong left1 = 0xfcfcfcfcfcfcfcfc;
            ulong rihgt1 = 0x3f3f3f3f3f3f3f3f;

            ulong left2 = 0xfefefefefefefefe;
            ulong rihgt2 = 0x7f7f7f7f7f7f7f7f;

            ulong l1 = (ulong)((inptPos << 6) & rihgt1);
            ulong l2 = (ulong)((inptPos << 15) & rihgt2);
            ulong l3 = (ulong)((inptPos >> 17) & rihgt2);
            ulong l4 = (ulong)((inptPos >> 10) & rihgt1);

            ulong r1 = (ulong)((inptPos >> 6) & left1);
            ulong r2 = (ulong)((inptPos >> 15) & left2);
            ulong r3 = (ulong)((inptPos << 17) & left2);
            ulong r4 = (ulong)((inptPos << 10) & left1);

            ulong result =
                  r1
                | r3
                | r2
                | r4
                | l1
                | l2
                | l3
                | l4;

            return (BitsCount(result), result);
        }

        public static (int, ulong) TowerSteps(int pos)
        {
            ulong column = 0x101010101010101;
            ulong line = 0xff;

            line = line << ((pos / 8) * 8);
            column = column << (pos % 8);

            ulong mask = line ^ column;

            return (BitsCount(mask), mask);
        }

        public static (int, ulong) ElephantSteps(int pos)
        {
            ulong mask1 = 0x102040810204080;
            int shift = (pos % 8) - (7 - (pos / 8));

            if (shift > 0)
            {
                mask1 = (mask1 << shift) & 0xfefcf8f0e0c08000;
            }
            if(shift < 0)
            {
                mask1 = (mask1 >> Math.Abs(shift)) & 0x103070f1f3f7f;
            }

            ulong mask2 = 0x8040201008040201;
            int shift2 = (pos % 8) - (pos / 8);

            if (shift2 > 0)
            {
                mask2 = (mask2 << shift2) & 0x80c0e0f0f8fcfeUL;
            }
            if(shift2 < 0)
            {
                mask2 = (mask2 >> Math.Abs(shift2)) & 0x7f3f1f0f07030100UL;
            }

            var vr = mask1 ^ mask2;
            return (BitsCount(mask1 ^ mask2), mask1 ^ mask2);
        }

        public static (int, ulong) QueenSteps(int pos)
        {
            ulong mask1 = TowerSteps(pos).Item2;
            ulong mask2 = ElephantSteps(pos).Item2;
            return (BitsCount(mask1 ^ mask2), mask1 ^ mask2);
        }

        public static int BrutalBitsCount(ulong num)
        {
            int countBits = 0;
            while (num > 0)
            {
                if ((num & 1) == 1)
                {
                    countBits++;
                }
                num >>= 1;
            }
            return countBits;
        }

        public static int BitsCount(ulong num)
        {
            int countBits = 0;
            while (num != 0)
            {
                num = (num & (--num));
                if (num >= 0)
                {
                    countBits++;
                }
            }
            return countBits;
        }


    }
}
