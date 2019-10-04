using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calc : Form
    {
        Double valor = 0;
        String operacao = "";
        bool op_escolhida = false;
        public Calc()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if ((txtValor.Text == "0") || (op_escolhida))
                txtValor.Clear();

            op_escolhida = false;
            Button btn = (Button)sender;
            txtValor.Text = txtValor.Text + btn.Text;
        }

        private void operacao_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operacao = btn.Text;
            valor = Double.Parse(txtValor.Text);
            op_escolhida = true;
            conta.Text = valor + " " + operacao;
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            txtValor.Text = "0";
            conta.Text = "";
            valor = 0;
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            conta.Text = "";
            switch (operacao)
            {
                case "+":
                    txtValor.Text = (valor + Double.Parse(txtValor.Text)).ToString();
                    break;

                case "-":
                    txtValor.Text = (valor - Double.Parse(txtValor.Text)).ToString();
                    break;

                case "*":
                    txtValor.Text = (valor * Double.Parse(txtValor.Text)).ToString();
                    break;

                case "/":
                    txtValor.Text = (valor / Double.Parse(txtValor.Text)).ToString();
                    break;

                case "%":
                    MessageBox.Show("Opção '%' está em desenvolvimento !");
                    break;

                default:
                    break;
            }
        }
    }
}
