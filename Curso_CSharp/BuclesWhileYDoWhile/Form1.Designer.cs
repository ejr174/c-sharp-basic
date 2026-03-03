namespace BuclesWhileYDoWhile
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
            txtIngreseValor = new TextBox();
            lblTitulo = new Label();
            btnProcesar = new Button();
            liMensajes = new ListBox();
            SuspendLayout();
            // 
            // txtIngreseValor
            // 
            txtIngreseValor.Location = new Point(68, 112);
            txtIngreseValor.Name = "txtIngreseValor";
            txtIngreseValor.Size = new Size(203, 23);
            txtIngreseValor.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(120, 94);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(91, 15);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Ingrese un valor";
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(120, 164);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(75, 23);
            btnProcesar.TabIndex = 2;
            btnProcesar.Text = "Procesar";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // liMensajes
            // 
            liMensajes.FormattingEnabled = true;
            liMensajes.Location = new Point(68, 226);
            liMensajes.Name = "liMensajes";
            liMensajes.Size = new Size(203, 94);
            liMensajes.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 450);
            Controls.Add(liMensajes);
            Controls.Add(btnProcesar);
            Controls.Add(lblTitulo);
            Controls.Add(txtIngreseValor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIngreseValor;
        private Label lblTitulo;
        private Button btnProcesar;
        private ListBox liMensajes;
    }
}
