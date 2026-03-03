namespace CondicionalSwitch
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
            txtValorIngresado = new TextBox();
            btnIngresarValor = new Button();
            lblTituloMes = new Label();
            cmbMesSeleccionado = new ComboBox();
            txtMesIngresado = new TextBox();
            lblMes = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(44, 54);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(234, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Ingrese un valor entre 1 y 100";
            // 
            // txtValorIngresado
            // 
            txtValorIngresado.Location = new Point(44, 91);
            txtValorIngresado.Name = "txtValorIngresado";
            txtValorIngresado.Size = new Size(234, 23);
            txtValorIngresado.TabIndex = 1;
            txtValorIngresado.TextAlign = HorizontalAlignment.Center;
            // 
            // btnIngresarValor
            // 
            btnIngresarValor.Location = new Point(121, 134);
            btnIngresarValor.Name = "btnIngresarValor";
            btnIngresarValor.Size = new Size(75, 23);
            btnIngresarValor.TabIndex = 2;
            btnIngresarValor.Text = "Ingresar";
            btnIngresarValor.UseVisualStyleBackColor = true;
            btnIngresarValor.Click += btnIngresarValor_Click;
            // 
            // lblTituloMes
            // 
            lblTituloMes.AutoSize = true;
            lblTituloMes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloMes.Location = new Point(65, 215);
            lblTituloMes.Name = "lblTituloMes";
            lblTituloMes.Size = new Size(193, 21);
            lblTituloMes.TabIndex = 3;
            lblTituloMes.Text = "Selecciones el # del mes";
            // 
            // cmbMesSeleccionado
            // 
            cmbMesSeleccionado.FormattingEnabled = true;
            cmbMesSeleccionado.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cmbMesSeleccionado.Location = new Point(44, 254);
            cmbMesSeleccionado.Name = "cmbMesSeleccionado";
            cmbMesSeleccionado.Size = new Size(234, 23);
            cmbMesSeleccionado.TabIndex = 4;
            cmbMesSeleccionado.SelectedIndexChanged += cmbMesSeleccionado_SelectedIndexChanged;
            // 
            // txtMesIngresado
            // 
            txtMesIngresado.Location = new Point(44, 317);
            txtMesIngresado.Name = "txtMesIngresado";
            txtMesIngresado.Size = new Size(234, 23);
            txtMesIngresado.TabIndex = 5;
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Location = new Point(141, 299);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(29, 15);
            lblMes.TabIndex = 6;
            lblMes.Text = "Mes";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 450);
            Controls.Add(lblMes);
            Controls.Add(txtMesIngresado);
            Controls.Add(cmbMesSeleccionado);
            Controls.Add(lblTituloMes);
            Controls.Add(btnIngresarValor);
            Controls.Add(txtValorIngresado);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtValorIngresado;
        private Button btnIngresarValor;
        private Label lblTituloMes;
        private ComboBox cmbMesSeleccionado;
        private TextBox txtMesIngresado;
        private Label lblMes;
    }
}
