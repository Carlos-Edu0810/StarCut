using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCut_Library.Models
{
    public class Servico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public TimeSpan Duracao { get; set; } // Duração do serviço
        public bool Status { get; set; } // Indica se o serviço está ativo ou inativo
    }
}
