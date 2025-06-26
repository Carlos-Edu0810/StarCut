using StarCut_Library.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCut_Library.Models
{
    internal class RecebimentoFormaPagamento
    {
        public int Id { get; set; }
        public int IdRecebimento { get; set; }
        public int IdFormaPagamento { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataHora { get; set; }
        public string Observacao { get; set; }
        public FormaDePagamento FormaPagamento { get; set; }
    }
}
