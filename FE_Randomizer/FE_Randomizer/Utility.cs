using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FE_Randomizer;
using System.Runtime.InteropServices;
using System.IO;

namespace FE_Randomizer
{
    public static class Utility
    {
        // So that there's only 1
        // Random object being used
        // instead of making them
        // all over the place
        public static readonly Random RNG = new Random();
        

        public static byte[] ConvertTypeToBytes<T>(T obj)
        {
            int length = Marshal.SizeOf(obj);
            byte[] bytes = new byte[length];

            IntPtr ptr = Marshal.AllocHGlobal(length);

            Marshal.StructureToPtr(obj, ptr, true);
            Marshal.Copy(ptr, bytes, 0, length);
            Marshal.FreeHGlobal(ptr);

            return bytes;
        }

        public static T convertBytesToType<T>(byte[] bytes)
        {
            GCHandle handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            T returnObj = (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
            handle.Free();

            return returnObj;
        }


        public static void DisableTutorials(string filepath)
        {
            BinaryWriter writer = new BinaryWriter(File.OpenWrite(filepath));
            writer.BaseStream.Position += 0xC9EA2C; // Where FE7 tutorial pointer array is

            for(int i = 0; i < 176; i += 4)
            {
                writer.Write(0x080000B4);                
            }
            writer.Close();
        }

        public static void ShuffleByteArray(ref byte[] array, int arrLength)
        {
            int n = arrLength;
            int k;
            byte temp;

            while (n > 1)
            {
                --n;
                k = RNG.Next(n + 1);
                temp = array[k];
                array[k] = array[n];
                array[n] = temp;
            }
        }

        public static bool IsPromotedClass(ref FE_Class obj) 
        {
            switch(obj.ability2)
            {   // If ground promo, horse promo, wyvern promo, or pegasus promo
                case (0x01):
                case (0x05):
                case (0x09):
                case (0x11):
                    return true;
                default:
                    return false;
            }
        }
      




    }
}
