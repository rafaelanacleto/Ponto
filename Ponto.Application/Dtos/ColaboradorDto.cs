using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto.Application.Dtos
{
    public class ColaboradorDto
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public DateTime? DataRegistro { get; set; }
        public char? TipoOperacao { get; set; }
    }
}
