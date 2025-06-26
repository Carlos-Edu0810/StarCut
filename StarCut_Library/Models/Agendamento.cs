using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCut_Library.Models
{
    public class Agendamento
    {
        public int Id { get; set; }
        public int ClienteId { get; set; } 
        public Cliente Cliente { get; set; }
        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }
        public Collection<Servico> Servicos { get; set; }
        public string Observacoes { get; set; }
        public bool Status { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public DateTime DataAgendamento { get; set; }
    }
}
