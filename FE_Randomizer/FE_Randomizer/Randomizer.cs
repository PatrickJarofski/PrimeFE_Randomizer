using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FE_Randomizer
{
    public class Randomizer
    {
        const int CHARACTER_SIZE = 52; // How many bytes a FE character is
        const int CLASS_SIZE = 84;     // How many bytes a FE class is
        const int ITEM_SIZE = 36;      // How many bytes a FE item is

        private string _romPath;
        private string romType;

        private List<FE_Character> characterList;
        private List<FE_Class> classList;
        private List<FE_Item> itemList;        
       

        public Randomizer(string path)
        {
            _romPath = path;
            romType = "FE7";

            if(characterList != null)            
                characterList.Clear();            
            
            characterList = new List<FE_Character>();
            classList = new List<FE_Class>();
            itemList = new List<FE_Item>();
            
            fillListOfType<FE_Character>(ref characterList, getCharacterArrayStart(), CHARACTER_SIZE, getCharacterArraySize());
            fillListOfType<FE_Class>(ref classList, getClassArrayStart(), CLASS_SIZE, getClassArraySize());
            fillListOfType<FE_Item>(ref itemList, getItemArrayStart(), ITEM_SIZE, getItemArraySize());
        }
        
        public void saveChanges()
        {
            Utility.DisableTutorials(_romPath);
            writeListOfType<FE_Character>(ref characterList, getCharacterArrayStart(), CHARACTER_SIZE, getCharacterArraySize());
            writeListOfType<FE_Class>(ref classList, getClassArrayStart(), CLASS_SIZE, getClassArraySize());
            writeListOfType<FE_Item>(ref itemList, getItemArrayStart(), ITEM_SIZE, getItemArraySize());
        }



        public void RandomizeCharacterGrowths(int min, int max)
        {
            CharacterGrowths.randomizeGrowths(ref characterList, min, max);
        }


        public void ShuffleCharacterGrowths()
        {
            CharacterGrowths.shuffleGrowths(ref characterList);
        }


        public void RandomizeCharacterStats(int min, int max)
        {
            CharacterBaseStats.RandomizeStats(ref characterList, min, max);
        }


        public void ShuffleCharacterBaseStats()
        {
            CharacterBaseStats.ShuffleBaseStats(ref characterList);
        }


        public void ShuffleStatCaps()
        {
            ClassStatCaps.ShuffleClassCaps(ref classList);
        }
        

        public void RandomizeClassStatCaps(int min, int max, bool promoFlag)
        {
            ClassStatCaps.RandomizeClassStatCaps(ref classList, min, max, promoFlag);
        }


        public void RandomItemStats(bool might, bool crit)
        {
            ItemStats.RandomItemStats(ref itemList, might, crit);
        }


       public void RandomizeUnitData(string UnitOffsetsFilePath)
        {
            UnitData.RandomUnits(_romPath, UnitOffsetsFilePath);
        }


        #region Description of fillListOfType<T>
        /// <summary>
        /// Fills the list with the specified
        /// type of structure, read from the ROM
        /// Example: getListOfType<FE_Character>()
        /// and passing the appropriate params will
        /// result in the characterList getting filled
        /// with every character index from the ROM
        /// </summary>
        /// 
        /// <typeparam name="T">Object type to work with</typeparam>
        /// 
        /// <param name="list">The list to add to</param>
        /// 
        /// <param name="ROMstartPosition">Where the Binary Reader will
        /// begin reading from (Ex: start of class array)</param>
        /// 
        /// <param name="objectSize">The size of the structure 
        /// being worked with</param>
        /// 
        /// <param name="numOfIndices">How many entries are in the 
        /// array being worked with</param>
        #endregion
        private void fillListOfType<T>(ref List<T> list, int ROMstartPosition, int objectSize, int numOfIndices)
        {
            /// TODO - Strictly PC randomization
            ///      - Strictly Enemy/NPC randomization

            byte[] bytes = new byte[objectSize];
            T temp;

            BinaryReader reader = new BinaryReader(File.OpenRead(_romPath));
            reader.BaseStream.Position += ROMstartPosition;

            for (int i = 0; i < numOfIndices; ++i)
            {
                reader.Read(bytes, 0, objectSize);
                temp = Utility.convertBytesToType<T>(bytes);

                list.Add(temp);
            }

            reader.Close();

        }
        
        

        // Description for this similar to fillListOfType<T>
        // except now we're writing to the ROM
        private void writeListOfType<T>(ref List<T>list, int ROMStartPosition, int objectSize, int numIndices)
        {
            if (_romPath == string.Empty || _romPath == null)
            {
                throw new NullReferenceException("No ROM currently loaded.");
            }

            BinaryWriter writer = new BinaryWriter(File.OpenWrite(_romPath));
            byte[] byteArray = new byte[objectSize];

            writer.BaseStream.Position += ROMStartPosition;

            foreach (T item in list)
            {
                byteArray = Utility.ConvertTypeToBytes<T>(item);

                for (int i = 0; i < objectSize; ++i)
                {
                    writer.Write(byteArray[i]);
                }
            }

            writer.Close();
        }   

        

        private int getCharacterArrayStart()
        {
            // TODO - game based switch

            return ROMData.FE7_CharacterData;
        }


        private int getCharacterArraySize()
        {
            // TODO - game based switch

            return ROMData.FE7_NumCharacters;
        }


        private int getClassArrayStart()
        {
            // TODO - game based switch

            return ROMData.FE7_ClassData;
        }


        private int getClassArraySize()
        {
            // TODO - game based switch

            return ROMData.FE7_NumClasses;
        }
        

        private int getItemArrayStart()
        {
            // TODO - game based switch

            return ROMData.FE7_ItemData;
        }


        private int getItemArraySize()
        {
            // TODO - game based switch

            return ROMData.FE7_NumItems;
        }


    }
}
