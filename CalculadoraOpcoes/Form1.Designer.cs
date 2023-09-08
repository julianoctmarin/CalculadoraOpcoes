namespace CalculadoraOpcoes
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
            lblX = new Label();
            lblY = new Label();
            lblTotal = new Label();
            txtX = new TextBox();
            txtY = new TextBox();
            txtTotal = new TextBox();
            grpAritmetica = new GroupBox();
            rdbDividir = new RadioButton();
            rdbMultiplicar = new RadioButton();
            rdbSubtrair = new RadioButton();
            rdbSomar = new RadioButton();
            btnLimpar = new Button();
            btnCalcular = new Button();
            btnFechar = new Button();
            lstHistorico = new ListBox();
            label1 = new Label();
            grpAritmetica.SuspendLayout();
            SuspendLayout();
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Location = new Point(41, 35);
            lblX.Name = "lblX";
            lblX.Size = new Size(43, 15);
            lblX.TabIndex = 0;
            lblX.Text = "Valor X";
            // 
            // lblY
            // 
            lblY.AutoSize = true;
            lblY.Location = new Point(41, 69);
            lblY.Name = "lblY";
            lblY.Size = new Size(43, 15);
            lblY.TabIndex = 1;
            lblY.Text = "Valor Y";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(41, 102);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(32, 15);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total";
            // 
            // txtX
            // 
            txtX.Location = new Point(120, 32);
            txtX.Name = "txtX";
            txtX.Size = new Size(100, 23);
            txtX.TabIndex = 3;
            // 
            // txtY
            // 
            txtY.Location = new Point(120, 66);
            txtY.Name = "txtY";
            txtY.Size = new Size(100, 23);
            txtY.TabIndex = 4;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(120, 99);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 5;
            // 
            // grpAritmetica
            // 
            grpAritmetica.Controls.Add(rdbDividir);
            grpAritmetica.Controls.Add(rdbMultiplicar);
            grpAritmetica.Controls.Add(rdbSubtrair);
            grpAritmetica.Controls.Add(rdbSomar);
            grpAritmetica.Location = new Point(41, 159);
            grpAritmetica.Name = "grpAritmetica";
            grpAritmetica.Size = new Size(200, 124);
            grpAritmetica.TabIndex = 6;
            grpAritmetica.TabStop = false;
            grpAritmetica.Text = "Operações";
            // 
            // rdbDividir
            // 
            rdbDividir.AutoSize = true;
            rdbDividir.Location = new Point(6, 97);
            rdbDividir.Name = "rdbDividir";
            rdbDividir.Size = new Size(59, 19);
            rdbDividir.TabIndex = 3;
            rdbDividir.TabStop = true;
            rdbDividir.Text = "Dividir";
            rdbDividir.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicar
            // 
            rdbMultiplicar.AutoSize = true;
            rdbMultiplicar.Location = new Point(6, 72);
            rdbMultiplicar.Name = "rdbMultiplicar";
            rdbMultiplicar.Size = new Size(82, 19);
            rdbMultiplicar.TabIndex = 2;
            rdbMultiplicar.TabStop = true;
            rdbMultiplicar.Text = "Multiplicar";
            rdbMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rdbSubtrair
            // 
            rdbSubtrair.AutoSize = true;
            rdbSubtrair.Location = new Point(6, 47);
            rdbSubtrair.Name = "rdbSubtrair";
            rdbSubtrair.Size = new Size(66, 19);
            rdbSubtrair.TabIndex = 1;
            rdbSubtrair.TabStop = true;
            rdbSubtrair.Text = "Subtrair";
            rdbSubtrair.UseVisualStyleBackColor = true;
            // 
            // rdbSomar
            // 
            rdbSomar.AutoSize = true;
            rdbSomar.Location = new Point(6, 22);
            rdbSomar.Name = "rdbSomar";
            rdbSomar.Size = new Size(59, 19);
            rdbSomar.TabIndex = 0;
            rdbSomar.TabStop = true;
            rdbSomar.Text = "Somar";
            rdbSomar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(41, 301);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(166, 301);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(105, 343);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 10;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // lstHistorico
            // 
            lstHistorico.FormattingEnabled = true;
            lstHistorico.ItemHeight = 15;
            lstHistorico.Location = new Point(282, 62);
            lstHistorico.Name = "lstHistorico";
            lstHistorico.Size = new Size(198, 304);
            lstHistorico.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(282, 32);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 12;
            label1.Text = "Historico";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 387);
            Controls.Add(label1);
            Controls.Add(lstHistorico);
            Controls.Add(btnFechar);
            Controls.Add(btnCalcular);
            Controls.Add(btnLimpar);
            Controls.Add(grpAritmetica);
            Controls.Add(txtTotal);
            Controls.Add(txtY);
            Controls.Add(txtX);
            Controls.Add(lblTotal);
            Controls.Add(lblY);
            Controls.Add(lblX);
            Name = "Form1";
            Text = "Calculadora";
            Load += Form1_Load;
            grpAritmetica.ResumeLayout(false);
            grpAritmetica.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblX;
        private Label lblY;
        private Label lblTotal;
        private TextBox txtX;
        private TextBox txtY;
        private TextBox txtTotal;
        private GroupBox grpAritmetica;
        private RadioButton rdbDividir;
        private RadioButton rdbMultiplicar;
        private RadioButton rdbSubtrair;
        private RadioButton rdbSomar;
        private Button btnLimpar;
        private Button btnCalcular;
        private Button btnFechar;
        private ListBox lstHistorico;
        private Label label1;
    }
}