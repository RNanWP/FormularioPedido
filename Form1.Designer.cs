namespace CheckButton_e_ComboBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpTamanho = new GroupBox();
            rbGrande = new RadioButton();
            rbMedia = new RadioButton();
            rbPequena = new RadioButton();
            grpPagamento = new GroupBox();
            rbPix = new RadioButton();
            rbCartao = new RadioButton();
            rbDinheiro = new RadioButton();
            grpAdicionais = new GroupBox();
            chkBacon = new CheckBox();
            chkBorda = new CheckBox();
            chkQueijo = new CheckBox();
            cmbSabor = new ComboBox();
            btnConfirmar = new Button();
            grpTamanho.SuspendLayout();
            grpPagamento.SuspendLayout();
            grpAdicionais.SuspendLayout();
            SuspendLayout();
            // 
            // grpTamanho
            // 
            grpTamanho.Controls.Add(rbGrande);
            grpTamanho.Controls.Add(rbMedia);
            grpTamanho.Controls.Add(rbPequena);
            grpTamanho.Location = new Point(12, 12);
            grpTamanho.Name = "grpTamanho";
            grpTamanho.Size = new Size(307, 195);
            grpTamanho.TabIndex = 3;
            grpTamanho.TabStop = false;
            grpTamanho.Text = "Tamanho";
            // 
            // rbGrande
            // 
            rbGrande.AutoSize = true;
            rbGrande.Location = new Point(90, 147);
            rbGrande.Name = "rbGrande";
            rbGrande.Size = new Size(78, 24);
            rbGrande.TabIndex = 2;
            rbGrande.TabStop = true;
            rbGrande.Text = "Grande";
            rbGrande.UseVisualStyleBackColor = true;
            // 
            // rbMedia
            // 
            rbMedia.AutoSize = true;
            rbMedia.Location = new Point(90, 96);
            rbMedia.Name = "rbMedia";
            rbMedia.Size = new Size(72, 24);
            rbMedia.TabIndex = 1;
            rbMedia.TabStop = true;
            rbMedia.Text = "Media";
            rbMedia.UseVisualStyleBackColor = true;
            // 
            // rbPequena
            // 
            rbPequena.AutoSize = true;
            rbPequena.Location = new Point(90, 42);
            rbPequena.Name = "rbPequena";
            rbPequena.Size = new Size(86, 24);
            rbPequena.TabIndex = 0;
            rbPequena.TabStop = true;
            rbPequena.Text = "Pequena";
            rbPequena.UseVisualStyleBackColor = true;
            // 
            // grpPagamento
            // 
            grpPagamento.Controls.Add(rbPix);
            grpPagamento.Controls.Add(rbCartao);
            grpPagamento.Controls.Add(rbDinheiro);
            grpPagamento.Location = new Point(335, 12);
            grpPagamento.Name = "grpPagamento";
            grpPagamento.Size = new Size(287, 195);
            grpPagamento.TabIndex = 4;
            grpPagamento.TabStop = false;
            grpPagamento.Text = "Pagamento";
            // 
            // rbPix
            // 
            rbPix.AutoSize = true;
            rbPix.Location = new Point(93, 82);
            rbPix.Name = "rbPix";
            rbPix.Size = new Size(49, 24);
            rbPix.TabIndex = 2;
            rbPix.TabStop = true;
            rbPix.Text = "Pix";
            rbPix.UseVisualStyleBackColor = true;
            rbPix.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbCartao
            // 
            rbCartao.AutoSize = true;
            rbCartao.Location = new Point(93, 135);
            rbCartao.Name = "rbCartao";
            rbCartao.Size = new Size(74, 24);
            rbCartao.TabIndex = 1;
            rbCartao.TabStop = true;
            rbCartao.Text = "Cartao";
            rbCartao.UseVisualStyleBackColor = true;
            // 
            // rbDinheiro
            // 
            rbDinheiro.AutoSize = true;
            rbDinheiro.Location = new Point(93, 30);
            rbDinheiro.Name = "rbDinheiro";
            rbDinheiro.Size = new Size(87, 24);
            rbDinheiro.TabIndex = 0;
            rbDinheiro.TabStop = true;
            rbDinheiro.Text = "Dinheiro";
            rbDinheiro.UseVisualStyleBackColor = true;
            // 
            // grpAdicionais
            // 
            grpAdicionais.Controls.Add(chkBacon);
            grpAdicionais.Controls.Add(chkBorda);
            grpAdicionais.Controls.Add(chkQueijo);
            grpAdicionais.Location = new Point(12, 232);
            grpAdicionais.Name = "grpAdicionais";
            grpAdicionais.Size = new Size(307, 206);
            grpAdicionais.TabIndex = 4;
            grpAdicionais.TabStop = false;
            grpAdicionais.Text = "Adicionais";
            // 
            // chkBacon
            // 
            chkBacon.AutoSize = true;
            chkBacon.Location = new Point(90, 161);
            chkBacon.Name = "chkBacon";
            chkBacon.Size = new Size(72, 24);
            chkBacon.TabIndex = 2;
            chkBacon.Text = "Bacon";
            chkBacon.UseVisualStyleBackColor = true;
            // 
            // chkBorda
            // 
            chkBorda.AutoSize = true;
            chkBorda.Location = new Point(90, 105);
            chkBorda.Name = "chkBorda";
            chkBorda.Size = new Size(71, 24);
            chkBorda.TabIndex = 1;
            chkBorda.Text = "Borda";
            chkBorda.TextAlign = ContentAlignment.MiddleCenter;
            chkBorda.UseVisualStyleBackColor = true;
            // 
            // chkQueijo
            // 
            chkQueijo.AutoSize = true;
            chkQueijo.Location = new Point(90, 47);
            chkQueijo.Name = "chkQueijo";
            chkQueijo.Size = new Size(75, 24);
            chkQueijo.TabIndex = 0;
            chkQueijo.Text = "Queijo";
            chkQueijo.UseVisualStyleBackColor = true;
            // 
            // cmbSabor
            // 
            cmbSabor.FormattingEnabled = true;
            cmbSabor.Items.AddRange(new object[] { "Calabresa", "Quatro Queijos", "Portuguesa" });
            cmbSabor.Location = new Point(409, 245);
            cmbSabor.Name = "cmbSabor";
            cmbSabor.Size = new Size(151, 28);
            cmbSabor.TabIndex = 5;
            cmbSabor.Text = "Sabor";
            cmbSabor.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(409, 372);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(151, 65);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "Confirmar ";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 461);
            Controls.Add(btnConfirmar);
            Controls.Add(cmbSabor);
            Controls.Add(grpAdicionais);
            Controls.Add(grpPagamento);
            Controls.Add(grpTamanho);
            Name = "Form1";
            Text = "Form1";
            grpTamanho.ResumeLayout(false);
            grpTamanho.PerformLayout();
            grpPagamento.ResumeLayout(false);
            grpPagamento.PerformLayout();
            grpAdicionais.ResumeLayout(false);
            grpAdicionais.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpTamanho;
        private RadioButton rbGrande;
        private RadioButton rbMedia;
        private RadioButton rbPequena;
        private GroupBox grpPagamento;
        private RadioButton rbCartao;
        private RadioButton rbDinheiro;
        private GroupBox grpAdicionais;
        private ComboBox cmbSabor;
        private CheckBox chkBacon;
        private CheckBox chkBorda;
        private CheckBox chkQueijo;
        private RadioButton rbPix;
        private Button btnConfirmar;
    }
}
