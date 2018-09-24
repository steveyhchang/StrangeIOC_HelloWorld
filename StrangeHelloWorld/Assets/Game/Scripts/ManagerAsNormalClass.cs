using System;
using UnityEngine;

namespace Game
{
    public class ManagerAsNormalClass : ISomeManager
    {
        public ManagerAsNormalClass()
        {

        }

        #region ISomeManager implementation
        public void DoManagement()
        {
            Debug.Log("Manager implemented as a normal class");
        }
        #endregion
    }

}