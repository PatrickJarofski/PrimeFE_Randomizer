using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FE_Randomizer
{
    public static class CharacterBaseStats
    {
        public static void RandomizeStats(ref List<FE_Character> list, int min, int max)
        {
            FE_Character temp;

            for (int i = 0; i < list.Count; ++i)
            {
                temp = list[i]; // Due to how lists work

                temp.baseHP   = (byte)Utility.RNG.Next(min, max);
                temp.baseStr  = (byte)Utility.RNG.Next(min, max);
                temp.baseSkl  = (byte)Utility.RNG.Next(min, max);
                temp.baseSpd  = (byte)Utility.RNG.Next(min, max);
                temp.baseLuck = (byte)Utility.RNG.Next(min, max);
                temp.baseDef  = (byte)Utility.RNG.Next(min, max);
                temp.baseRes  = (byte)Utility.RNG.Next(min, max);

                list[i] = temp;
            }
        }


        public static void ShuffleBaseStats(ref List<FE_Character> list)
        {
            FE_Character temp;
            byte[] baseStats = new byte[7];

            for (int i = 0; i < list.Count; ++i)
            {
                temp = list[i];
                baseStats[0] = temp.baseHP;
                baseStats[1] = temp.baseStr;
                baseStats[2] = temp.baseSkl;
                baseStats[3] = temp.baseSpd;
                baseStats[4] = temp.baseDef;
                baseStats[5] = temp.baseRes;
                baseStats[6] = temp.baseLuck;

                Utility.ShuffleByteArray(ref baseStats, baseStats.Length);

                temp.baseHP = baseStats[0];
                temp.baseStr = baseStats[1];
                temp.baseSkl = baseStats[2];
                temp.baseSpd = baseStats[3];
                temp.baseDef = baseStats[4];
                temp.baseRes = baseStats[5];
                temp.baseLuck = baseStats[6];

                list[i] = temp;
            }
        }

    }
}
