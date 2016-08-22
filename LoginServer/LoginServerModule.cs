﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using PhotonFramework.Application.Interface;
using PhotonFramework.Client.Implementation;
using PhotonFramework.Client.Interface;
using PhotonFramework.Server.Implementation;
using PhotonFramework.Server.Interface;

namespace LoginServer
{
    public class LoginServerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<LoginServer>().As<IServerApplication>().SingleInstance();
            builder.RegisterType<ClientPeerFactory>().As<IClientPeerFactory>().SingleInstance();
            builder.RegisterType<ServerPeerFactory>().As<IServerPeerFactory>().SingleInstance();
        }
    }
}
