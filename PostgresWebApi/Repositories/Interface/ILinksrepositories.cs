using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostgresWebApi.Repositories.Interface
{
    public interface ILinksrepositories<T1,T2> where T1 : class
    {
        Task Insert(T1 entity);
    }
}
