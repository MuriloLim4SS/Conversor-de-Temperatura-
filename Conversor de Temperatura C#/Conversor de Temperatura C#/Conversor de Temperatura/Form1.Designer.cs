namespace ProjetoFinalParte1
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
            lblTemperatura = new Label();
            btnCalcular = new Button();
            optCelsius = new RadioButton();
            gbEscalas = new GroupBox();
            optKelvin = new RadioButton();
            optFarenheit = new RadioButton();
            txtTemperatura = new TextBox();
            btnFechar = new Button();
            btnLimpar = new Button();
            txtTemperaturaA = new TextBox();
            lblTemperaturaA = new Label();
            txtTemperaturaB = new TextBox();
            lblTemperaturaB = new Label();
            gbEscalas.SuspendLayout();
            SuspendLayout();
            // 
            // lblTemperatura
            // 
            lblTemperatura.AutoSize = true;
            lblTemperatura.Location = new Point(12, 9);
            lblTemperatura.Name = "lblTemperatura";
            lblTemperatura.Size = new Size(76, 15);
            lblTemperatura.TabIndex = 0;
            lblTemperatura.Text = "Temperatura:";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = SystemColors.ButtonFace;
            btnCalcular.Location = new Point(12, 170);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // optCelsius
            // 
            optCelsius.AutoSize = true;
            optCelsius.BackColor = SystemColors.InactiveCaption;
            optCelsius.Location = new Point(6, 22);
            optCelsius.Name = "optCelsius";
            optCelsius.Size = new Size(62, 19);
            optCelsius.TabIndex = 3;
            optCelsius.TabStop = true;
            optCelsius.Text = "Celsius";
            optCelsius.UseVisualStyleBackColor = false;
            // 
            // gbEscalas
            // 
            gbEscalas.Controls.Add(optKelvin);
            gbEscalas.Controls.Add(optFarenheit);
            gbEscalas.Controls.Add(optCelsius);
            gbEscalas.Location = new Point(12, 64);
            gbEscalas.Name = "gbEscalas";
            gbEscalas.Size = new Size(113, 100);
            gbEscalas.TabIndex = 4;
            gbEscalas.TabStop = false;
            gbEscalas.Text = "Escalas:";
            // 
            // optKelvin
            // 
            optKelvin.AutoSize = true;
            optKelvin.BackColor = SystemColors.InactiveCaption;
            optKelvin.Location = new Point(6, 72);
            optKelvin.Name = "optKelvin";
            optKelvin.Size = new Size(57, 19);
            optKelvin.TabIndex = 5;
            optKelvin.TabStop = true;
            optKelvin.Text = "Kelvin";
            optKelvin.UseVisualStyleBackColor = false;
            // 
            // optFarenheit
            // 
            optFarenheit.AutoSize = true;
            optFarenheit.BackColor = SystemColors.InactiveCaption;
            optFarenheit.Location = new Point(6, 47);
            optFarenheit.Name = "optFarenheit";
            optFarenheit.Size = new Size(74, 19);
            optFarenheit.TabIndex = 4;
            optFarenheit.TabStop = true;
            optFarenheit.Text = "Farenheit";
            optFarenheit.UseVisualStyleBackColor = false;
            optFarenheit.CheckedChanged += optFarenheit_CheckedChanged;
            // 
            // txtTemperatura
            // 
            txtTemperatura.BackColor = SystemColors.MenuBar;
            txtTemperatura.Location = new Point(12, 26);
            txtTemperatura.Name = "txtTemperatura";
            txtTemperatura.Size = new Size(100, 23);
            txtTemperatura.TabIndex = 5;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = SystemColors.ButtonFace;
            btnFechar.Location = new Point(175, 200);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 6;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = SystemColors.ButtonFace;
            btnLimpar.Location = new Point(12, 228);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // txtTemperaturaA
            // 
            txtTemperaturaA.BackColor = SystemColors.Info;
            txtTemperaturaA.BorderStyle = BorderStyle.None;
            txtTemperaturaA.Location = new Point(150, 81);
            txtTemperaturaA.Name = "txtTemperaturaA";
            txtTemperaturaA.Size = new Size(100, 16);
            txtTemperaturaA.TabIndex = 9;
            // 
            // lblTemperaturaA
            // 
            lblTemperaturaA.AutoSize = true;
            lblTemperaturaA.Location = new Point(150, 64);
            lblTemperaturaA.Name = "lblTemperaturaA";
            lblTemperaturaA.Size = new Size(84, 15);
            lblTemperaturaA.TabIndex = 8;
            lblTemperaturaA.Text = "TemperaturaA:";
            // 
            // txtTemperaturaB
            // 
            txtTemperaturaB.BackColor = SystemColors.Info;
            txtTemperaturaB.BorderStyle = BorderStyle.None;
            txtTemperaturaB.Location = new Point(150, 141);
            txtTemperaturaB.Name = "txtTemperaturaB";
            txtTemperaturaB.Size = new Size(100, 16);
            txtTemperaturaB.TabIndex = 11;
            // 
            // lblTemperaturaB
            // 
            lblTemperaturaB.AutoSize = true;
            lblTemperaturaB.Location = new Point(150, 124);
            lblTemperaturaB.Name = "lblTemperaturaB";
            lblTemperaturaB.Size = new Size(83, 15);
            lblTemperaturaB.TabIndex = 10;
            lblTemperaturaB.Text = "TemperaturaB:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 274);
            Controls.Add(txtTemperaturaB);
            Controls.Add(lblTemperaturaB);
            Controls.Add(txtTemperaturaA);
            Controls.Add(lblTemperaturaA);
            Controls.Add(btnLimpar);
            Controls.Add(btnFechar);
            Controls.Add(txtTemperatura);
            Controls.Add(gbEscalas);
            Controls.Add(btnCalcular);
            Controls.Add(lblTemperatura);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbEscalas.ResumeLayout(false);
            gbEscalas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTemperatura;
        private Button btnCalcular;
        private RadioButton optCelsius;
        private GroupBox gbEscalas;
        private TextBox txtTemperatura;
        private RadioButton optKelvin;
        private RadioButton optFarenheint;
        private Button btnFechar;
        private Button btnLimpar;
        private TextBox txtTemperaturaA;
        private Label lblTemperaturaA;
        private TextBox txtTemperaturaB;
        private Label lblTemperaturaB;
        private RadioButton optFarenheit;
    }
}
