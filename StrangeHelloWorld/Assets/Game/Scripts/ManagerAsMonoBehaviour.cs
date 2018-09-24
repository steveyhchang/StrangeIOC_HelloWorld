using System;
using UnityEngine;

namespace Game
{
    public class ManagerAsMonoBehaviour : MonoBehaviour, ISomeManager
    {
        #region ISomeManager implementation
        public void DoManagement()
        {
            Debug.Log("Manager implemented as MonoBehaviour");
        }
        #endregion
    }
}