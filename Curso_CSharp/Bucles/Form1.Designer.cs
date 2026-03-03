namespace Bucles
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
            liTablas = new ListBox();
            txtValorIngresado = new TextBox();
            btnProcesar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(68, 50);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(91, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Ingresa un valor";
            // 
            // liTablas
            // 
            liTablas.FormattingEnabled = true;
            liTablas.Location = new Point(28, 213);
            liTablas.Name = "liTablas";
            liTablas.Size = new Size(173, 229);
            liTablas.TabIndex = 1;
            // 
            // txtValorIngresado
            // 
            txtValorIngresado.Location = new Point(28, 79);
            txtValorIngresado.Name = "txtValorIngresado";
            txtValorIngresado.Size = new Size(173, 23);
            txtValorIngresado.TabIndex = 2;
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(28, 135);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(173, 23);
            btnProcesar.TabIndex = 3;
            btnProcesar.Text = "Procesar";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(232, 450);
            Controls.Add(btnProcesar);
            Controls.Add(txtValorIngresado);
            Controls.Add(liTablas);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private ListBox liTablas;
        private TextBox txtValorIngresado;
        private Button btnProcesar;
    }
}
