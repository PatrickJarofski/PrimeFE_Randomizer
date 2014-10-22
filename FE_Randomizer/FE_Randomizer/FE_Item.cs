using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FE_Randomizer
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)] 
    public class FE_Item
    {
        UInt16 name;
        UInt16 description;
        UInt16 useDescription;

        byte itemNum;
        public byte weaponType;

        public byte ability1;
        public byte ability2;
        public byte ability3;
        public byte ability4;

        public uint pointerStatBonus;
        public uint pointerEffectiveness;

        public byte durability;
        public byte might;
        public byte hit;
        public byte weight;
        public byte crit;

        byte range;

        public UInt16 costPerUse;      

        byte rank;
        byte icon;
        byte useEffect;

        public byte weaponEffect;
        public byte experience;

        byte unknown1;
        byte unknown2;
        byte unknown3;
    }
}
