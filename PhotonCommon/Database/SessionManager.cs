// ********************************************************************************
// Copyright (C) 2016 Sebastian Kenter. All rights reserved.
//  
// Name    : MMOServer | PhotonCommon | SessionManager.cs
// Created : 2016-21-08 13:58
// Modified: 2016-21-08 14:12
// ********************************************************************************

using System;
using System.Linq;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Util;

namespace PhotonCommon.Database
{
    /// <summary>
    ///     Creates a session for database access if not yet present, else uses the present session
    /// </summary>
    public static class SessionManager
    {
        static SessionManager()
        {
            var mappingAssemblies =
                AppDomain.CurrentDomain.GetAssemblies().Where(a => a.FullName.StartsWith("PhotonServerCommon"));

            SessionFactory =
                Fluently.Configure()
                    .Database(
                        MySQLConfiguration.Standard.ConnectionString(
                            c =>
                                c.Server(DBSettings.Default.DBHost)
                                    .Database(DBSettings.Default.DBName)
                                    .Username(DBSettings.Default.DBUser)
                                    .Password(DBSettings.Default.DBPass)))
                    .Mappings(m => mappingAssemblies.ForEach(a => m.FluentMappings.AddFromAssembly(a)))
                    .Diagnostics(m => m.Enable())
                    .BuildSessionFactory();
        }

        /// <summary>Gets the session factory created from the initialized configuration. The returned factory is thread safe.</summary>
        private static ISessionFactory SessionFactory { get; }

        /// <summary>Opens a new session on the existing session factory</summary>
        /// <returns>ready to use ISession instance</returns>
        /// <remarks>
        ///     Dispose this instance after you're done with the instance, so after lazy loading has occurred. The returned
        ///     ISession instance is <b>not</b> thread safe.
        /// </remarks>
        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}