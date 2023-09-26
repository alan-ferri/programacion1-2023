using System;

namespace FormsElectronica
{
    partial class MenuPrincipal
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
            this.btnSmart = new System.Windows.Forms.Button();
            this.btnTele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSmart
            // 
            this.btnSmart.Location = new System.Drawing.Point(463, 112);
            this.btnSmart.Margin = new System.Windows.Forms.Padding(2);
            this.btnSmart.Name = "btnSmart";
            this.btnSmart.Size = new System.Drawing.Size(197, 135);
            this.btnSmart.TabIndex = 3;
            this.btnSmart.Text = "Smartphones";
            this.btnSmart.UseVisualStyleBackColor = true;
            this.btnSmart.Click += new System.EventHandler(this.Smartphones);
            // 
            // btnTele
            // 
            this.btnTele.Location = new System.Drawing.Point(63, 112);
            this.btnTele.Margin = new System.Windows.Forms.Padding(2);
            this.btnTele.Name = "btnTele";
            this.btnTele.Size = new System.Drawing.Size(197, 135);
            this.btnTele.TabIndex = 2;
            this.btnTele.Text = "Televisores";
            this.btnTele.UseVisualStyleBackColor = true;
            this.btnTele.Click += new System.EventHandler(this.televisores1);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSmart);
            this.Controls.Add(this.btnTele);
            this.Name = "MenuPrincipal";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);

        }

        private void Smartphones(object sender, EventArgs e)
        {
            Smartphones smartphones = new Smartphones();
            smartphones.Show();
        }

        private void televisores1(object sender, EventArgs e)
        {
            Televisores televisores = new Televisores();
            televisores.Show();
        }

        private void Smartg(object sender, EventArgs e) => throw new NotImplementedException();

        #endregion

        private System.Windows.Forms.Button btnSmart;
        private System.Windows.Forms.Button btnTele;
    }
}