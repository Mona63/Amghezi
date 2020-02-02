using System.Threading.Tasks;

namespace Scout24.Core.Queries.Query
{
    public interface IQueryHandler<in TQuery, TResponse> where TQuery : IQuery<TResponse>
    {
         Task<TResponse> Get(TQuery query);
    }

}
