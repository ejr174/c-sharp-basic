namespace FuncionesString
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
            lblTitle1 = new Label();
            blTitle2 = new Label();
            txtCadenaPrincipal = new TextBox();
            txtResult = new TextBox();
            btnMayuscula = new Button();
            btnSubCadena = new Button();
            btnMinuscula = new Button();
            SuspendLayout();
            // 
            // lblTitle1
            // 
            lblTitle1.AutoSize = true;
            lblTitle1.Location = new Point(171, 76);
            lblTitle1.Name = "lblTitle1";
            lblTitle1.Size = new Size(96, 15);
            lblTitle1.TabIndex = 0;
            lblTitle1.Text = "Cadena principal";
            // 
            // blTitle2
            // 
            blTitle2.AutoSize = true;
            blTitle2.Location = new Point(171, 146);
            blTitle2.Name = "blTitle2";
            blTitle2.Size = new Size(59, 15);
            blTitle2.TabIndex = 1;
            blTitle2.Text = "Resultado";
            // 
            // txtCadenaPrincipal
            // 
            txtCadenaPrincipal.Location = new Point(171, 94);
            txtCadenaPrincipal.Name = "txtCadenaPrincipal";
            txtCadenaPrincipal.Size = new Size(196, 23);
            txtCadenaPrincipal.TabIndex = 2;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(171, 164);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(196, 23);
            txtResult.TabIndex = 3;
            // 
            // btnMayuscula
            // 
            btnMayuscula.Location = new Point(130, 217);
            btnMayuscula.Name = "btnMayuscula";
            btnMayuscula.Size = new Size(75, 23);
            btnMayuscula.TabIndex = 4;
            btnMayuscula.Text = "Mayuscula";
            btnMayuscula.UseVisualStyleBackColor = true;
            btnMayuscula.Click += btnMayuscula_Click;
            // 
            // btnSubCadena
            // 
            btnSubCadena.Location = new Point(234, 217);
            btnSubCadena.Name = "btnSubCadena";
            btnSubCadena.Size = new Size(75, 23);
            btnSubCadena.TabIndex = 5;
            btnSubCadena.Text = "SubCadena";
            btnSubCadena.UseVisualStyleBackColor = true;
            btnSubCadena.Click += btnSubCadena_Click;
            // 
            // btnMinuscula
            // 
            btnMinuscula.Location = new Point(340, 217);
            btnMinuscula.Name = "btnMinuscula";
            btnMinuscula.Size = new Size(75, 23);
            btnMinuscula.TabIndex = 6;
            btnMinuscula.Text = "Minuscula";
            btnMinuscula.UseVisualStyleBackColor = true;
            btnMinuscula.Click += btnMinuscula_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 450);
            Controls.Add(btnMinuscula);
            Controls.Add(btnSubCadena);
            Controls.Add(btnMayuscula);
            Controls.Add(txtResult);
            Controls.Add(txtCadenaPrincipal);
            Controls.Add(blTitle2);
            Controls.Add(lblTitle1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle1;
        private Label blTitle2;
        private TextBox txtCadenaPrincipal;
        private TextBox txtResult;
        private Button btnMayuscula;
        private Button btnSubCadena;
        private Button btnMinuscula;
    }
}
