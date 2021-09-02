using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CodeSubmissionTool.Server.IRepositories
{
    public interface IGenericRepository<T> where T : class
    {

        Task<IList<T>> GetAll(Expression<Func<T, bool>> expression = null);        

        Task<T> Get(Expression<Func<T, bool>> expression);

        Task Insert(T entity);

        Task Delete(int id);

        void Update(T entity);

    }
}
