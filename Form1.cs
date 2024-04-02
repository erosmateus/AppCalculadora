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
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }

        public decimal Valor { get; set; }

        private operacao OperacaoSelecionada { get; set; }

        enum operacao 
        { 
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao,
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "0";
        }

        private void btUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btMais_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = operacao.Adicao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            label1.Text = "+";
        }

        private void btMenos_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = operacao.Subtracao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            label1.Text = "-";
        }

        private void btMultiplicar_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            label1.Text = "X";
        }

        private void btDividir_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = operacao.Divisao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            label1.Text = "/";
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(txtResultado.Text);
                    break;
                case operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(txtResultado.Text);
                    break;
                case operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtResultado.Text);
                    break;
                case operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(txtResultado.Text);
                    break;
            }
            txtResultado.Text = Convert.ToString(Resultado);
            label1.Text = "=";
        }

        private void btVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
            {
                txtResultado.Text += ",";
            }
        }

        private void btLimpa_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            label1.Text = "";
        }
    }
}
