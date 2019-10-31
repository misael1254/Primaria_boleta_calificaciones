namespace Primaria
{
    partial class Validar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clave_txt = new System.Windows.Forms.TextBox();
            this.validar_btn = new System.Windows.Forms.Button();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Validar operación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave de autorización:";
            // 
            // clave_txt
            // 
            this.clave_txt.Location = new System.Drawing.Point(224, 105);
            this.clave_txt.Name = "clave_txt";
            this.clave_txt.Size = new System.Drawing.Size(100, 20);
            this.clave_txt.TabIndex = 2;
            // 
            // validar_btn
            // 
            this.validar_btn.Location = new System.Drawing.Point(94, 176);
            this.validar_btn.Name = "validar_btn";
            this.validar_btn.Size = new System.Drawing.Size(75, 23);
            this.validar_btn.TabIndex = 3;
            this.validar_btn.Text = "Validar";
            this.validar_btn.UseVisualStyleBackColor = true;
            this.validar_btn.Click += new System.EventHandler(this.validar_btn_Click);
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Location = new System.Drawing.Point(238, 176);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(75, 23);
            this.cancelar_btn.TabIndex = 4;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // Validar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(418, 261);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.validar_btn);
            this.Controls.Add(this.clave_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Validar";
            this.Text = "Validar";
            this.Load += new System.EventHandler(this.Validar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clave_txt;
        private System.Windows.Forms.Button validar_btn;
        private System.Windows.Forms.Button cancelar_btn;
    }
}