using Manager;
using Service;
using UnityEngine;
using VContainer;
using VContainer.Unity;
using View;

namespace Scope
{
    public class GameLifetimeScope : LifetimeScope
    {
        [SerializeField] private LogView logView;
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<LogService>(Lifetime.Singleton);
            builder.RegisterEntryPoint<LogManager>();
            builder.RegisterComponent(logView);
        }
    }
}