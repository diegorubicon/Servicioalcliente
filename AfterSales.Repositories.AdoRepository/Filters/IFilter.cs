using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AfterSales.Repositories.AdoRepositories.Filters
{
    public abstract class IFilter
    {
        public IFilter() { }
        public IFilter(string field) { }
    }
}
