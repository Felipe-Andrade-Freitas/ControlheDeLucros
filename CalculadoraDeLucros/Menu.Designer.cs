namespace CalculadoraDeLucros
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calculadoraResidênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraFinanceiraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.valorPoupancatxt = new System.Windows.Forms.TextBox();
            this.rendimentotxt = new System.Windows.Forms.TextBox();
            this.valorImoveltxt = new System.Windows.Forms.TextBox();
            this.valorAlugueltxt = new System.Windows.Forms.TextBox();
            this.valorPoupancalbl = new System.Windows.Forms.Label();
            this.valorDoImovellbl = new System.Windows.Forms.Label();
            this.valorDoAluguellbl = new System.Windows.Forms.Label();
            this.rendimentolbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculadoraResidênciaToolStripMenuItem
            // 
            this.calculadoraResidênciaToolStripMenuItem.Name = "calculadoraResidênciaToolStripMenuItem";
            this.calculadoraResidênciaToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.calculadoraResidênciaToolStripMenuItem.Text = "Calculadora Residência";
            this.calculadoraResidênciaToolStripMenuItem.Click += new System.EventHandler(this.calculadoraResidênciaToolStripMenuItem_Click);
            // 
            // calculadoraFinanceiraToolStripMenuItem
            // 
            this.calculadoraFinanceiraToolStripMenuItem.Name = "calculadoraFinanceiraToolStripMenuItem";
            this.calculadoraFinanceiraToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.calculadoraFinanceiraToolStripMenuItem.Text = "Calculadora Financeira";
            this.calculadoraFinanceiraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraFinanceiraToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraResidênciaToolStripMenuItem,
            this.calculadoraFinanceiraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(303, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // valorPoupancatxt
            // 
            this.valorPoupancatxt.Location = new System.Drawing.Point(151, 74);
            this.valorPoupancatxt.Name = "valorPoupancatxt";
            this.valorPoupancatxt.Size = new System.Drawing.Size(100, 20);
            this.valorPoupancatxt.TabIndex = 1;
            this.valorPoupancatxt.Visible = false;
            // 
            // rendimentotxt
            // 
            this.rendimentotxt.Location = new System.Drawing.Point(151, 101);
            this.rendimentotxt.Name = "rendimentotxt";
            this.rendimentotxt.Size = new System.Drawing.Size(100, 20);
            this.rendimentotxt.TabIndex = 2;
            this.rendimentotxt.Visible = false;
            // 
            // valorImoveltxt
            // 
            this.valorImoveltxt.Location = new System.Drawing.Point(151, 127);
            this.valorImoveltxt.Name = "valorImoveltxt";
            this.valorImoveltxt.Size = new System.Drawing.Size(100, 20);
            this.valorImoveltxt.TabIndex = 3;
            this.valorImoveltxt.Visible = false;
            // 
            // valorAlugueltxt
            // 
            this.valorAlugueltxt.Location = new System.Drawing.Point(151, 153);
            this.valorAlugueltxt.Name = "valorAlugueltxt";
            this.valorAlugueltxt.Size = new System.Drawing.Size(100, 20);
            this.valorAlugueltxt.TabIndex = 4;
            this.valorAlugueltxt.Visible = false;
            // 
            // valorPoupancalbl
            // 
            this.valorPoupancalbl.AutoSize = true;
            this.valorPoupancalbl.Location = new System.Drawing.Point(45, 77);
            this.valorPoupancalbl.Name = "valorPoupancalbl";
            this.valorPoupancalbl.Size = new System.Drawing.Size(100, 13);
            this.valorPoupancalbl.TabIndex = 5;
            this.valorPoupancalbl.Text = "Valor da poupança:";
            this.valorPoupancalbl.Visible = false;
            // 
            // valorDoImovellbl
            // 
            this.valorDoImovellbl.AutoSize = true;
            this.valorDoImovellbl.Location = new System.Drawing.Point(63, 108);
            this.valorDoImovellbl.Name = "valorDoImovellbl";
            this.valorDoImovellbl.Size = new System.Drawing.Size(82, 13);
            this.valorDoImovellbl.TabIndex = 6;
            this.valorDoImovellbl.Text = "Valor do imóvel:";
            this.valorDoImovellbl.Visible = false;
            // 
            // valorDoAluguellbl
            // 
            this.valorDoAluguellbl.AutoSize = true;
            this.valorDoAluguellbl.Location = new System.Drawing.Point(59, 134);
            this.valorDoAluguellbl.Name = "valorDoAluguellbl";
            this.valorDoAluguellbl.Size = new System.Drawing.Size(86, 13);
            this.valorDoAluguellbl.TabIndex = 7;
            this.valorDoAluguellbl.Text = "Valor do aluguel:";
            this.valorDoAluguellbl.Visible = false;
            // 
            // rendimentolbl
            // 
            this.rendimentolbl.AutoSize = true;
            this.rendimentolbl.Location = new System.Drawing.Point(57, 160);
            this.rendimentolbl.Name = "rendimentolbl";
            this.rendimentolbl.Size = new System.Drawing.Size(88, 13);
            this.rendimentolbl.TabIndex = 8;
            this.rendimentolbl.Text = "% do rendimento:";
            this.rendimentolbl.Visible = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 262);
            this.Controls.Add(this.rendimentolbl);
            this.Controls.Add(this.valorDoAluguellbl);
            this.Controls.Add(this.valorDoImovellbl);
            this.Controls.Add(this.valorPoupancalbl);
            this.Controls.Add(this.valorAlugueltxt);
            this.Controls.Add(this.valorImoveltxt);
            this.Controls.Add(this.rendimentotxt);
            this.Controls.Add(this.valorPoupancatxt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Calculadora de Lucros";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem calculadoraResidênciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraFinanceiraToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox valorPoupancatxt;
        private System.Windows.Forms.TextBox rendimentotxt;
        private System.Windows.Forms.TextBox valorImoveltxt;
        private System.Windows.Forms.TextBox valorAlugueltxt;
        private System.Windows.Forms.Label valorPoupancalbl;
        private System.Windows.Forms.Label valorDoImovellbl;
        private System.Windows.Forms.Label valorDoAluguellbl;
        private System.Windows.Forms.Label rendimentolbl;
    }
}

