using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Ponto.Domain.Models;
using Ponto.Persistence.Context;
using Ponto.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto.Persistence
{
    public class ColaboradorPersistence : IColaboradorPersist
    {

        private readonly ColaboradorContext _context;

        public ColaboradorPersistence(ColaboradorContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public async Task<Colaborador[]> GetAllColaboradorAsync()
        {
            IQueryable<Colaborador> query = _context.Colaboradors
                .AsQueryable();

            query = query.OrderBy(c => c.Id);
            return await query.ToArrayAsync();
        }

        public async Task<Colaborador> GetColaboradorAsyncById(Guid Id)
        {
            IQueryable<Colaborador> query = _context.Colaboradors
               .AsQueryable();

            query = query
                .OrderBy(c => c.Id)
                .Where(c => c.Id == Id);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}
