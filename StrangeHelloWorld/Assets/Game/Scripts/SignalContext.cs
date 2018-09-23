using System;
using UnityEngine;
using strange.extensions.context.impl;
using strange.extensions.command.api;
using strange.extensions.command.impl;
using strange.extensions.signal.impl;

namespace Game
{
    public class SignalContext : MVCSContext
    {
        public SignalContext(MonoBehaviour contextView) : base(contextView)
        {
            
        }

        // To use signals, we need to replace the default commandBinder with the SignalCommandBinder
        protected override void addCoreComponents()
        {
            base.addCoreComponents();
            injectionBinder.Unbind<ICommandBinder>();
            injectionBinder.Bind<ICommandBinder>().To<SignalCommandBinder>().ToSingleton();
        }

        public override void Launch()
        {
            base.Launch();
            Signal startSignal = injectionBinder.GetInstance<StartSignal>();
            startSignal.Dispatch();
        }
    }
}