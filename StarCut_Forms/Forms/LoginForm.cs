using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace StarCut_Forms.Forms
{
    public partial class LoginForm : Form
    {
        // Importa função da API do Windows
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        // Mensagem para definir o texto "cue banner" (placeholder)
        private const int EM_SETCUEBANNER = 0x1501;

        // Método para aplicar o placeholder
        private void DefinirPlaceholder(TextBox txt, string texto)
        {   
            SendMessage(txt.Handle, EM_SETCUEBANNER, 0, texto);
        }

        public LoginForm()
        {
            InitializeComponent();
            BordaArredondada.Arredondar(pnlBorda, 5);
            BordaArredondada.Arredondar(txtUser, 5);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            DefinirPlaceholder(txtUser, "Digite seu usuário");
        }
    }
}
