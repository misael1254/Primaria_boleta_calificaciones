namespace Primaria
{
    partial class Listado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listado));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listgrupo = new System.Windows.Forms.ListBox();
            this.listado_grid = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bimestre_CB = new System.Windows.Forms.ComboBox();
            this.pdf = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tipo_CB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mes_cb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listado_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(539, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTADO DE ALUMNOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(637, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "A continuación seleccione un grupo por favor.";
            // 
            // listgrupo
            // 
            this.listgrupo.FormattingEnabled = true;
            this.listgrupo.Items.AddRange(new object[] {
            "Primero",
            "Segundo",
            "Tercero",
            "Cuarto",
            "Quinto",
            "Sexto"});
            this.listgrupo.Location = new System.Drawing.Point(401, 139);
            this.listgrupo.Name = "listgrupo";
            this.listgrupo.Size = new System.Drawing.Size(120, 30);
            this.listgrupo.TabIndex = 2;
            // 
            // listado_grid
            // 
            this.listado_grid.AllowUserToAddRows = false;
            this.listado_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listado_grid.Location = new System.Drawing.Point(30, 282);
            this.listado_grid.Name = "listado_grid";
            this.listado_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.listado_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listado_grid.Size = new System.Drawing.Size(1273, 332);
            this.listado_grid.TabIndex = 4;
            this.listado_grid.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.listado_grid_RowPostPaint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(875, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(732, 620);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(80, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(106, 84);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // bimestre_CB
            // 
            this.bimestre_CB.FormattingEnabled = true;
            this.bimestre_CB.Items.AddRange(new object[] {
            "Primer Bimestre",
            "Segundo Bimestre",
            "Tercer Bimestre",
            "Cuarto Bimestre",
            "Quinto Bimestre",
            "Sexto Bimestre"});
            this.bimestre_CB.Location = new System.Drawing.Point(400, 185);
            this.bimestre_CB.Name = "bimestre_CB";
            this.bimestre_CB.Size = new System.Drawing.Size(121, 21);
            this.bimestre_CB.TabIndex = 8;
            this.bimestre_CB.SelectedIndexChanged += new System.EventHandler(this.bimestre_CB_SelectedIndexChanged);
            // 
            // pdf
            // 
            this.pdf.Location = new System.Drawing.Point(557, 251);
            this.pdf.Name = "pdf";
            this.pdf.Size = new System.Drawing.Size(95, 23);
            this.pdf.TabIndex = 9;
            this.pdf.Text = "Generar PDF";
            this.pdf.UseVisualStyleBackColor = true;
            this.pdf.Click += new System.EventHandler(this.pdf_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seleccione un bimestre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(592, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Seleccione un tipo:";
            // 
            // tipo_CB
            // 
            this.tipo_CB.FormattingEnabled = true;
            this.tipo_CB.Items.AddRange(new object[] {
            "Interno",
            "Externo"});
            this.tipo_CB.Location = new System.Drawing.Point(764, 138);
            this.tipo_CB.Name = "tipo_CB";
            this.tipo_CB.Size = new System.Drawing.Size(121, 21);
            this.tipo_CB.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(565, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "o Seleccione un mes";
            // 
            // mes_cb
            // 
            this.mes_cb.FormattingEnabled = true;
            this.mes_cb.Items.AddRange(new object[] {
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre",
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio"});
            this.mes_cb.Location = new System.Drawing.Point(764, 185);
            this.mes_cb.Name = "mes_cb";
            this.mes_cb.Size = new System.Drawing.Size(121, 21);
            this.mes_cb.TabIndex = 14;
            this.mes_cb.SelectedIndexChanged += new System.EventHandler(this.mes_cb_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(215, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Seleccione un grado:";
            // 
            // Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1330, 724);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mes_cb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tipo_CB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pdf);
            this.Controls.Add(this.bimestre_CB);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listado_grid);
            this.Controls.Add(this.listgrupo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Listado";
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.Listado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listado_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listgrupo;
        private System.Windows.Forms.DataGridView listado_grid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox bimestre_CB;
        private System.Windows.Forms.Button pdf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tipo_CB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox mes_cb;
        private System.Windows.Forms.Label label6;
    }
}