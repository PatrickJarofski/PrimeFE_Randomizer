using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FE_Randomizer
{
    public static class CharacterGrowths
    {
        public static void randomizeGrowths(ref List<FE_Character> list, int min, int max)
        {
            FE_Character temp;

            for (int i = 0; i < list.Count; ++i)
            {
                temp = list[i]; // Due to how lists work

                if (max != 255)
                {
                    // if it ain't Unleashed mode   
                    // HP will be between 30 and 90 (Reasonable passes 0, 60)    
                    temp.growthHP = (byte)Math.Round((double)((Utility.RNG.Next(min + 20, max + 30) / 5) * 5));             
                }
                else
                    temp.growthHP = (byte)Math.Round((double)((Utility.RNG.Next(min, max) / 5) * 5));

                // Rounding ensures the growths                              
                // are multiples of 5 
                // The cast as double is to
                // avoid an ambiguity error
                temp.growthStr  = (byte)Math.Round((double)((Utility.RNG.Next(min, max) / 5) * 5));
                temp.growthSkl  = (byte)Math.Round((double)((Utility.RNG.Next(min, max) / 5) * 5));
                temp.growthSpd  = (byte)Math.Round((double)((Utility.RNG.Next(min, max) / 5) * 5));
                temp.growthLuck = (byte)Math.Round((double)((Utility.RNG.Next(min, max) / 5) * 5));
                temp.growthDef  = (byte)Math.Round((double)((Utility.RNG.Next(min, max) / 5) * 5));
                temp.growthRes  = (byte)Math.Round((double)((Utility.RNG.Next(min, max) / 5) * 5));

                list[i] = temp;
            }
        }

        public static void shuffleGrowths(ref List<FE_Character> list)
        {
            FE_Character temp;
            byte[] growths = new byte[7];
            
            for(int i = 0; i < list.Count; ++i)
            {
                temp = list[i];

                growths[0] = temp.growthHP;
                growths[1] = temp.growthStr;
                growths[2] = temp.growthSkl;
                growths[3] = temp.growthSpd;
                growths[4] = temp.growthDef;
                growths[5] = temp.growthRes;
                growths[6] = temp.growthLuck;

                Utility.ShuffleByteArray(ref growths, growths.Length);

                temp.growthHP   = growths[0];
                temp.growthStr  = growths[1];
                temp.growthSkl  = growths[2];
                temp.growthSpd  = growths[3];
                temp.growthDef  = growths[4];
                temp.growthRes  = growths[5];
                temp.growthLuck = growths[6];

                list[i] = temp;
            }
        }





    }
}
