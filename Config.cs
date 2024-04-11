using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// own includes
using UnityEngine;

namespace ownned.ext
{
    public class Config : MonoBehaviour
    {
        // ---------- EXPLENATIONS -----------

        /*
         * e - enable
         * f - float
         * i - int
        */

        // ---------- CHEAT VARS -----------


        //Player Controller
        public static bool e_playerControllerSpeedMultiplier = false;
        public static float f_playerControllerSpeedMultiplier = 2.3f;

        // Infinite Player Shit
        public static bool e_infiniteJump = false;
        public static bool e_infiniteHeal = false;
        public static bool e_infiniteOxygen = false;
        public static bool e_infiniteStamina = false;
        public static bool e_godMode = false;

        // Battery Object stuff
        public static bool e_infiniteBatteryEnable = false; // Maybe use for dropdown menu in window shit
        public static bool e_infiniteBatteryFlashlight = false;
        public static bool e_infiniteBatteryDefib = false;
        public static bool e_infiniteBatteryShockStick = false;
        public static bool e_infiniteBatteryFlare = false;
        public static bool e_infiniteBatteryVideoCamera = false;

        //Custom  FOV
        public static bool e_customFov = false;
        public static float f_customFov = 60f;

        // Money stuff
        public static int i_addMoney = 0;
        public static int i_removeMoney = 0;

        // Free cam
        public static bool e_freecam = false;

        // ignore web
        public static bool e_ignoreWebs = false;

        //Noclip
        public static bool e_noClip = false;


        // I will add it later, for creating configs to share with others
        // but idc right now lol
        public void LoadConfigs()
        {

        }

        public void SaveConfigs() 
        { 

        }
    }
}
