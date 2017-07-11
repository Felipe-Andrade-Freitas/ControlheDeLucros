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

        private void calculadoraResidênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            valorAlugueltxt.Visible = true;
            valorImoveltxt.Visible = true;
            valorPoupancatxt.Visible = true;
            rendimentotxt.Visible = true;
            //Label
            valorDoAluguellbl.Visible = true;
            valorDoImovellbl.Visible = true;
            valorPoupancalbl.Visible = true;
            rendimentolbl.Visible = true;
        }

        private void calculadoraFinanceiraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            valorAlugueltxt.Visible = false;
            valorImoveltxt.Visible = false;
            valorPoupancatxt.Visible = false;
            rendimentotxt.Visible = false;

            valorDoAluguellbl.Visible = false;
            valorDoImovellbl.Visible = false;
            valorPoupancalbl.Visible = false;
            rendimentolbl.Visible = false;
        }
    }
}
