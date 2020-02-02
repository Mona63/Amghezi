using System;
using System.Collections.Generic;
using System.Text;
using Scout24.Core.Models;
using System.Linq;

namespace Scout24.Core.Queries.Quey
{
   public  class CarQueryHandlerFactory
    {
        private readonly Scout24Context _context;

        public CarQueryHandlerFactory(Scout24Context context)
        {
            _context = context;
        }
        public  IQueryHandler<AllCarsQuery, IEnumerable<Car>> Build(AllCarsQuery query)
        {
            return new AllCarsQueryHandler(_context);
        }

        public object Build(IQuery<AllCarsQuery> query)
        {
            throw new NotImplementedException();
        }
    }
}
