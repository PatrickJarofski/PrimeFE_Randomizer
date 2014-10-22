using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FE_Randomizer
{
    public static class ItemStats
    {
        private static byte[] mightValues = new byte[50];
        private static byte[] critValues = new byte[12];

        public static void RandomItemStats(ref List<FE_Item> list, bool mightFlag, bool critFlag)
        {
            FE_Item temp;

            if (mightFlag)
                prepareMightValues();

            if (critFlag)
                prepareCritValues();

            for (int i = 1; i < list.Count; ++i)
            {
                temp = list[i];

                if (temp.weaponType == Weapons.item) 
                    continue;

                if (mightFlag)
                    controlledMight(ref temp);
                else
                    temp.might = (byte)Utility.RNG.Next(1, 26);

                temp.hit = (byte)Math.Round((double)((Utility.RNG.Next(50, 101) / 5) * 5));
                temp.durability = (byte)Utility.RNG.Next(10, 51);            

                if (critFlag)
                    controlledCrit(ref temp);

                else
                    temp.crit = (byte)Utility.RNG.Next(0, 31);

                list[i] = temp;
            }
        }

        
        private static void prepareMightValues()
        {
            for(int i = 0; i < mightValues.Length; i += 2)
            {
                mightValues[i] = (byte)(i % 26);
                mightValues[i + 1] = (byte)Utility.RNG.Next(5, 12);
            }

            // Manually adjust some values
            mightValues[26] = (byte)10;
            mightValues[48] = (byte)25;           
        }

        private static void prepareCritValues()
        {
            // Essentially, 1/3 of possible
            // crit values are non-zero
            critValues[2] = 5;
            critValues[5] = 10;
            critValues[8] = 15;
            critValues[11] = 30;
        }


        private static void controlledMight(ref FE_Item item)
        {
            item.might = mightValues[Utility.RNG.Next(0, mightValues.Length)];
        }

        private static void controlledCrit(ref FE_Item item)
        {
            item.crit = critValues[Utility.RNG.Next(0, critValues.Length)];
        }
    }
}
