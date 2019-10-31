namespace Primaria
{
    partial class Modificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Curp_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Ncurp_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NApp_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Apm_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NVnombre_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NTipoS_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Nenfer_txt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Modificar_pic = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Modificar_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(595, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "MODIFICACIONES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(490, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Introduzca la Curp:";
            // 
            // Curp_txt
            // 
            this.Curp_txt.Location = new System.Drawing.Point(649, 117);
            this.Curp_txt.Name = "Curp_txt";
            this.Curp_txt.Size = new System.Drawing.Size(100, 20);
            this.Curp_txt.TabIndex = 2;
            this.Curp_txt.TextChanged += new System.EventHandler(this.Curp_txt_TextChanged);
            this.Curp_txt.Leave += new System.EventHandler(this.Curp_txt_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(757, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "ó seleccione un grado:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.listBox1.Location = new System.Drawing.Point(944, 104);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 30);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(241, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Curp:";
            // 
            // Ncurp_txt
            // 
            this.Ncurp_txt.Location = new System.Drawing.Point(291, 156);
            this.Ncurp_txt.Name = "Ncurp_txt";
            this.Ncurp_txt.Size = new System.Drawing.Size(100, 20);
            this.Ncurp_txt.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(421, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Apellido Paterno:";
            // 
            // NApp_txt
            // 
            this.NApp_txt.Location = new System.Drawing.Point(547, 156);
            this.NApp_txt.Name = "NApp_txt";
            this.NApp_txt.Size = new System.Drawing.Size(100, 20);
            this.NApp_txt.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(676, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Apellido Materno:";
            // 
            // Apm_txt
            // 
            this.Apm_txt.Location = new System.Drawing.Point(805, 156);
            this.Apm_txt.Name = "Apm_txt";
            this.Apm_txt.Size = new System.Drawing.Size(100, 20);
            this.Apm_txt.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(941, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Nombre:";
            // 
            // NVnombre_txt
            // 
            this.NVnombre_txt.Location = new System.Drawing.Point(1010, 156);
            this.NVnombre_txt.Name = "NVnombre_txt";
            this.NVnombre_txt.Size = new System.Drawing.Size(100, 20);
            this.NVnombre_txt.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(241, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tipo de Sangre:";
            // 
            // NTipoS_txt
            // 
            this.NTipoS_txt.Location = new System.Drawing.Point(361, 198);
            this.NTipoS_txt.Name = "NTipoS_txt";
            this.NTipoS_txt.Size = new System.Drawing.Size(100, 20);
            this.NTipoS_txt.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(512, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Enfermedades o Alergias:";
            // 
            // Nenfer_txt
            // 
            this.Nenfer_txt.Location = new System.Drawing.Point(699, 188);
            this.Nenfer_txt.Multiline = true;
            this.Nenfer_txt.Name = "Nenfer_txt";
            this.Nenfer_txt.Size = new System.Drawing.Size(180, 63);
            this.Nenfer_txt.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(214, 292);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(996, 264);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1080, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Modificar_pic
            // 
            this.Modificar_pic.Image = ((System.Drawing.Image)(resources.GetObject("Modificar_pic.Image")));
            this.Modificar_pic.Location = new System.Drawing.Point(981, 199);
            this.Modificar_pic.Name = "Modificar_pic";
            this.Modificar_pic.Size = new System.Drawing.Size(100, 72);
            this.Modificar_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Modificar_pic.TabIndex = 20;
            this.Modificar_pic.TabStop = false;
            this.Modificar_pic.Click += new System.EventHandler(this.Modificar_pic_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(119, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1258, 568);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Modificar_pic);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Nenfer_txt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.NTipoS_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NVnombre_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Apm_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NApp_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Ncurp_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Curp_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Modificar";
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.Modificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Modificar_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Curp_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Ncurp_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NApp_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Apm_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NVnombre_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NTipoS_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Nenfer_txt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox Modificar_pic;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}