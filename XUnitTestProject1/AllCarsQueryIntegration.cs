using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Scout24.Core.Models;
using Scout24.Core.Queries.Query;
using Scout24.WebAPI;
using Xunit;
using System.Linq;
using System.Net.Http.Formatting;
using FluentAssertions;

namespace XUnitTestProject1
{
   public class AllCarsQueryIntegration:IClassFixture<Scout24AppFactory<Startup, Scout24TestDbInitializer>>
    {
        protected Scout24AppFactory<Startup, Scout24TestDbInitializer> Factory { get;  }
        public AllCarsQueryIntegration(Scout24AppFactory<Startup, Scout24TestDbInitializer> factory)
        {
            Factory = factory;
        }

        [Fact]
        public async Task GetAllCarsQuery()
        {
            // arrange
            var query = new AllCarsQuery
            {
                pageIndex = 0,
                pageCount = 100,
               
            };

            // act
            var summary = await GetAllCarQueryAsync(query);

            // assert
            //summary.pa.Should().Be(0);
            //summary.Limit.Should().Be(100);
            //summary.Total.Should().Be(2);
            summary.ToArray().Should().BeEquivalentTo(new[] {
                new Car {
                   Id = 1,
                Title = "Ship 1",
                Price = 14444
                },
                new Car {
                    Id = 2,
                Title = "Ship 2",
                Price = 12232
                }
            });
        }

        protected async Task<IEnumerable<Car>> GetAllCarQueryAsync(AllCarsQuery query)
        {
            var httpClient = Factory.CreateClient();

            var response = await httpClient.PostAsync(
                "/api/car",
                new StringContent(
                    JsonConvert.SerializeObject(query),
                    Encoding.UTF8,
                    "application/json"
                )
            );

            return await response.Content.ReadAsAsync<IEnumerable<Car>>();
        }
    }
}
