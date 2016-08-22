using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PhotonCommon.Database.Domain;

namespace PhotonCommon.Database.Mapping
{
    public class ParameterTMap : ClassMap<ParameterT>
    {

        public ParameterTMap()
        {
            Table("parameter_t");
            LazyLoad();
            CompositeId().KeyProperty(x => x.ParComp, "ParComp")
                         .KeyProperty(x => x.ParCompGrp, "ParCompGrp")
                         .KeyProperty(x => x.ParKey, "ParKey");
            Map(x => x.DzIns).Column("DzIns").Not.Nullable();
            Map(x => x.DzUpd).Column("DzUpd").Not.Nullable();
            Map(x => x.NamUpd).Column("NamUpd").Not.Nullable();
            Map(x => x.ParDesc).Column("ParDesc").Not.Nullable();
            Map(x => x.ParValue).Column("ParValue");
            Map(x => x.Tsn).Column("Tsn").Not.Nullable();
            Map(x => x.ParValueMin).Column("ParValueMin");
            Map(x => x.ParValueMax).Column("ParValueMax");
        }
    }
}
