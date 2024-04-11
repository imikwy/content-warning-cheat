using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.Rendering;
// own includes
using UnityEngine;
using ownned.ext.Features;

namespace ownned.ext
{
    public class Window : MonoBehaviour
    {
        // Class
        Money money = new Money();
        // ---------- WINDOW VARS -----------
        public Rect windowRect              = new Rect(100, 100, 550, 400); // Window Pos & Size (posx, posy, sizex, sizey)
        public int tab                      = 0;                            // Active Tab Index
        public Color backgroundColor        = Color.grey;                   // Background color
        public bool showMenu                = true;                         // ShowMenu Var | true: menu visible

        public void Start()
        {
            
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Insert))
            {
                showMenu = !showMenu;
            }
        }

        public void OnGUI()
        {
            if (showMenu)
            {
                GUI.backgroundColor = Color.black;
                windowRect = GUI.Window(0, windowRect, new GUI.WindowFunction(RunWindow), "OWNNED.CC");
            }
        }

        public void RunWindow(int windowID) 
        {
            GUILayout.BeginHorizontal();

            // Create toggle buttons for each tab
            GUILayout.BeginVertical(GUILayout.Width(100));
            if (GUILayout.Toggle(tab == 0, "EXPLOITS", "Button", GUILayout.ExpandWidth(true)))
            {
                tab = 0;
            }
            if (GUILayout.Toggle(tab == 1, "STATS", "Button", GUILayout.ExpandWidth(true)))
            {
                tab = 1;
            }
            if (GUILayout.Toggle(tab == 2, "ESP", "Button", GUILayout.ExpandWidth(true)))
            {
                tab = 2;
            }
            if (GUILayout.Toggle(tab == 3, "PLAYER", "Button", GUILayout.ExpandWidth(true)))
            {
                tab = 3;
            }

            GUILayout.EndVertical();

            // Display content for the selected tab

            GUILayout.BeginVertical();


            // Display content for the selected tab
            switch (tab)
            {
                case 0:
                    GUILayout.BeginVertical(GUI.skin.box);
                    {
                        GUILayout.BeginHorizontal();
                        {
                            GUILayout.BeginVertical();
                            {
                                //Linke seite der dunklen box
                                Config.e_infiniteHeal = GUILayout.Toggle(Config.e_infiniteHeal, "Infinite Heal");
                                Config.e_infiniteOxygen = GUILayout.Toggle(Config.e_infiniteOxygen, "Infinite Oxygen");
                                Config.e_infiniteStamina = GUILayout.Toggle(Config.e_infiniteStamina, "Infinite Stamina");
                                Config.e_godMode = GUILayout.Toggle(Config.e_godMode, "God Mod");
                                Config.e_infiniteJump = GUILayout.Toggle(Config.e_infiniteJump, "Infinite Jump");
                                Config.e_ignoreWebs = GUILayout.Toggle(Config.e_ignoreWebs, "Ignore Webs");
                                Config.e_noClip = GUILayout.Toggle(Config.e_noClip, "NoClip"); // Nor working because im busy
                                Config.e_infiniteBatteryEnable = GUILayout.Toggle(Config.e_infiniteBatteryEnable, "Infinite Battery");
                                if (Config.e_infiniteBatteryEnable)
                                {
                                    Config.e_infiniteBatteryFlashlight = GUILayout.Toggle(Config.e_infiniteBatteryFlashlight, "Infinite Flashlight Battery");
                                    Config.e_infiniteBatteryDefib = GUILayout.Toggle(Config.e_infiniteBatteryDefib, "Infinite Defib Battery");
                                    Config.e_infiniteBatteryShockStick = GUILayout.Toggle(Config.e_infiniteBatteryShockStick, "Infinite Shockstick Battery");
                                    Config.e_infiniteBatteryFlare = GUILayout.Toggle(Config.e_infiniteBatteryFlare, "Infinite Flare Battery");
                                    Config.e_infiniteBatteryVideoCamera = GUILayout.Toggle(Config.e_infiniteBatteryVideoCamera, "Infinite Flare Battery");
                                }
                                Config.e_playerControllerSpeedMultiplier = GUILayout.Toggle(Config.e_playerControllerSpeedMultiplier, "Speed Enable");
                                GUILayout.Space(2);
                                GUILayout.Label("Custom Speed: " + Config.f_playerControllerSpeedMultiplier);
                                Config.f_playerControllerSpeedMultiplier = GUILayout.HorizontalSlider(Config.f_playerControllerSpeedMultiplier, 2.3f, 10f);
                            }
                            GUILayout.EndVertical();

                            GUILayout.Space(10);

                            GUILayout.BeginVertical();
                            {
                                //rechte seite der dunklen box
                                Config.e_customFov = GUILayout.Toggle(Config.e_customFov, "FOV Changer");
                                GUILayout.Space(2);
                                GUILayout.Label("Custom FOV: " + Config.f_customFov);
                                Config.f_customFov = GUILayout.HorizontalSlider(Config.f_customFov, 1f, 179f);
                            }
                            GUILayout.EndVertical();
                        }
                        GUILayout.EndHorizontal();
                    }
                    GUILayout.EndVertical();
                    break;
                case 1:
                    // Content for tab 2
                    GUILayout.BeginVertical(GUI.skin.box);
                    {
                        GUILayout.BeginHorizontal();
                        {
                            GUILayout.BeginVertical();
                            {
                                GUILayout.BeginHorizontal();
                                GUILayout.FlexibleSpace();
                                GUILayout.Label("MONEY");
                                GUILayout.FlexibleSpace();
                                GUILayout.EndHorizontal();
                                GUILayout.Label("Custom Value: " + Config.i_addMoney);
                                Config.i_addMoney = (int)GUILayout.HorizontalSlider(Config.i_addMoney, 1f, 1000f);
                                if (GUILayout.Button("Add Money"))
                                {
                                    money.RunAddMoney(Config.i_addMoney);
                                }
                                GUILayout.Space(2);
                            }
                            GUILayout.EndVertical();

                            GUILayout.Space(10);

                            GUILayout.BeginVertical();
                            {

                            }
                            GUILayout.EndVertical();
                        }
                        GUILayout.EndHorizontal();
                    }
                    GUILayout.EndVertical();
                    break;
                case 2:

                    break;
            }

            GUILayout.EndVertical();

            GUILayout.EndHorizontal();
            GUI.DragWindow(); // Allow the user to drag the window around
        }
    }
}
