using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Scout24.Core.Dtos;

namespace Scout24.Core.Queries
{
  public  interface ICarQuery
    {
        Task<IEnumerable<CarDto>> Find(int pageIndex, int pageCount);
        Task<CarDto> FindById(int carId);
    }
}
