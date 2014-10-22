using System;
using System.Runtime.InteropServices;

namespace FE_Randomizer
{
    // Declare that the struct should be layed out sequentially
    // and without any byte alignment
    [StructLayout(LayoutKind.Sequential, Pack = 1)] 
    public struct FE_Character
    {
        private byte nameSecondByte;
        private byte nameFirstByte;

        private byte descriptionFirstByte;
        private byte descriptionSecondByte;

        private byte characterNumber;
        public byte FEClass;
        private byte portrait;

        private byte unknown1;

        private byte chibi;
        public byte affinity;

        private byte unknown2;

        public byte baseLevel;
        public byte baseHP;
        public byte baseStr;
        public byte baseSkl;
        public byte baseSpd;
        public byte baseLuck;
        public byte baseDef;
        public byte baseRes;
        public byte baseConBonus;

        public byte weaponLevelSword;
        public byte weaponLevelLance;
        public byte weaponLevelAxe;
        public byte weaponLevelBow;
        public byte weaponLevelStaff;
        public byte weaponLevelAnima;
        public byte weaponLevelLight;
        public byte weaponLevelDark;

        public byte growthHP;
        public byte growthStr;
        public byte growthSkl;
        public byte growthSpd;
        public byte growthDef;
        public byte growthRes;
        public byte growthLuck;

        private byte paletteUnpromo;
        private byte palettePromo;

        private byte battleSpriteUnpromo;
        private byte battleSpritePromo;

        private byte unknown3;

        public byte characterAbility1;
        public byte characterAbility2;
        public byte characterAbility3;
        public byte characterAbility4;

        private byte supportDataPointer4;
        private byte supportDataPointer3;
        private byte supportDataPointer2;
        private byte supportDataPointer1;

        private byte unknown4;
        private byte unknown5;
        private byte unknown6;
        private byte unknown7;
    }
}
