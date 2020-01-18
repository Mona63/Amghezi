using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Scout24.Core.Dtos;
using Scout24.Core.Queries;

namespace Scout24.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarQuery _CarQuery;


        public CarController(ICarQuery CarQuery)
        {
            _CarQuery = CarQuery;

        }
        // GET: api/Cars
        [HttpGet]
        public async Task<IEnumerable<CarDto>> Get(int pageIndex, int pageCount)
        {
            var result = await _CarQuery.Find(pageIndex, pageCount);//.ConfigureAwait(false);
            return result;
        }


        //////////// GET: api/Car/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<CarDto> Get(int id)
        {
            var result = await _CarQuery.FindById(id);//?.ConfigureAwait(false);
            return result;
        }

        //////////// POST: api/Car
        //////////[HttpPost]
        //////////public void Post([FromBody] string value)
        //////////{
        //////////}

        //////////// PUT: api/Car/5
        //////////[HttpPut("{id}")]
        //////////public void Put(int id, [FromBody] string value)
        //////////{
        //////////}

        //////////// DELETE: api/ApiWithActions/5
        //////////[HttpDelete("{id}")]
        //////////public void Delete(int id)
        //////////{
        //////////}
    }
}
