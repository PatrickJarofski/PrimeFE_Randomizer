using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FE_Randomizer
{
    public static class UnitData
    {
        private static List<byte[]> units = new List<byte[]>();
        private static string[] offsets;

        public static void RandomUnits(string filePath, string unitOffsetsPath)
        {
            char[] delimiters = { ' ', '\r', '\n' };
            string path = unitOffsetsPath;
            offsets = path.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            ReadUnits(filePath);
            
        }

        private static void ReadUnits(string filePath)
        {            
            BinaryReader reader = new BinaryReader(File.OpenRead(filePath));
            BinaryWriter writer;
            List<UnitAndLocation> unitGroups = new List<UnitAndLocation>();
            
            for(int i = 0; i < offsets.Length; i += 2)
            {
	            int start = int.Parse(offsets[i], NumberStyles.HexNumber);
	            int end = int.Parse(offsets[i+1], NumberStyles.HexNumber);

	            reader.BaseStream.Position = start; 

	            do
	            {
		            byte[] currentUnit = new byte[16];
		            reader.Read(currentUnit, 0, 16);		
		
		            if(currentUnit[0] != 0x00) // Don't edit separators
                    {                      
			            randomizeUnit(currentUnit);
                        UnitAndLocation temp = new UnitAndLocation(currentUnit, Convert.ToInt32(reader.BaseStream.Position - 16));
			            unitGroups.Add(temp);
		            }
	            }
	            while(reader.BaseStream.Position < end);
            }
            reader.Close();

            // ================= Write units to ROM =================
            writer = new BinaryWriter(File.OpenWrite(filePath));

           foreach(UnitAndLocation unit in unitGroups)
            {
                writer.BaseStream.Position = unit.offsetLocation;
                writer.Write(unit.unitData);
            }
            writer.Close();           
        }
        

        private static void randomizeUnit( byte[] unit)
        {
            byte newClass = 0x01;

            bool done = false;
            while(!done)
            {
                newClass = (byte)Utility.RNG.Next(0x01, 0x43);

                if(isValidClass(newClass))
                    done = true;
            }

            unit[1] = newClass;
        }

        private static bool isValidClass(byte feClass)
        {
            if(feClass == 0x04 || feClass == 0x05 || feClass == 0x06 || feClass == 0x0B || feClass == 0x3F)
                return false;

            else
                return true;
        }

    }
}
