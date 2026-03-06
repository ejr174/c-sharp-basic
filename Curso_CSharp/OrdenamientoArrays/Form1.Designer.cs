namespace OrdenamientoArrays
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
            liDesordenada = new ListBox();
            liOrdenada = new ListBox();
            btnOrdenar = new Button();
            SuspendLayout();
            // 
            // liDesordenada
            // 
            liDesordenada.FormattingEnabled = true;
            liDesordenada.Location = new Point(15, 139);
            liDesordenada.Name = "liDesordenada";
            liDesordenada.Size = new Size(120, 139);
            liDesordenada.TabIndex = 0;
            // 
            // liOrdenada
            // 
            liOrdenada.FormattingEnabled = true;
            liOrdenada.Location = new Point(228, 139);
            liOrdenada.Name = "liOrdenada";
            liOrdenada.Size = new Size(120, 139);
            liOrdenada.TabIndex = 1;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(147, 57);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(75, 23);
            btnOrdenar.TabIndex = 2;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 320);
            Controls.Add(btnOrdenar);
            Controls.Add(liOrdenada);
            Controls.Add(liDesordenada);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox liDesordenada;
        private ListBox liOrdenada;
        private Button btnOrdenar;
    }
}
