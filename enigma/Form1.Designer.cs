namespace enigma
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbLog = new System.Windows.Forms.ListBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.btnPlugboard = new System.Windows.Forms.Button();
            this.cbbRotor1 = new System.Windows.Forms.ComboBox();
            this.cbbRotor2 = new System.Windows.Forms.ComboBox();
            this.cbbRotor3 = new System.Windows.Forms.ComboBox();
            this.cbbOffset1 = new System.Windows.Forms.ComboBox();
            this.cbbOffset3 = new System.Windows.Forms.ComboBox();
            this.cbbOffset2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLog
            // 
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 16;
            this.lbLog.Location = new System.Drawing.Point(788, 47);
            this.lbLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(328, 580);
            this.lbLog.TabIndex = 0;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(27, 418);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(671, 187);
            this.txtInput.TabIndex = 1;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(27, 229);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(671, 152);
            this.txtOutput.TabIndex = 2;
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Location = new System.Drawing.Point(283, 626);
            this.btnEncriptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(172, 28);
            this.btnEncriptar.TabIndex = 3;
            this.btnEncriptar.Text = "Encriptar/Desencriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // btnPlugboard
            // 
            this.btnPlugboard.Location = new System.Drawing.Point(305, 148);
            this.btnPlugboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlugboard.Name = "btnPlugboard";
            this.btnPlugboard.Size = new System.Drawing.Size(120, 28);
            this.btnPlugboard.TabIndex = 4;
            this.btnPlugboard.Text = "Plugboard";
            this.btnPlugboard.UseVisualStyleBackColor = true;
            this.btnPlugboard.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbbRotor1
            // 
            this.cbbRotor1.FormattingEnabled = true;
            this.cbbRotor1.Location = new System.Drawing.Point(149, 41);
            this.cbbRotor1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbRotor1.Name = "cbbRotor1";
            this.cbbRotor1.Size = new System.Drawing.Size(136, 24);
            this.cbbRotor1.TabIndex = 5;
            this.cbbRotor1.SelectedIndexChanged += new System.EventHandler(this.RotorChanged);
            // 
            // cbbRotor2
            // 
            this.cbbRotor2.FormattingEnabled = true;
            this.cbbRotor2.Location = new System.Drawing.Point(332, 41);
            this.cbbRotor2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbRotor2.Name = "cbbRotor2";
            this.cbbRotor2.Size = new System.Drawing.Size(121, 24);
            this.cbbRotor2.TabIndex = 6;
            this.cbbRotor2.SelectedIndexChanged += new System.EventHandler(this.RotorChanged);
            // 
            // cbbRotor3
            // 
            this.cbbRotor3.FormattingEnabled = true;
            this.cbbRotor3.Location = new System.Drawing.Point(500, 41);
            this.cbbRotor3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbRotor3.Name = "cbbRotor3";
            this.cbbRotor3.Size = new System.Drawing.Size(127, 24);
            this.cbbRotor3.TabIndex = 7;
            this.cbbRotor3.SelectedIndexChanged += new System.EventHandler(this.RotorChanged);
            // 
            // cbbOffset1
            // 
            this.cbbOffset1.FormattingEnabled = true;
            this.cbbOffset1.Location = new System.Drawing.Point(149, 101);
            this.cbbOffset1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbOffset1.Name = "cbbOffset1";
            this.cbbOffset1.Size = new System.Drawing.Size(136, 24);
            this.cbbOffset1.TabIndex = 8;
            this.cbbOffset1.SelectedIndexChanged += new System.EventHandler(this.ChangeOffset);
            // 
            // cbbOffset3
            // 
            this.cbbOffset3.FormattingEnabled = true;
            this.cbbOffset3.Location = new System.Drawing.Point(500, 101);
            this.cbbOffset3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbOffset3.Name = "cbbOffset3";
            this.cbbOffset3.Size = new System.Drawing.Size(127, 24);
            this.cbbOffset3.TabIndex = 9;
            this.cbbOffset3.SelectedIndexChanged += new System.EventHandler(this.ChangeOffset);
            // 
            // cbbOffset2
            // 
            this.cbbOffset2.FormattingEnabled = true;
            this.cbbOffset2.Location = new System.Drawing.Point(332, 101);
            this.cbbOffset2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbOffset2.Name = "cbbOffset2";
            this.cbbOffset2.Size = new System.Drawing.Size(121, 24);
            this.cbbOffset2.TabIndex = 10;
            this.cbbOffset2.SelectedIndexChanged += new System.EventHandler(this.ChangeOffset);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tipo Rotor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Offset Rotor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Rotor 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Rotor 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Rotor 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(784, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Log Funcionamiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 206);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Output";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 399);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Input";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(917, 635);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 687);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbOffset2);
            this.Controls.Add(this.cbbOffset3);
            this.Controls.Add(this.cbbOffset1);
            this.Controls.Add(this.cbbRotor3);
            this.Controls.Add(this.cbbRotor2);
            this.Controls.Add(this.cbbRotor1);
            this.Controls.Add(this.btnPlugboard);
            this.Controls.Add(this.btnEncriptar);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lbLog);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.Button btnPlugboard;
        private System.Windows.Forms.ComboBox cbbRotor1;
        private System.Windows.Forms.ComboBox cbbRotor2;
        private System.Windows.Forms.ComboBox cbbRotor3;
        private System.Windows.Forms.ComboBox cbbOffset1;
        private System.Windows.Forms.ComboBox cbbOffset3;
        private System.Windows.Forms.ComboBox cbbOffset2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

