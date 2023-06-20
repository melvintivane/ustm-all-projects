using ContaBancaria.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaBancaria
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void AddUserControl(UserControl userControl)
        {
            //Controls.Clear();
            Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UserControlCadastrarConta cadastrarConta = new UserControlCadastrarConta();
            AddUserControl(cadastrarConta);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            UserControlEfectuarDeposito efectuarDeposito = new UserControlEfectuarDeposito();
            AddUserControl(efectuarDeposito);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            UserControlEfectuarSaque efectuarSaque = new UserControlEfectuarSaque();
            AddUserControl(efectuarSaque);
        }

    }
}
