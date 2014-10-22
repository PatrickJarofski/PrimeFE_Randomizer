using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FE_Randomizer
{
    public static class Weapons
    {
        public static byte sword = 0x00;
        public static byte lance = 0x01;
        public static byte axe = 0x02;
        public static byte bow = 0x03;
        public static byte staff = 0x04;
        public static byte anima = 0x05;
        public static byte light = 0x06;
        public static byte dark = 0x07;
        public static byte item = 0x09;

        public static byte rankNone = 0x00;
        public static byte rankE = 0x01;
        public static byte rankD = 0x1F;
        public static byte rankC = 0x47;
        public static byte rankB = 0x79;
        public static byte rankA = 0xB5;
        public static byte rankS = 0xFB;
    }
}
