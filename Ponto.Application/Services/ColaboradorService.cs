using AutoMapper;
using Microsoft.Extensions.Logging;
using Ponto.Application.Dtos;
using Ponto.Application.Interfaces;
using Ponto.Domain.Models;
using Ponto.Persistence.Repositories;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto.Application.Services
{
    public class ColaboradorService : IColaboradorService
    {
        private readonly IColaboradorPersist _colaboradorPersist;
        private readonly IMapper _mapper;

        public ColaboradorService(IColaboradorPersist colaboradorPersist, IMapper mapper)
        {
            _colaboradorPersist = colaboradorPersist;
            this._mapper = mapper;
        }

        public async Task<ColaboradorDto> AddColaborador(ColaboradorDto colaborador)
        {
            try
            {            
                var newColaborador = _mapper.Map<Colaborador>(colaborador);

                _colaboradorPersist.Add(newColaborador);
                if (await _colaboradorPersist.SaveChangesAsync())
                {
                    var eventoRetorno = _mapper.Map<ColaboradorDto>(await _colaboradorPersist.GetColaboradorAsyncById(colaborador.Id));
                    return eventoRetorno;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public async Task<ColaboradorDto[]> GetAllColaboradorAsync()
        {
            try
            {
                var colaboradores = await _colaboradorPersist.GetAllColaboradorAsync();

                if (colaboradores == null) return null;

                var resultado = _mapper.Map<ColaboradorDto[]>(colaboradores);

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public async Task<ColaboradorDto> GetColaboradorAsyncById(Guid Id)
        {
            try
            {
                var colaborador = await _colaboradorPersist.GetColaboradorAsyncById(Id);
                if (colaborador == null) return null;

                var eventoRetorno = _mapper.Map<ColaboradorDto>(colaborador);

                return eventoRetorno;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

    }
}
