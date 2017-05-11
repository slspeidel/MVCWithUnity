using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCWithUnity.Domain
{
    public interface IMappingDataSource
    {
        IQueryable<ItemClass> Items { get; }
        IQueryable<OtherItemClass> OtherItems { get; }

        void Save();
    }
}
