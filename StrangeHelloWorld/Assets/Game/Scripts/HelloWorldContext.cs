using System;
using UnityEngine;
using strange.extensions.context.impl;

namespace Game
{
    public class HelloWorldContext : SignalContext
    {
        public HelloWorldContext(MonoBehaviour contextView) : base(contextView)
        {
            
        }

        protected override void mapBindings()
        {
            base.mapBindings();
            // we bind a command to StartSignal since it is invoked by SignalContext (the parent class) on Launch()
            commandBinder.Bind<StartSignal>().To<HelloWorldStartCommand>().Once();
        }
    }

}