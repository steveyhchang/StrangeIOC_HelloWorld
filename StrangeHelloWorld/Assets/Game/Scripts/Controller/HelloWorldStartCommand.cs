using System;

using UnityEngine;

using strange.extensions.context.api;
using strange.extensions.command.impl;

namespace Game
{
    public class HelloWorldStartCommand : Command
    {
        public override void Execute()
        {
            // perform all game start setup here
            Debug.Log("Hello World");
        }
    }
}