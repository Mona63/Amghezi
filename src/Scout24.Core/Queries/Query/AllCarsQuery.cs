using System;
using System.Collections.Generic;
using System.Text;
using Scout24.Core.Models;

namespace Scout24.Core.Queries.Query
{
    public class AllCarsQuery : IQuery<IEnumerable<Car>>
    {
        public int pageIndex { get; set; } = 0;
        public int pageCount { get; set; } = 100;
    }
}
