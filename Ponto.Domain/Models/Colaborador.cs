using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto.Domain.Models
{
    public class Colaborador
    {
        public Guid Id { get; set; }
        public string? Nome{ get; set; }
        public DateTime? DataRegistro { get; set; }
        public char? TipoOperacao { get; set; }

    }
}
