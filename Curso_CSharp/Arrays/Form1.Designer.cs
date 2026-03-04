namespace Arrays
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
            liPersonajes = new ListBox();
            liEquipos = new ListBox();
            btnListarPersonajes = new Button();
            btnListarEquipos = new Button();
            SuspendLayout();
            // 
            // liPersonajes
            // 
            liPersonajes.FormattingEnabled = true;
            liPersonajes.Location = new Point(44, 113);
            liPersonajes.Name = "liPersonajes";
            liPersonajes.Size = new Size(197, 214);
            liPersonajes.TabIndex = 0;
            // 
            // liEquipos
            // 
            liEquipos.FormattingEnabled = true;
            liEquipos.Location = new Point(381, 113);
            liEquipos.Name = "liEquipos";
            liEquipos.Size = new Size(197, 214);
            liEquipos.TabIndex = 1;
            // 
            // btnListarPersonajes
            // 
            btnListarPersonajes.Location = new Point(44, 345);
            btnListarPersonajes.Name = "btnListarPersonajes";
            btnListarPersonajes.Size = new Size(197, 23);
            btnListarPersonajes.TabIndex = 2;
            btnListarPersonajes.Text = "Listar Personajes";
            btnListarPersonajes.UseVisualStyleBackColor = true;
            btnListarPersonajes.Click += btnListarPersonajes_Click;
            // 
            // btnListarEquipos
            // 
            btnListarEquipos.Location = new Point(381, 345);
            btnListarEquipos.Name = "btnListarEquipos";
            btnListarEquipos.Size = new Size(197, 23);
            btnListarEquipos.TabIndex = 3;
            btnListarEquipos.Text = "Listar Equipos";
            btnListarEquipos.UseVisualStyleBackColor = true;
            btnListarEquipos.Click += btnListarEquipos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 450);
            Controls.Add(btnListarEquipos);
            Controls.Add(btnListarPersonajes);
            Controls.Add(liEquipos);
            Controls.Add(liPersonajes);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox liPersonajes;
        private ListBox liEquipos;
        private Button btnListarPersonajes;
        private Button btnListarEquipos;
    }
}
