using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCut_Library.Enums
{
    public enum StatusAgendamento
    {
        Agendado, //Agendado: O cliente marcou um horário e o agendamento está confirmado.
        Confirmado, //Confirmado: O agendamento foi confirmado pelo barbeiro ou pelo sistema
        Pendente, //Pendente: O agendamento está aguardando confirmação (do cliente ou do barbeiro).
        Cancelado, //Cancelado: O agendamento foi cancelado pelo cliente ou pelo barbeiro.
        Concluido, //Concluído: O serviço foi realizado no horário agendado.
        NaoCompareceu, //Não Compareceu (No-show): O cliente não apareceu para o agendamento.
        EmAndamento, //Em Andamento: O serviço está sendo realizado no momento.
        Atrasado, //Atrasado: O barbeiro ou o cliente está atrasado para o agendamento.
    }
}
