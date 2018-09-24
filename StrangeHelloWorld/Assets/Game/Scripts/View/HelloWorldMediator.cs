using System;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace Game
{
    public class HelloWorldMediator : Mediator
    {
        [Inject]
        public HelloWorldView view { get; set; }

        [Inject]
        public ISomeManager manager { get; set; }

        public override void OnRegister()
        {
            view.buttonClicked.AddListener(delegate () {
                manager.DoManagement();
            });
        }
    }
}