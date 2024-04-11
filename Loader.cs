// Some standard includes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
// own includes
using UnityEngine;

namespace ownned.ext
{
    public class Loader : MonoBehaviour
    {
        private static GameObject cheat;

        public static void Load()
        {
            cheat = new GameObject();
            cheat.AddComponent<Cheat>();
            cheat.AddComponent<Window>();

            GameObject.DontDestroyOnLoad(cheat);
        }

        public static void Unload()
        {
            GameObject.Destroy(cheat);
            Loader.cheat = null;
        }
    }
}
