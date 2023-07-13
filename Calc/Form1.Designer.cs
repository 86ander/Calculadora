namespace Calc
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
            lblValor1 = new Label();
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            lblValor2 = new Label();
            btnSoma = new Button();
            btnSubtracao = new Button();
            btnMultiplicacao = new Button();
            btnDivisao = new Button();
            btnLimpar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblValor1
            // 
            lblValor1.AutoSize = true;
            lblValor1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblValor1.Location = new Point(12, 19);
            lblValor1.Name = "lblValor1";
            lblValor1.Size = new Size(116, 45);
            lblValor1.TabIndex = 0;
            lblValor1.Text = "Valor1:";
            // 
            // txtValor1
            // 
            txtValor1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtValor1.Location = new Point(150, 19);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(361, 50);
            txtValor1.TabIndex = 1;
            // 
            // txtValor2
            // 
            txtValor2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtValor2.Location = new Point(150, 104);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(361, 50);
            txtValor2.TabIndex = 3;
            // 
            // lblValor2
            // 
            lblValor2.AutoSize = true;
            lblValor2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblValor2.Location = new Point(12, 104);
            lblValor2.Name = "lblValor2";
            lblValor2.Size = new Size(116, 45);
            lblValor2.TabIndex = 2;
            lblValor2.Text = "Valor2:";
            // 
            // btnSoma
            // 
            btnSoma.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnSoma.Location = new Point(53, 215);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(157, 66);
            btnSoma.TabIndex = 4;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubtracao.Location = new Point(354, 215);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(157, 66);
            btnSubtracao.TabIndex = 5;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnMultiplicacao.Location = new Point(53, 338);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(157, 66);
            btnMultiplicacao.TabIndex = 6;
            btnMultiplicacao.Text = "*";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnDivisao.Location = new Point(354, 338);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(157, 66);
            btnDivisao.TabIndex = 7;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpar.Location = new Point(53, 436);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(458, 66);
            btnLimpar.TabIndex = 8;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(53, 536);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(167, 45);
            lblResultado.TabIndex = 9;
            lblResultado.Text = "Resultado:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 601);
            Controls.Add(lblResultado);
            Controls.Add(btnLimpar);
            Controls.Add(btnDivisao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnSubtracao);
            Controls.Add(btnSoma);
            Controls.Add(txtValor2);
            Controls.Add(lblValor2);
            Controls.Add(txtValor1);
            Controls.Add(lblValor1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblValor1;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private Label lblValor2;
        private Button btnSoma;
        private Button btnSubtracao;
        private Button btnMultiplicacao;
        private Button btnDivisao;
        private Button btnLimpar;
        private Label lblResultado;
    }
}