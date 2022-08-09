using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTL_Trainer
{
    internal class Offsets
    {
        public const int iPlayerData = 0x51348C;
        public const int iReactor = 0x51AB20;

        //iPlayerData -->
        public const int iPlayerHP = 0xCC;
        public const int iScrap = 0x4D4;
        public const int iFuel = 0x494;        
        public const int iMissilePointer = 0x48;
        public const int iDronePointerShip1 = 0x800;
        public const int iDronePointer1Ship2 = 0x4C;

        //iMissilePointer -->
        public const int iMissilePointer2 = 0x1E8;

        //iDronePointer1Ship2 -->
        public const int iDronePointer2Ship2 = 0x1CC;

        //iReactor -->
        public const int iEnergy = 0x04;

    }
}
