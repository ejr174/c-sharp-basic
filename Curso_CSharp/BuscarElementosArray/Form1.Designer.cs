namespace BuscarElementosArray
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
            lblPrincipalTitle = new Label();
            txtEncontrar = new TextBox();
            btnEncontrar = new Button();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // lblPrincipalTitle
            // 
            lblPrincipalTitle.AutoSize = true;
            lblPrincipalTitle.Font = new Font("Matura MT Script Capitals", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrincipalTitle.Location = new Point(64, 36);
            lblPrincipalTitle.Name = "lblPrincipalTitle";
            lblPrincipalTitle.Size = new Size(232, 25);
            lblPrincipalTitle.TabIndex = 0;
            lblPrincipalTitle.Text = "Encuentra tú compañero!";
            // 
            // txtEncontrar
            // 
            txtEncontrar.Location = new Point(64, 79);
            txtEncontrar.Name = "txtEncontrar";
            txtEncontrar.PlaceholderText = "Ingresa un nombre";
            txtEncontrar.Size = new Size(232, 23);
            txtEncontrar.TabIndex = 1;
            // 
            // btnEncontrar
            // 
            btnEncontrar.Location = new Point(121, 128);
            btnEncontrar.Name = "btnEncontrar";
            btnEncontrar.Size = new Size(98, 26);
            btnEncontrar.TabIndex = 2;
            btnEncontrar.Text = "Encontrar";
            btnEncontrar.UseVisualStyleBackColor = true;
            btnEncontrar.Click += btnEncontrar_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.Location = new Point(150, 187);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(40, 15);
            lblMensaje.TabIndex = 3;
            lblMensaje.Text = "label1";
            lblMensaje.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 248);
            Controls.Add(lblMensaje);
            Controls.Add(btnEncontrar);
            Controls.Add(txtEncontrar);
            Controls.Add(lblPrincipalTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrincipalTitle;
        private TextBox txtEncontrar;
        private Button btnEncontrar;
        private Label lblMensaje;
    }
}
