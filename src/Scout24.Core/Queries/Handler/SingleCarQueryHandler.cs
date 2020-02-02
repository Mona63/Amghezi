using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Scout24.Core.Models;
using Scout24.Core.Queries.Query;

namespace Scout24.Core.Queries.Handler
{
    public class SingleCarQueryHandler : IQueryHandler<SingleCarQuery, IEnumerable<Car>>
    {
        private Scout24Context _context;

        public SingleCarQueryHandler(Scout24Context context)
        {
            _context = context;
        }
        public Task<IEnumerable<Car>> Get(SingleCarQuery query)
        {
            //var cars = (from car in _context.Car
            //            select car);
            //return await cars.ToArrayAsync();
            return null;
        }
    }
}
