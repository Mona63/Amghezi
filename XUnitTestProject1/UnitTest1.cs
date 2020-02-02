
using Xunit;
using System.Linq;
using System;
using Scout24.Core.Queries.Query;
using System.Collections.Generic;
using Scout24.Core.Models;
using Moq;
using Scout24.Core.Queries.Handler;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
       [Fact]
       public async System.Threading.Tasks.Task AllCarQuery_PageIndex_Shouldbe_MoreThanZero()
        {
            //arrange
          
            var handler = new AllCarsQueryHandler(null);
            //act and assert
           await Assert.ThrowsAsync<ArgumentOutOfRangeException>(() => handler.Get(new AllCarsQuery()
            {
                pageIndex = -1,
                pageCount = 100
            }));

        }
    }
}
