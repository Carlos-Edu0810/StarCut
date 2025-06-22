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
using System.Windows.Shapes;
using System.Windows.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StarCut.View
{
    /// <summary>
    /// Lógica interna para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private DispatcherTimer _timer;

        public Login()
        {
            InitializeComponent();
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(3); // A mensagem aparecerá por 3 segundos
            _timer.Tick += HideMessageTimer_Tick;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bool LoginValido = UserPassordBox.Password == "999" && UserTextBox.Text == "999" ? true : false;
            if (!LoginValido)
            {
                txtValid.Visibility = Visibility.Visible;
                txtValid.Text = "Error: Login invalido!";

                // Reinicia e inicia o temporizador para ocultar a label
                _timer.Stop(); // Garante que qualquer timer anterior seja parado
                _timer.Start(); // Inicia o timer
            }
        }

        private void HideMessageTimer_Tick(object? sender, EventArgs e)
        {
            txtValid.Visibility = Visibility.Collapsed; // Oculta a label
            _timer.Stop(); // Para o timer para que ele não continue disparando
        }
    }
}
