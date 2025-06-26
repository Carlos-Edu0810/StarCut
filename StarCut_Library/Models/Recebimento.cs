using StarCut_Library.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCut_Library.Models
{
    public class Recebimento
    {
        public int Id { get; set; }
        public int AgendamentoId { get; set; }
        public Agendamento Agendamento { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorPago { get; set; }
        public DateTime DataRecebimento { get; set; }
        public StatusPagamento StatusPagamento { get; set; }
        public Collection<FormaDePagamento> FormaDePagamento { get; set; }
    }
}
