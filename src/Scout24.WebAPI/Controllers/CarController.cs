using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Scout24.Core.Dtos;
using Scout24.Core.Models;
using Scout24.Core.Queries;
using Scout24.Core.Queries.Query;

namespace Scout24.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class CarController : ControllerBase
    {
      
        private IQueryHandler<AllCarsQuery, IEnumerable<Car>> _QueyHandler;

        public CarController(IQueryHandler<AllCarsQuery, IEnumerable<Car>> QueyHandler)
        {
            _QueyHandler = QueyHandler;
        }
      
        [HttpPost]
        
        public async Task<IEnumerable<Car>> Get(AllCarsQuery query)
        {     
            var result = await _QueyHandler.Get(query);
            return result;
        }


     
    }
}
