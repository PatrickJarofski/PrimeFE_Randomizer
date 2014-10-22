using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FE_Randomizer
{
    public class UnitAndLocation
    {
        public byte[] unitData;
        public int offsetLocation;

        public UnitAndLocation(byte[] data, int location)
        {
            unitData = data;
            offsetLocation = location;
        }
    }
}
