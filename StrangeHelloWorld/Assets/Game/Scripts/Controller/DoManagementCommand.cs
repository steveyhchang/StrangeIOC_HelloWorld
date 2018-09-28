using System;
using UnityEngine;
using strange.extensions.context.api;
using strange.extensions.command.impl;

namespace Game
{
    public class DoManagementCommand : Command
    {
        [Inject]
        public ISomeManager manager { get; set; }

        public override void Execute()
        {
            manager.DoManagement();
        }
    }
}