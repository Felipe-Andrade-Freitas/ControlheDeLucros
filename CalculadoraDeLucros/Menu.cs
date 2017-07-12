using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDeLucros
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void CalculadoraResidênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            valorAlugueltxt.Visible = true;
            valorImoveltxt.Visible = true;
            valorJurostxt.Visible = true;
            Calcularbtn.Visible = true;
            Sairbtn.Visible = true;
            valorDaPoupancatxt.Visible = true;
            //Label
            valorDoAluguellbl.Visible = true;
            valorDoImovellbl.Visible = true;
            valorJuroslbl.Visible = true;
            valorDaPoupancalbl.Visible = true;
        }

        private void CalculadoraFinanceiraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            valorAlugueltxt.Visible = false;
            valorImoveltxt.Visible = false;
            valorJurostxt.Visible = false;
            Calcularbtn.Visible = false;
            Sairbtn.Visible = false;
            valorDaPoupancatxt.Visible = false;

            valorDoAluguellbl.Visible = false;
            valorDoImovellbl.Visible = false;
            valorJuroslbl.Visible = false;
            valorDaPoupancalbl.Visible = false;
        }

        private void Calcularbtn_Click(object sender, EventArgs e)
        {
            Poupanca poupanca = new Poupanca();
            Imovel imovel = new Imovel();
            CalculadoraAluguel calculadora = new CalculadoraAluguel;

            poupanca.ValorPoupanca = Convert.ToDouble(valorDaPoupancatxt.Text);
            poupanca.Juros = Convert.ToDouble(valorJurostxt.Text);
            imovel.ValorAluguel = Convert.ToDouble(valorAlugueltxt.Text);
            imovel.ValorCompra = Convert.ToDouble(valorImoveltxt.Text);

            poupanca.CalculaRendimento();

            MessageBox.Show("O seu rendimento é de: " + poupanca.Rendimento);

            if (calculadora.CalculaDiferenca = true)
            {
                MessageBox.Show("A melhor opção é alugar a casa.");
            }
            else
            {
                MessageBox.Show("A melhor opção é comprar a casa.");
            }

            if (poupanca.ValorPoupanca < imovel.ValorCompra)
            {
                double valorFaltante;

                valorFaltante = imovel.ValorCompra - poupanca.ValorPoupanca;
                MessageBox.Show("Falta " + valorFaltante + "para você comprar a casa.");
            }
        }

        private void Sairbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
