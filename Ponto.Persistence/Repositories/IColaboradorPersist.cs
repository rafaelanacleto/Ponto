using Microsoft.Extensions.Logging;
using Ponto.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto.Persistence.Repositories
{
    public interface IColaboradorPersist
    {
        void Add<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();
        Task<Colaborador[]> GetAllColaboradorAsync();
        Task<Colaborador> GetColaboradorAsyncById(Guid Id);

    }
}
