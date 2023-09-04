using Ponto.Application.Dtos;
using Ponto.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto.Application.Interfaces
{
    public interface IColaboradorService
    {
        Task<ColaboradorDto> AddColaborador(ColaboradorDto colaborador);    
        Task<ColaboradorDto[]> GetAllColaboradorAsync();
        Task<ColaboradorDto> GetColaboradorAsyncById(Guid Id);
    }
}
