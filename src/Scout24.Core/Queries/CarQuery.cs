using System;
using System.Collections.Generic;
using System.Text;
using Scout24.Core.Dtos;
using Scout24.Core.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Scout24.Core.Queries
{
    public class CarQuery: ICarQuery
    {
        private Scout24Context _context;

        public CarQuery(Scout24Context context)
        {
            _context = context;
        }
        public async Task<IEnumerable<CarDto>> Find(int pageIndex, int pageCount)
        {
            var cars = from car in _context.Car
                           
                       select new CarDto
                       {
                           Id = car.Id,
                           Title=car.Title,
                           Price=car.Price,
                           FirstRegistration=car.FirstRegistration
                       };
            return  cars;
        }
        public async Task<CarDto> FindById(int carId)
        {
            var cars = from car in _context.Car
                       where car.Id==carId  
                       select new CarDto
                       {
                           Id = car.Id,
                           Title = car.Title,
                           Price = car.Price,
                           FirstRegistration = car.FirstRegistration
                       };
            return  cars.FirstOrDefault();
        }
    }
}
