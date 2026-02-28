namespace CalcularNotaFinal
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
            lblTitulo = new Label();
            lblNota1 = new Label();
            lblNota2 = new Label();
            lblNota3 = new Label();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            btnCalcularNota = new Button();
            btnParOImpar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(72, 26);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(206, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "¡Calcular Nota FINAL!";
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNota1.Location = new Point(106, 60);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(57, 17);
            lblNota1.TabIndex = 1;
            lblNota1.Text = "Nota #1";
            // 
            // lblNota2
            // 
            lblNota2.AutoSize = true;
            lblNota2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNota2.Location = new Point(106, 123);
            lblNota2.Name = "lblNota2";
            lblNota2.Size = new Size(57, 17);
            lblNota2.TabIndex = 2;
            lblNota2.Text = "Nota #2";
            // 
            // lblNota3
            // 
            lblNota3.AutoSize = true;
            lblNota3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNota3.Location = new Point(106, 189);
            lblNota3.Name = "lblNota3";
            lblNota3.Size = new Size(57, 17);
            lblNota3.TabIndex = 3;
            lblNota3.Text = "Nota #3";
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(106, 80);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(131, 23);
            txtNota1.TabIndex = 4;
            txtNota1.TextChanged += textBox1_TextChanged;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(106, 143);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(131, 23);
            txtNota2.TabIndex = 5;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(106, 209);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(131, 23);
            txtNota3.TabIndex = 6;
            // 
            // btnCalcularNota
            // 
            btnCalcularNota.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcularNota.Location = new Point(12, 274);
            btnCalcularNota.Name = "btnCalcularNota";
            btnCalcularNota.Size = new Size(131, 23);
            btnCalcularNota.TabIndex = 7;
            btnCalcularNota.Text = "Calcular Nota";
            btnCalcularNota.UseVisualStyleBackColor = true;
            btnCalcularNota.Click += btnCalcularNota_Click;
            // 
            // btnParOImpar
            // 
            btnParOImpar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnParOImpar.Location = new Point(199, 274);
            btnParOImpar.Name = "btnParOImpar";
            btnParOImpar.Size = new Size(131, 23);
            btnParOImpar.TabIndex = 8;
            btnParOImpar.Text = "Par o Impar";
            btnParOImpar.UseVisualStyleBackColor = true;
            btnParOImpar.Click += btnParOImpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(353, 422);
            Controls.Add(btnParOImpar);
            Controls.Add(btnCalcularNota);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(lblNota3);
            Controls.Add(lblNota2);
            Controls.Add(lblNota1);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Calcular nota final";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNota1;
        private Label lblNota2;
        private Label lblNota3;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private Button btnCalcularNota;
        private Button btnParOImpar;
    }
}
