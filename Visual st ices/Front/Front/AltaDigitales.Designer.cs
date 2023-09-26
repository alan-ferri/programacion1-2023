namespace Front
{
    partial class AltaDigitales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.texttamaño = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textNombre2 = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.textPrecio2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textCodigo2 = new System.Windows.Forms.TextBox();
            this.Codigo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Volver2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(331, 21);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(335, 264);
            this.listBox1.TabIndex = 16;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // texttamaño
            // 
            this.texttamaño.Location = new System.Drawing.Point(145, 175);
            this.texttamaño.Margin = new System.Windows.Forms.Padding(2);
            this.texttamaño.Name = "texttamaño";
            this.texttamaño.Size = new System.Drawing.Size(165, 20);
            this.texttamaño.TabIndex = 37;
            this.texttamaño.TextChanged += new System.EventHandler(this.textCantidad2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Tamaño Archivo";
            // 
            // textNombre2
            // 
            this.textNombre2.Location = new System.Drawing.Point(145, 91);
            this.textNombre2.Margin = new System.Windows.Forms.Padding(2);
            this.textNombre2.Name = "textNombre2";
            this.textNombre2.Size = new System.Drawing.Size(165, 20);
            this.textNombre2.TabIndex = 35;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(11, 91);
            this.Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 34;
            this.Nombre.Text = "Nombre";
            // 
            // textPrecio2
            // 
            this.textPrecio2.Location = new System.Drawing.Point(145, 133);
            this.textPrecio2.Margin = new System.Windows.Forms.Padding(2);
            this.textPrecio2.Name = "textPrecio2";
            this.textPrecio2.Size = new System.Drawing.Size(165, 20);
            this.textPrecio2.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Precio";
            // 
            // textCodigo2
            // 
            this.textCodigo2.Location = new System.Drawing.Point(145, 49);
            this.textCodigo2.Margin = new System.Windows.Forms.Padding(2);
            this.textCodigo2.Name = "textCodigo2";
            this.textCodigo2.Size = new System.Drawing.Size(165, 20);
            this.textCodigo2.TabIndex = 31;
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Location = new System.Drawing.Point(11, 49);
            this.Codigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(40, 13);
            this.Codigo.TabIndex = 30;
            this.Codigo.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 28;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(268, 347);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(132, 43);
            this.Guardar.TabIndex = 38;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(518, 340);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(130, 57);
            this.Eliminar.TabIndex = 39;
            this.Eliminar.Text = "Eiminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Volver2
            // 
            this.Volver2.Location = new System.Drawing.Point(30, 360);
            this.Volver2.Name = "Volver2";
            this.Volver2.Size = new System.Drawing.Size(95, 30);
            this.Volver2.TabIndex = 40;
            this.Volver2.Text = "Volver";
            this.Volver2.UseVisualStyleBackColor = true;
            this.Volver2.Click += new System.EventHandler(this.Volver2_Click);
            // 
            // AltaDigitales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Volver2);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.texttamaño);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textNombre2);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.textPrecio2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textCodigo2);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "AltaDigitales";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox texttamaño;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNombre2;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox textPrecio2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textCodigo2;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Volver2;
    }
}