namespace Funciones
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
            btnButtonSaludar = new Button();
            lblValor1 = new Label();
            lblValor2 = new Label();
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            SuspendLayout();
            // 
            // btnButtonSaludar
            // 
            btnButtonSaludar.Location = new Point(73, 216);
            btnButtonSaludar.Name = "btnButtonSaludar";
            btnButtonSaludar.Size = new Size(75, 23);
            btnButtonSaludar.TabIndex = 0;
            btnButtonSaludar.Text = "Sumar";
            btnButtonSaludar.UseVisualStyleBackColor = true;
            btnButtonSaludar.Click += btnButtonSaludar_Click;
            // 
            // lblValor1
            // 
            lblValor1.AutoSize = true;
            lblValor1.Location = new Point(32, 76);
            lblValor1.Name = "lblValor1";
            lblValor1.Size = new Size(90, 15);
            lblValor1.TabIndex = 1;
            lblValor1.Text = "Ingrese valor #1";
            // 
            // lblValor2
            // 
            lblValor2.AutoSize = true;
            lblValor2.Location = new Point(32, 146);
            lblValor2.Name = "lblValor2";
            lblValor2.Size = new Size(90, 15);
            lblValor2.TabIndex = 2;
            lblValor2.Text = "Ingrese valor #2";
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(32, 103);
            txtValor1.Name = "txtValor1";
            txtValor1.PlaceholderText = "Ingrese un valor";
            txtValor1.Size = new Size(143, 23);
            txtValor1.TabIndex = 3;
            txtValor1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(32, 173);
            txtValor2.Name = "txtValor2";
            txtValor2.PlaceholderText = "Ingrese un valor";
            txtValor2.Size = new Size(143, 23);
            txtValor2.TabIndex = 4;
            txtValor2.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 450);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Controls.Add(lblValor2);
            Controls.Add(lblValor1);
            Controls.Add(btnButtonSaludar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnButtonSaludar;
        private Label lblValor1;
        private Label lblValor2;
        private TextBox txtValor1;
        private TextBox txtValor2;
    }
}
