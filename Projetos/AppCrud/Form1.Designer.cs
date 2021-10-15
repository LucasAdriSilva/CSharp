
namespace AppCrud
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.M = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.textModelo = new System.Windows.Forms.TextBox();
            this.textAno = new System.Windows.Forms.TextBox();
            this.textCor = new System.Windows.Forms.TextBox();
            this.textFabricacao = new System.Windows.Forms.TextBox();
            this.textValor = new System.Windows.Forms.TextBox();
            this.cbCombustivel = new System.Windows.Forms.ComboBox();
            this.cbAutomatico = new System.Windows.Forms.ComboBox();
            this.cbAtivo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Novo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Buscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.Excluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(51, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 25);
            this.label1.TabIndex = 0;
            this.label1.Tag = "ID";
            this.label1.Text = "Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // M
            // 
            this.M.AutoSize = true;
            this.M.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M.Location = new System.Drawing.Point(15, 145);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(67, 25);
            this.M.TabIndex = 1;
            this.M.Text = "Marca";
            this.M.Click += new System.EventHandler(this.Marca_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Combustivel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ano";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(242, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fabricação";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(293, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Valor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Automatico";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(79, 398);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Ativo";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(98, 115);
            this.textId.MaxLength = 10;
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(128, 20);
            this.textId.TabIndex = 1;
            this.textId.Leave += new System.EventHandler(this.textId_Leave);
            // 
            // textMarca
            // 
            this.textMarca.Location = new System.Drawing.Point(98, 151);
            this.textMarca.MaxLength = 30;
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(388, 20);
            this.textMarca.TabIndex = 2;
            this.textMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textModelo
            // 
            this.textModelo.Location = new System.Drawing.Point(98, 185);
            this.textModelo.MaxLength = 30;
            this.textModelo.Name = "textModelo";
            this.textModelo.Size = new System.Drawing.Size(387, 20);
            this.textModelo.TabIndex = 3;
            this.textModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textAno
            // 
            this.textAno.Location = new System.Drawing.Point(98, 220);
            this.textAno.MaxLength = 4;
            this.textAno.Name = "textAno";
            this.textAno.Size = new System.Drawing.Size(128, 20);
            this.textAno.TabIndex = 4;
            this.textAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textCor
            // 
            this.textCor.Location = new System.Drawing.Point(98, 255);
            this.textCor.MaxLength = 10;
            this.textCor.Name = "textCor";
            this.textCor.Size = new System.Drawing.Size(128, 20);
            this.textCor.TabIndex = 6;
            this.textCor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textFabricacao
            // 
            this.textFabricacao.Location = new System.Drawing.Point(357, 220);
            this.textFabricacao.MaxLength = 10;
            this.textFabricacao.Name = "textFabricacao";
            this.textFabricacao.Size = new System.Drawing.Size(128, 20);
            this.textFabricacao.TabIndex = 5;
            this.textFabricacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textFabricacao.TextChanged += new System.EventHandler(this.textFabricacao_TextChanged);
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(357, 255);
            this.textValor.MaxLength = 12;
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(128, 20);
            this.textValor.TabIndex = 7;
            this.textValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbCombustivel
            // 
            this.cbCombustivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCombustivel.FormattingEnabled = true;
            this.cbCombustivel.ItemHeight = 13;
            this.cbCombustivel.Location = new System.Drawing.Point(141, 324);
            this.cbCombustivel.Name = "cbCombustivel";
            this.cbCombustivel.Size = new System.Drawing.Size(121, 21);
            this.cbCombustivel.TabIndex = 8;
            // 
            // cbAutomatico
            // 
            this.cbAutomatico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAutomatico.FormattingEnabled = true;
            this.cbAutomatico.ItemHeight = 13;
            this.cbAutomatico.Location = new System.Drawing.Point(141, 360);
            this.cbAutomatico.Name = "cbAutomatico";
            this.cbAutomatico.Size = new System.Drawing.Size(121, 21);
            this.cbAutomatico.TabIndex = 9;
            // 
            // cbAtivo
            // 
            this.cbAtivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAtivo.FormattingEnabled = true;
            this.cbAtivo.ItemHeight = 13;
            this.cbAtivo.Location = new System.Drawing.Point(141, 398);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Size = new System.Drawing.Size(121, 21);
            this.cbAtivo.TabIndex = 10;
            this.cbAtivo.SelectedIndexChanged += new System.EventHandler(this.cbAtivo_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(149, 37);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 52);
            this.label10.TabIndex = 11;
            this.label10.Text = "Tela de Cadastro";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Novo,
            this.toolStripSeparator2,
            this.salvarToolStripButton,
            this.toolStripSeparator3,
            this.Buscar,
            this.toolStripSeparator,
            this.Excluir,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(513, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Novo
            // 
            this.Novo.Image = ((System.Drawing.Image)(resources.GetObject("Novo.Image")));
            this.Novo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Novo.Name = "Novo";
            this.Novo.Size = new System.Drawing.Size(56, 22);
            this.Novo.Text = "&Novo";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // salvarToolStripButton
            // 
            this.salvarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton.Image")));
            this.salvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton.Name = "salvarToolStripButton";
            this.salvarToolStripButton.Size = new System.Drawing.Size(58, 22);
            this.salvarToolStripButton.Text = "&Salvar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Buscar
            // 
            this.Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Buscar.Image")));
            this.Buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(62, 22);
            this.Buscar.Text = "&Buscar";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // Excluir
            // 
            this.Excluir.Image = ((System.Drawing.Image)(resources.GetObject("Excluir.Image")));
            this.Excluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(62, 22);
            this.Excluir.Text = "&Excluir";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(513, 478);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbAtivo);
            this.Controls.Add(this.cbAutomatico);
            this.Controls.Add(this.cbCombustivel);
            this.Controls.Add(this.textValor);
            this.Controls.Add(this.textFabricacao);
            this.Controls.Add(this.textCor);
            this.Controls.Add(this.textAno);
            this.Controls.Add(this.textModelo);
            this.Controls.Add(this.textMarca);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.M);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crud";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label M;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.TextBox textModelo;
        private System.Windows.Forms.TextBox textAno;
        private System.Windows.Forms.TextBox textCor;
        private System.Windows.Forms.TextBox textFabricacao;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.ComboBox cbCombustivel;
        private System.Windows.Forms.ComboBox cbAutomatico;
        private System.Windows.Forms.ComboBox cbAtivo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Novo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton salvarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton Buscar;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton Excluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

