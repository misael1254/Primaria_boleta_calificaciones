namespace Primaria
{
    partial class ConsultaCalificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaCalificaciones));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cb_grad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cb_mes = new System.Windows.Forms.ComboBox();
            this.alumnodgv = new System.Windows.Forms.DataGridView();
            this.Califdgv = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.calsep = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.calext = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alumnodgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Califdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(450, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta de Calificaciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione un grado";
            // 
            // Cb_grad
            // 
            this.Cb_grad.FormattingEnabled = true;
            this.Cb_grad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.Cb_grad.Location = new System.Drawing.Point(514, 74);
            this.Cb_grad.Name = "Cb_grad";
            this.Cb_grad.Size = new System.Drawing.Size(121, 21);
            this.Cb_grad.TabIndex = 2;
            this.Cb_grad.SelectedIndexChanged += new System.EventHandler(this.Cb_grad_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(677, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seleccione un mes:";
            // 
            // Cb_mes
            // 
            this.Cb_mes.FormattingEnabled = true;
            this.Cb_mes.Items.AddRange(new object[] {
            "Diag",
            "Sept",
            "Octu",
            "Novi",
            "Dici",
            "Ener",
            "Febr",
            "Marz",
            "Abri",
            "Mayo",
            "Juni"});
            this.Cb_mes.Location = new System.Drawing.Point(830, 74);
            this.Cb_mes.Name = "Cb_mes";
            this.Cb_mes.Size = new System.Drawing.Size(121, 21);
            this.Cb_mes.TabIndex = 4;
            // 
            // alumnodgv
            // 
            this.alumnodgv.AllowUserToAddRows = false;
            this.alumnodgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alumnodgv.Location = new System.Drawing.Point(235, 138);
            this.alumnodgv.Name = "alumnodgv";
            this.alumnodgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.alumnodgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.alumnodgv.Size = new System.Drawing.Size(877, 213);
            this.alumnodgv.TabIndex = 5;
            this.alumnodgv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.alumnodgv_CellMouseClick);
            this.alumnodgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.alumnodgv_RowPostPaint);
            // 
            // Califdgv
            // 
            this.Califdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Califdgv.Location = new System.Drawing.Point(370, 403);
            this.Califdgv.Name = "Califdgv";
            this.Califdgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.Califdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Califdgv.Size = new System.Drawing.Size(637, 237);
            this.Califdgv.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(614, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lista de alumnos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(624, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Calificaciones";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(114, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1013, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Promedio Materias SEP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1013, 521);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Promedio Materias EXT:";
            // 
            // calsep
            // 
            this.calsep.AutoSize = true;
            this.calsep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calsep.Location = new System.Drawing.Point(1187, 447);
            this.calsep.Name = "calsep";
            this.calsep.Size = new System.Drawing.Size(0, 16);
            this.calsep.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(626, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 13;
            // 
            // calext
            // 
            this.calext.AutoSize = true;
            this.calext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calext.Location = new System.Drawing.Point(1187, 521);
            this.calext.Name = "calext";
            this.calext.Size = new System.Drawing.Size(0, 16);
            this.calext.TabIndex = 14;
            // 
            // ConsultaCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1252, 652);
            this.Controls.Add(this.calext);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.calsep);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Califdgv);
            this.Controls.Add(this.alumnodgv);
            this.Controls.Add(this.Cb_mes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cb_grad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConsultaCalificaciones";
            this.Text = "ConsultaCalificaciones";
            this.Load += new System.EventHandler(this.ConsultaCalificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alumnodgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Califdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cb_grad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cb_mes;
        private System.Windows.Forms.DataGridView alumnodgv;
        private System.Windows.Forms.DataGridView Califdgv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label calsep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label calext;
    }
}