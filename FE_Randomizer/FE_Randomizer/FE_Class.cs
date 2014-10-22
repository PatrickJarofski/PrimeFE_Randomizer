using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FE_Randomizer

{    // Declare that the struct should be layed out sequentially
    // and without any byte alignment
    [StructLayout(LayoutKind.Sequential, Pack = 1)] 
    public class FE_Class // Classes are 0x54 bytes in length
    {
        byte nameTwo;
        byte nameOne;
        byte descriptionTwo;
        byte descriptionOne;

        public byte classNumber;
        public byte promotion;
        public byte standingSprite;
        public byte walkSpeed;
        public byte portrait;

        byte unknown1;
        byte unknown2;

        public byte baseHP;
        public byte baseStr;
        public byte baseSkl;
        public byte baseSpd;
        public byte baseDef;
        public byte baseRes;

        public byte baseCon;
        public byte baseMov;

        public byte maxHP;
        public byte maxStr;
        public byte maxSkl;
        public byte maxSpd;
        public byte maxDef;
        public byte maxRes;

        public byte maxCon;

        public byte relativePower;

        public byte growthHP;
        public byte growthStr;
        public byte growthSkl;
        public byte growthSpd;
        public byte growthDef;
        public byte growthRes;
        public byte growthLuck;

        public byte promoHP;
        public byte promoStr;
        public byte promoSkl;
        public byte promoSpd;
        public byte promoDef;
        public byte promoRes;

        public byte ability1;
        public byte ability2;
        public byte ability3;
        public byte ability4;

        public byte weaponSword;
        public byte weaponLance;
        public byte weaponAxe;
        public byte weaponBow;
        public byte weaponStaff;
        public byte weaponAnima;
        public byte weaponLight;
        public byte weaponDark;

        uint pointerAnimation;
        uint pointerMoveCost;
        uint pointerMoveCostRain;
        uint pointerMoveCostSnow;

        uint pointerTerrainDef;
        uint pointerTerrainAvo;
        uint pointerTerrainRes;

        uint pointerUnknown;
    }
}
