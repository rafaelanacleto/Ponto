using AutoMapper;
using Microsoft.Extensions.Logging;
using Ponto.Application.Dtos;
using Ponto.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto.Application.Helpers
{
    public class ProEventosProfile : Profile
    {
        public ProEventosProfile() {

            CreateMap<Colaborador, ColaboradorDto>().ReverseMap();

        }


    }
}
