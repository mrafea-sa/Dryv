﻿using System;
using Autofac;

namespace Dryv.AspNetMvc
{
    internal class DependencyContainer : IDependencyContainer
    {
        private readonly ContainerBuilder builder;

        public DependencyContainer(ContainerBuilder builder) => this.builder = builder;

        public void AddInstance(Type iface, object implementation) => this.builder.RegisterInstance(implementation).As(iface).PreserveExistingDefaults();

        public void AddSingleton(Type iface, Type implementation) => this.builder.RegisterType(implementation).As(iface).PreserveExistingDefaults();

        public void RegisterInstance(Type iface, object implementation) => this.builder.RegisterInstance(implementation).As(iface);

        public void RegisterSingleton(Type iface, Type implementation) => this.builder.RegisterType(implementation).As(iface).SingleInstance();
    }
}