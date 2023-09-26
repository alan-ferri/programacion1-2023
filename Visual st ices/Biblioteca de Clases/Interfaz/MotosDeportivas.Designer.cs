using System;

namespace Interfaz
{
    partial class MotosDeportivas
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textcilindrada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textmarca = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.textmodelo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.Codigo = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(39, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 57);
            this.button3.TabIndex = 43;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(509, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 55);
            this.button2.TabIndex = 42;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textcilindrada
            // 
            this.textcilindrada.Location = new System.Drawing.Point(156, 164);
            this.textcilindrada.Margin = new System.Windows.Forms.Padding(2);
            this.textcilindrada.Name = "textcilindrada";
            this.textcilindrada.Size = new System.Drawing.Size(165, 20);
            this.textcilindrada.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Cilindrada";
            // 
            // textmarca
            // 
            this.textmarca.Location = new System.Drawing.Point(156, 80);
            this.textmarca.Margin = new System.Windows.Forms.Padding(2);
            this.textmarca.Name = "textmarca";
            this.textmarca.Size = new System.Drawing.Size(165, 20);
            this.textmarca.TabIndex = 39;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(22, 80);
            this.Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(37, 13);
            this.Nombre.TabIndex = 38;
            this.Nombre.Text = "Marca";
            // 
            // textmodelo
            // 
            this.textmodelo.Location = new System.Drawing.Point(156, 122);
            this.textmodelo.Margin = new System.Windows.Forms.Padding(2);
            this.textmodelo.Name = "textmodelo";
            this.textmodelo.Size = new System.Drawing.Size(165, 20);
            this.textmodelo.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Modelo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(156, 38);
            this.textid.Margin = new System.Windows.Forms.Padding(2);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(165, 20);
            this.textid.TabIndex = 35;
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Location = new System.Drawing.Point(22, 38);
            this.Codigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(18, 13);
            this.Codigo.TabIndex = 34;
            this.Codigo.Text = "ID";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(327, 38);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(335, 264);
            this.listBox1.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 58);
            this.button1.TabIndex = 30;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MotosDeportivas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textcilindrada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textmarca);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.textmodelo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "MotosDeportivas";
            this.Text = "MotosDerpotivas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textcilindrada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textmarca;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox textmodelo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}