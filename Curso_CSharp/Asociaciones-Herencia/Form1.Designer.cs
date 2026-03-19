namespace Asociaciones_Herencia
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
            lblNombres = new Label();
            btnCrearVenta = new Button();
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            lblApellidos = new Label();
            txtNumId = new TextBox();
            lblNumId = new Label();
            txtCelular = new TextBox();
            lblCelular = new Label();
            txtTotalVenta = new TextBox();
            label1 = new Label();
            lblMensajes = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(49, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(154, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CREAR VENTA";
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombres.Location = new Point(27, 52);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(80, 21);
            lblNombres.TabIndex = 1;
            lblNombres.Text = "Nombres";
            // 
            // btnCrearVenta
            // 
            btnCrearVenta.Location = new Point(62, 400);
            btnCrearVenta.Name = "btnCrearVenta";
            btnCrearVenta.Size = new Size(124, 38);
            btnCrearVenta.TabIndex = 2;
            btnCrearVenta.Text = "Crear Venta";
            btnCrearVenta.UseVisualStyleBackColor = true;
            btnCrearVenta.Click += btnCrearVenta_Click;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(27, 76);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(200, 23);
            txtNombres.TabIndex = 3;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(27, 136);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(200, 23);
            txtApellidos.TabIndex = 5;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellidos.Location = new Point(27, 112);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(82, 21);
            lblApellidos.TabIndex = 4;
            lblApellidos.Text = "Apellidos";
            // 
            // txtNumId
            // 
            txtNumId.Location = new Point(27, 197);
            txtNumId.Name = "txtNumId";
            txtNumId.Size = new Size(200, 23);
            txtNumId.TabIndex = 7;
            // 
            // lblNumId
            // 
            lblNumId.AutoSize = true;
            lblNumId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumId.Location = new Point(27, 173);
            lblNumId.Name = "lblNumId";
            lblNumId.Size = new Size(67, 21);
            lblNumId.TabIndex = 6;
            lblNumId.Text = "Num Id";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(27, 257);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(200, 23);
            txtCelular.TabIndex = 9;
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCelular.Location = new Point(27, 233);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(64, 21);
            lblCelular.TabIndex = 8;
            lblCelular.Text = "Celular";
            // 
            // txtTotalVenta
            // 
            txtTotalVenta.Location = new Point(27, 313);
            txtTotalVenta.Name = "txtTotalVenta";
            txtTotalVenta.Size = new Size(200, 23);
            txtTotalVenta.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(27, 289);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 10;
            label1.Text = "Total Venta";
            // 
            // lblMensajes
            // 
            lblMensajes.AutoSize = true;
            lblMensajes.Location = new Point(12, 355);
            lblMensajes.Name = "lblMensajes";
            lblMensajes.Size = new Size(16, 15);
            lblMensajes.TabIndex = 12;
            lblMensajes.Text = "...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 450);
            Controls.Add(lblMensajes);
            Controls.Add(txtTotalVenta);
            Controls.Add(label1);
            Controls.Add(txtCelular);
            Controls.Add(lblCelular);
            Controls.Add(txtNumId);
            Controls.Add(lblNumId);
            Controls.Add(txtApellidos);
            Controls.Add(lblApellidos);
            Controls.Add(txtNombres);
            Controls.Add(btnCrearVenta);
            Controls.Add(lblNombres);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombres;
        private Button btnCrearVenta;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private Label lblApellidos;
        private TextBox txtNumId;
        private Label lblNumId;
        private TextBox txtCelular;
        private Label lblCelular;
        private TextBox txtTotalVenta;
        private Label label1;
        private Label lblMensajes;
    }
}
