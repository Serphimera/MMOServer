using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ExitGames.Logging;
using NHibernate;
using PhotonCommon.Database.Domain;

namespace PhotonCommon.Database.Access
{
    public class ParameterReader
    {
        private Dictionary<Type, object> Parameters { get; set; }
        private ILogger Logger { get; set; }
        
        public ParameterReader(string parCompGrp, string parComp)
        {
            Logger = LogManager.GetLogger("SQLLogger");

            ParameterT parameters = null;

            using (ISession session = SessionManager.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        parameters = session.QueryOver<ParameterT>()
                            .Where(p => p.ParCompGrp == parCompGrp)
                            .And(p => p.ParComp == parComp)
                            .SingleOrDefault();
                        transaction.Commit();
                    }
                    catch (Exception e)
                    {
                        Logger.FatalFormat("SQL-Exception received: %s", e.Message);
                        transaction.Rollback();
                    }
                }
                session.Close();
            }
        }

        public ParameterReader(string parCompGrp, string parComp, string parKey)
        {

        }
    }
}
