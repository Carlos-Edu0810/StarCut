using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCut_Library.Models
{
    public class AgendamentoServico
    {
        public int id { get; set; }
        public int AgendamentoId { get; set; }
        public Agendamento Agendamento { get; set; }
        public int ServicoId { get; set; }
        public Servico Servico { get; set; }
        public decimal Valor { get; set; } 
        public decimal desconto { get; set; }
    }
}
