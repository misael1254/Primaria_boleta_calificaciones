namespace Primaria
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.GUARDAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_entero = new System.Windows.Forms.ComboBox();
            this.cb_decimal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_apP = new System.Windows.Forms.TextBox();
            this.tb_apM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_periodo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.generarpdf_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "COMENZAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "grado";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox1.Location = new System.Drawing.Point(678, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(42, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Enabled = false;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(560, 247);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(221, 28);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // GUARDAR
            // 
            this.GUARDAR.Location = new System.Drawing.Point(949, 251);
            this.GUARDAR.Name = "GUARDAR";
            this.GUARDAR.Size = new System.Drawing.Size(75, 23);
            this.GUARDAR.TabIndex = 5;
            this.GUARDAR.Text = "GUARDAR";
            this.GUARDAR.UseVisualStyleBackColor = true;
            this.GUARDAR.Click += new System.EventHandler(this.GUARDAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(605, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "SELECCIONA GRADO";
            // 
            // cb_entero
            // 
            this.cb_entero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_entero.Enabled = false;
            this.cb_entero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_entero.FormattingEnabled = true;
            this.cb_entero.Location = new System.Drawing.Point(799, 247);
            this.cb_entero.Name = "cb_entero";
            this.cb_entero.Size = new System.Drawing.Size(52, 28);
            this.cb_entero.TabIndex = 7;
            this.cb_entero.SelectedIndexChanged += new System.EventHandler(this.cb_entero_SelectedIndexChanged);
            // 
            // cb_decimal
            // 
            this.cb_decimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_decimal.Enabled = false;
            this.cb_decimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_decimal.FormattingEnabled = true;
            this.cb_decimal.Location = new System.Drawing.Point(870, 246);
            this.cb_decimal.Name = "cb_decimal";
            this.cb_decimal.Size = new System.Drawing.Size(52, 28);
            this.cb_decimal.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(852, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "NOMBRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(813, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "APELLIDO PATERNO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(624, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "APELLIDO MATERNO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(792, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "INGRESE CALIFICACIÓN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(626, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "MATERIA";
            // 
            // tb_nombre
            // 
            this.tb_nombre.Enabled = false;
            this.tb_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nombre.Location = new System.Drawing.Point(388, 166);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(185, 26);
            this.tb_nombre.TabIndex = 15;
            // 
            // tb_apP
            // 
            this.tb_apP.Enabled = false;
            this.tb_apP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_apP.Location = new System.Drawing.Point(795, 166);
            this.tb_apP.Name = "tb_apP";
            this.tb_apP.Size = new System.Drawing.Size(154, 26);
            this.tb_apP.TabIndex = 16;
            // 
            // tb_apM
            // 
            this.tb_apM.Enabled = false;
            this.tb_apM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_apM.Location = new System.Drawing.Point(609, 166);
            this.tb_apM.Name = "tb_apM";
            this.tb_apM.Size = new System.Drawing.Size(154, 26);
            this.tb_apM.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "PERIODO";
            // 
            // cb_periodo
            // 
            this.cb_periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_periodo.Enabled = false;
            this.cb_periodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_periodo.FormattingEnabled = true;
            this.cb_periodo.Location = new System.Drawing.Point(345, 247);
            this.cb_periodo.Name = "cb_periodo";
            this.cb_periodo.Size = new System.Drawing.Size(176, 28);
            this.cb_periodo.TabIndex = 19;
            this.cb_periodo.SelectedIndexChanged += new System.EventHandler(this.cb_periodo_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(255, 290);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(881, 299);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1042, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "REINICIAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // generarpdf_btn
            // 
            this.generarpdf_btn.Location = new System.Drawing.Point(70, 59);
            this.generarpdf_btn.Name = "generarpdf_btn";
            this.generarpdf_btn.Size = new System.Drawing.Size(95, 23);
            this.generarpdf_btn.TabIndex = 22;
            this.generarpdf_btn.Text = "Generar Boleta";
            this.generarpdf_btn.UseVisualStyleBackColor = true;
            this.generarpdf_btn.Click += new System.EventHandler(this.generarpdf_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(534, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(286, 37);
            this.label9.TabIndex = 23;
            this.label9.Text = "CALIFICACIONES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(191, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1241, 714);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.generarpdf_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cb_periodo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_apM);
            this.Controls.Add(this.tb_apP);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_decimal);
            this.Controls.Add(this.cb_entero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GUARDAR);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Calificaciones";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        protected System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button GUARDAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_apP;
        private System.Windows.Forms.TextBox tb_apM;
        private System.Windows.Forms.Label label8;
        protected System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        protected internal System.Windows.Forms.ComboBox comboBox2;
        protected internal System.Windows.Forms.ComboBox cb_entero;
        protected internal System.Windows.Forms.ComboBox cb_decimal;
        protected internal System.Windows.Forms.ComboBox cb_periodo;
        private System.Windows.Forms.Button generarpdf_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}