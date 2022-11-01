namespace winAppCadena
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCadena1 = new System.Windows.Forms.TextBox();
            this.txtCadena2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPalindromo = new System.Windows.Forms.Label();
            this.lblLongitud = new System.Windows.Forms.Label();
            this.lblConcatenada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadenas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cadena 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cadena 2";
            // 
            // txtCadena1
            // 
            this.txtCadena1.Location = new System.Drawing.Point(105, 63);
            this.txtCadena1.Name = "txtCadena1";
            this.txtCadena1.Size = new System.Drawing.Size(100, 29);
            this.txtCadena1.TabIndex = 3;
            this.txtCadena1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCadena1_KeyPress);
            // 
            // txtCadena2
            // 
            this.txtCadena2.Location = new System.Drawing.Point(105, 105);
            this.txtCadena2.Name = "txtCadena2";
            this.txtCadena2.Size = new System.Drawing.Size(100, 29);
            this.txtCadena2.TabIndex = 4;
            this.txtCadena2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCadena2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Concatenada: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Longitud";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Es palíndromo: ";
            // 
            // lblPalindromo
            // 
            this.lblPalindromo.AutoSize = true;
            this.lblPalindromo.Location = new System.Drawing.Point(148, 245);
            this.lblPalindromo.Name = "lblPalindromo";
            this.lblPalindromo.Size = new System.Drawing.Size(0, 21);
            this.lblPalindromo.TabIndex = 10;
            // 
            // lblLongitud
            // 
            this.lblLongitud.AutoSize = true;
            this.lblLongitud.Location = new System.Drawing.Point(148, 215);
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(0, 21);
            this.lblLongitud.TabIndex = 9;
            // 
            // lblConcatenada
            // 
            this.lblConcatenada.AutoSize = true;
            this.lblConcatenada.Location = new System.Drawing.Point(148, 185);
            this.lblConcatenada.Name = "lblConcatenada";
            this.lblConcatenada.Size = new System.Drawing.Size(0, 21);
            this.lblConcatenada.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(475, 300);
            this.Controls.Add(this.lblPalindromo);
            this.Controls.Add(this.lblLongitud);
            this.Controls.Add(this.lblConcatenada);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCadena2);
            this.Controls.Add(this.txtCadena1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Cadenas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCadena1;
        private TextBox txtCadena2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblPalindromo;
        private Label lblLongitud;
        private Label lblConcatenada;
    }
}