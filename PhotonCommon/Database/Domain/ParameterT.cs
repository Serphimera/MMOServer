using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotonCommon.Database.Domain
{
    public class ParameterT
    {
        public virtual string ParComp { get; }
        public virtual string ParCompGrp { get; }
        public virtual string ParKey { get; }
        public virtual DateTime DzIns { get; set; }
        public virtual DateTime DzUpd { get; set; }
        public virtual string NamUpd { get; set; }
        public virtual string ParDesc { get; set; }
        public virtual string ParValue { get; set; }
        public virtual int Tsn { get; set; }
        public virtual string ParValueMin { get; set; }
        public virtual string ParValueMax { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj)
        {
            ParameterT t = obj as ParameterT;
            if (t == null) return false;
            return ParComp == t.ParComp
                   && ParCompGrp == t.ParCompGrp
                   && ParKey == t.ParKey;
        }
        public override int GetHashCode()
        {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ ParComp.GetHashCode();
            hash = (hash * 397) ^ ParCompGrp.GetHashCode();
            hash = (hash * 397) ^ ParKey.GetHashCode();

            return hash;
        }
        #endregion
    }
}
