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
            this.CalculadoraResidênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculadoraFinanceiraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.valorJurostxt = new System.Windows.Forms.TextBox();
            this.valorImoveltxt = new System.Windows.Forms.TextBox();
            this.valorAlugueltxt = new System.Windows.Forms.TextBox();
            this.valorJuroslbl = new System.Windows.Forms.Label();
            this.valorDoImovellbl = new System.Windows.Forms.Label();
            this.valorDoAluguellbl = new System.Windows.Forms.Label();
            this.Calcularbtn = new System.Windows.Forms.Button();
            this.Sairbtn = new System.Windows.Forms.Button();
            this.valorDaPoupancalbl = new System.Windows.Forms.Label();
            this.valorDaPoupancatxt = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculadoraResidênciaToolStripMenuItem
            // 
            this.CalculadoraResidênciaToolStripMenuItem.Name = "CalculadoraResidênciaToolStripMenuItem";
            this.CalculadoraResidênciaToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.CalculadoraResidênciaToolStripMenuItem.Text = "Calculadora Residência";
            this.CalculadoraResidênciaToolStripMenuItem.Click += new System.EventHandler(this.CalculadoraResidênciaToolStripMenuItem_Click);
            // 
            // CalculadoraFinanceiraToolStripMenuItem
            // 
            this.CalculadoraFinanceiraToolStripMenuItem.Name = "CalculadoraFinanceiraToolStripMenuItem";
            this.CalculadoraFinanceiraToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.CalculadoraFinanceiraToolStripMenuItem.Text = "Calculadora Financeira";
            this.CalculadoraFinanceiraToolStripMenuItem.Click += new System.EventHandler(this.CalculadoraFinanceiraToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CalculadoraResidênciaToolStripMenuItem,
            this.CalculadoraFinanceiraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(303, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // valorJurostxt
            // 
            this.valorJurostxt.Location = new System.Drawing.Point(151, 78);
            this.valorJurostxt.Name = "valorJurostxt";
            this.valorJurostxt.Size = new System.Drawing.Size(100, 20);
            this.valorJurostxt.TabIndex = 1;
            this.valorJurostxt.Visible = false;
            // 
            // valorImoveltxt
            // 
            this.valorImoveltxt.Location = new System.Drawing.Point(151, 105);
            this.valorImoveltxt.Name = "valorImoveltxt";
            this.valorImoveltxt.Size = new System.Drawing.Size(100, 20);
            this.valorImoveltxt.TabIndex = 3;
            this.valorImoveltxt.Visible = false;
            // 
            // valorAlugueltxt
            // 
            this.valorAlugueltxt.Location = new System.Drawing.Point(151, 135);
            this.valorAlugueltxt.Name = "valorAlugueltxt";
            this.valorAlugueltxt.Size = new System.Drawing.Size(100, 20);
            this.valorAlugueltxt.TabIndex = 4;
            this.valorAlugueltxt.Visible = false;
            // 
            // valorJuroslbl
            // 
            this.valorJuroslbl.AutoSize = true;
            this.valorJuroslbl.Location = new System.Drawing.Point(66, 81);
            this.valorJuroslbl.Name = "valorJuroslbl";
            this.valorJuroslbl.Size = new System.Drawing.Size(79, 13);
            this.valorJuroslbl.TabIndex = 5;
            this.valorJuroslbl.Text = "Valor dos juros:";
            this.valorJuroslbl.Visible = false;
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
            this.valorDoAluguellbl.Location = new System.Drawing.Point(59, 138);
            this.valorDoAluguellbl.Name = "valorDoAluguellbl";
            this.valorDoAluguellbl.Size = new System.Drawing.Size(86, 13);
            this.valorDoAluguellbl.TabIndex = 7;
            this.valorDoAluguellbl.Text = "Valor do aluguel:";
            this.valorDoAluguellbl.Visible = false;
            // 
            // Calcularbtn
            // 
            this.Calcularbtn.Location = new System.Drawing.Point(48, 208);
            this.Calcularbtn.Name = "Calcularbtn";
            this.Calcularbtn.Size = new System.Drawing.Size(75, 23);
            this.Calcularbtn.TabIndex = 9;
            this.Calcularbtn.Text = "Calcular";
            this.Calcularbtn.UseVisualStyleBackColor = true;
            this.Calcularbtn.Visible = false;
            this.Calcularbtn.Click += new System.EventHandler(this.Calcularbtn_Click);
            // 
            // Sairbtn
            // 
            this.Sairbtn.Location = new System.Drawing.Point(176, 208);
            this.Sairbtn.Name = "Sairbtn";
            this.Sairbtn.Size = new System.Drawing.Size(75, 23);
            this.Sairbtn.TabIndex = 10;
            this.Sairbtn.Text = "Sair";
            this.Sairbtn.UseVisualStyleBackColor = true;
            this.Sairbtn.Visible = false;
            this.Sairbtn.Click += new System.EventHandler(this.Sairbtn_Click);
            // 
            // valorDaPoupancalbl
            // 
            this.valorDaPoupancalbl.AutoSize = true;
            this.valorDaPoupancalbl.Location = new System.Drawing.Point(45, 51);
            this.valorDaPoupancalbl.Name = "valorDaPoupancalbl";
            this.valorDaPoupancalbl.Size = new System.Drawing.Size(100, 13);
            this.valorDaPoupancalbl.TabIndex = 12;
            this.valorDaPoupancalbl.Text = "Valor da poupança:";
            this.valorDaPoupancalbl.Visible = false;
            // 
            // valorDaPoupancatxt
            // 
            this.valorDaPoupancatxt.Location = new System.Drawing.Point(151, 48);
            this.valorDaPoupancatxt.Name = "valorDaPoupancatxt";
            this.valorDaPoupancatxt.Size = new System.Drawing.Size(100, 20);
            this.valorDaPoupancatxt.TabIndex = 11;
            this.valorDaPoupancatxt.Visible = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 262);
            this.Controls.Add(this.valorDaPoupancalbl);
            this.Controls.Add(this.valorDaPoupancatxt);
            this.Controls.Add(this.Sairbtn);
            this.Controls.Add(this.Calcularbtn);
            this.Controls.Add(this.valorDoAluguellbl);
            this.Controls.Add(this.valorDoImovellbl);
            this.Controls.Add(this.valorJuroslbl);
            this.Controls.Add(this.valorAlugueltxt);
            this.Controls.Add(this.valorImoveltxt);
            this.Controls.Add(this.valorJurostxt);
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

        private System.Windows.Forms.ToolStripMenuItem CalculadoraResidênciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CalculadoraFinanceiraToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox valorJurostxt;
        private System.Windows.Forms.TextBox valorImoveltxt;
        private System.Windows.Forms.TextBox valorAlugueltxt;
        private System.Windows.Forms.Label valorJuroslbl;
        private System.Windows.Forms.Label valorDoImovellbl;
        private System.Windows.Forms.Label valorDoAluguellbl;
        private System.Windows.Forms.Button Calcularbtn;
        private System.Windows.Forms.Button Sairbtn;
        private System.Windows.Forms.Label valorDaPoupancalbl;
        private System.Windows.Forms.TextBox valorDaPoupancatxt;
    }
}

