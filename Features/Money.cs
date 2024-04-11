using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ownned.ext.Features
{
    public class Money : MonoBehaviour
    {
        public void RunAddMoney(int money)
        {
            RoomStatsHolder roomStatsHolder = SurfaceNetworkHandler.RoomStats;
            roomStatsHolder.AddMoney(Config.i_addMoney);
        }

        public void RemoveMoney(int money)
        {

        }
    }
}
