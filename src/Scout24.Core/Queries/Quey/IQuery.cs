using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Scout24.Core.Queries.Quey
{
    public interface IQuery<TResponse>
    {            
         int pageIndex { get; set; }
         int pageCount { get; set; }
    }
    public interface IQueryHandler<in TQuery, TResponse> where TQuery : IQuery<TResponse>
    {
         Task<TResponse> Get(TQuery query);
    }

}
