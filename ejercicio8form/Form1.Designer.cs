namespace ejercicio8form
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
            brnformula = new Button();
            btncancelar = new Button();
            btnsalir = new Button();
            TEXT = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // brnformula
            // 
            brnformula.Location = new Point(335, 208);
            brnformula.Name = "brnformula";
            brnformula.Size = new Size(112, 34);
            brnformula.TabIndex = 0;
            brnformula.Text = "FORMULA";
            brnformula.UseVisualStyleBackColor = true;
            brnformula.Click += brnformula_Click;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(580, 104);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(112, 34);
            btncancelar.TabIndex = 1;
            btncancelar.Text = "CANCELAR";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(649, 404);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(112, 34);
            btnsalir.TabIndex = 2;
            btnsalir.Text = "SALIR";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // TEXT
            // 
            TEXT.AutoSize = true;
            TEXT.Location = new Point(165, 104);
            TEXT.Name = "TEXT";
            TEXT.Size = new Size(113, 25);
            TEXT.TabIndex = 3;
            TEXT.Text = "Ingrese un N";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(319, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(TEXT);
            Controls.Add(btnsalir);
            Controls.Add(btncancelar);
            Controls.Add(brnformula);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button brnformula;
        private Button btncancelar;
        private Button btnsalir;
        private Label TEXT;
        private TextBox textBox1;
    }
}