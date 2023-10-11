using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            string cpf = maskedCPF.Text;
            Class_Validacao validacao = new Class_Validacao();
            bool verifica = true;
            verifica = validacao.validaCPF(cpf);
            if(verifica == true)
            {
                MessageBox.Show("CPF válido!");
            }
            else
            {
                MessageBox.Show("CPF inválido!");
            }

        }
    }
}
