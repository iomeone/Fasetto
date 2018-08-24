﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;

namespace Fasetto.Word.Core
{
    public static class Container
    {
        public static UnityContainer container { get; private set; }
        public static IUIManager UI => Container.Get<IUIManager>();

        public static T Get<T>()
        {
            return container.Resolve<T>();
        }

        public static void Setup()
        {
            container = new UnityContainer();
            RegisterViewModels();
        }

        private static void RegisterViewModels()
        {
            // singleton vms
            container.RegisterType<ApplicationViewModel>(new ContainerControlledLifetimeManager());
        }
    }
}
