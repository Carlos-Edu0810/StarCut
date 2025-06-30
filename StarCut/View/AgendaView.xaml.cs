using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StarCut_WPF.View
{
    /// <summary>
    /// Interação lógica para AgendaView.xam
    /// </summary>
    public partial class AgendaView : UserControl
    {
        public AgendaView()
        {
            InitializeComponent();

            List<string> minhaListaProfissionais = new List<string>
            {
                "Profissional 1",
                "Profissional 2",
                "Profissional 3"
            };

            ProfissionaisBox.ItemsSource = minhaListaProfissionais;

            List<string> minhaListaServicos = new List<string>
            {
                "Servico 1",
                "Servico 2",
                "Servico 3"
            };

            ServicoBox.ItemsSource = minhaListaServicos;

        }

        private void ProfissionalBox_Click(object sender, RoutedEventArgs e)
        {
            BuscarProfissionalBox.Text = "";
        }

        private void ServicoBox_Click(object sender, RoutedEventArgs e)
        {
            BuscarServicoBox.Text = "";
        }
    }
}
