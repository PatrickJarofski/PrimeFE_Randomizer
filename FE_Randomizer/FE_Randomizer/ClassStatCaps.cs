using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FE_Randomizer
{
    public static class ClassStatCaps
    {
        public static void ShuffleClassCaps(ref List<FE_Class> list)
        {
            FE_Class temp;
            byte[] caps = new byte[5];

            for (int i = 1; i < list.Count; ++i)
            {
                temp = list[i];
                caps[0] = temp.maxStr;
                caps[1] = temp.maxSkl;
                caps[2] = temp.maxSpd;
                caps[3] = temp.maxDef;
                caps[4] = temp.maxRes;

                Utility.ShuffleByteArray(ref caps, caps.Length);

                temp.maxStr = caps[0];
                temp.maxSkl = caps[1];
                temp.maxSpd = caps[2];
                temp.maxDef = caps[3];
                temp.maxRes = caps[4];

                list[i] = temp;
            }
        }


        public static void RandomizeClassStatCaps(ref List<FE_Class> list, int min, int max, bool isPromoBetter)
        {
            FE_Class temp;
            FE_Class unpromo;

            for(int i = 1; i < list.Count; ++i)
            {
                temp = list[i]; // Due to how lists work

                if (isPromoBetter)
                {
                    if (Utility.IsPromotedClass(ref temp))
                    {
                        unpromo = list[temp.promotion];

                        temp.maxHP  = (byte)Utility.RNG.Next(unpromo.maxHP, max + 30);
                        temp.maxStr = (byte)Utility.RNG.Next(unpromo.maxStr, max);
                        temp.maxSkl = (byte)Utility.RNG.Next(unpromo.maxSkl, max);
                        temp.maxSpd = (byte)Utility.RNG.Next(unpromo.maxSpd, max);
                        temp.maxDef = (byte)Utility.RNG.Next(unpromo.maxDef, max);
                        temp.maxRes = (byte)Utility.RNG.Next(unpromo.maxRes, max);                        
                    }

                    else // Unpromoted class
                        RandomCaps(ref temp, min, max);
                }

                else 
                    RandomCaps(ref temp, min, max);
    

                list[i] = temp;

            }
        }

        private static void RandomCaps(ref FE_Class obj, int min, int max)
        {
            obj.maxHP  = (byte)Utility.RNG.Next(min + 20, max + 30);
            obj.maxStr = (byte)Utility.RNG.Next(min, max);
            obj.maxSkl = (byte)Utility.RNG.Next(min, max);
            obj.maxSpd = (byte)Utility.RNG.Next(min, max);
            obj.maxDef = (byte)Utility.RNG.Next(min, max);
            obj.maxRes = (byte)Utility.RNG.Next(min, max);
        }
    }
}
