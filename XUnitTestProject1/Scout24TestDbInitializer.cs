using System;
using System.Collections.Generic;
using System.Text;
using Scout24.Core.Models;

namespace XUnitTestProject1
{
   public class Scout24TestDbInitializer : IScout24DbInitializer
    {
        public void Initialize(Scout24Context db)
        {
            db.Car.AddRange(GetCars());
            db.SaveChanges();
        }
        private IEnumerable<Car> GetCars()
        {
            yield return new Car
            {
                Id = 1,
                Title = "Ship 1",
                Price = 14444
            };

            yield return new Car
            {
                Id = 2,
                Title = "Ship 2",
                Price = 12232
            };

            //yield return new Car
            //{
            //    Id = 3,
            //    Title = "Ship 3",
            //    Price = 4222
            //};
        }
    }
}
