namespace Primaria
{
    partial class RegistrarCalificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarCalificaciones));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Cb_Val1_ent = new System.Windows.Forms.ComboBox();
            this.CB_Val1_dec = new System.Windows.Forms.ComboBox();
            this.Cb_Val2_ent = new System.Windows.Forms.ComboBox();
            this.Cb_Val3_ent = new System.Windows.Forms.ComboBox();
            this.Cb_Val4_ent = new System.Windows.Forms.ComboBox();
            this.Cb_Val5_ent = new System.Windows.Forms.ComboBox();
            this.Cb_Val6_ent = new System.Windows.Forms.ComboBox();
            this.Cb_Val7_ent = new System.Windows.Forms.ComboBox();
            this.Cb_Val8_ent = new System.Windows.Forms.ComboBox();
            this.Cb_Val9_ent = new System.Windows.Forms.ComboBox();
            this.Cb_Val10_ent = new System.Windows.Forms.ComboBox();
            this.Cb_Val11_ent = new System.Windows.Forms.ComboBox();
            this.Cb_Val12_ent = new System.Windows.Forms.ComboBox();
            this.Cb_Val13_ent = new System.Windows.Forms.ComboBox();
            this.CB_Val2_dec = new System.Windows.Forms.ComboBox();
            this.CB_Val3_dec = new System.Windows.Forms.ComboBox();
            this.CB_Val4_dec = new System.Windows.Forms.ComboBox();
            this.CB_Val5_dec = new System.Windows.Forms.ComboBox();
            this.CB_Val6_dec = new System.Windows.Forms.ComboBox();
            this.CB_Val7_dec = new System.Windows.Forms.ComboBox();
            this.CB_Val8_dec = new System.Windows.Forms.ComboBox();
            this.CB_Val9_dec = new System.Windows.Forms.ComboBox();
            this.CB_Val10_dec = new System.Windows.Forms.ComboBox();
            this.CB_Val11_dec = new System.Windows.Forms.ComboBox();
            this.CB_Val12_dec = new System.Windows.Forms.ComboBox();
            this.CB_Val13_dec = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(537, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Calificaciones";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox1.Location = new System.Drawing.Point(206, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione un grado:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(573, 199);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(399, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mes a evaluar:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(528, 85);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seleccione un mes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Seleccione un mes:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Seleccione un mes:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Seleccione un mes:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Seleccione un mes:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "Seleccione un mes:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = "Seleccione un mes:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 18);
            this.label11.TabIndex = 13;
            this.label11.Text = "Seleccione un mes:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 18);
            this.label12.TabIndex = 14;
            this.label12.Text = "Seleccione un mes:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 276);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(163, 18);
            this.label13.TabIndex = 15;
            this.label13.Text = "Seleccione un mes:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 304);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 18);
            this.label14.TabIndex = 16;
            this.label14.Text = "Seleccione un mes:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(18, 333);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(163, 18);
            this.label15.TabIndex = 17;
            this.label15.Text = "Seleccione un mes:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(18, 361);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(163, 18);
            this.label16.TabIndex = 18;
            this.label16.Text = "Seleccione un mes:";
            // 
            // Cb_Val1_ent
            // 
            this.Cb_Val1_ent.FormattingEnabled = true;
            this.Cb_Val1_ent.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Cb_Val1_ent.Location = new System.Drawing.Point(379, 17);
            this.Cb_Val1_ent.Name = "Cb_Val1_ent";
            this.Cb_Val1_ent.Size = new System.Drawing.Size(43, 21);
            this.Cb_Val1_ent.TabIndex = 19;
            this.Cb_Val1_ent.SelectedIndexChanged += new System.EventHandler(this.Cb_Val1_ent_SelectedIndexChanged);
            // 
            // CB_Val1_dec
            // 
            this.CB_Val1_dec.FormattingEnabled = true;
            this.CB_Val1_dec.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.CB_Val1_dec.Location = new System.Drawing.Point(451, 17);
            this.CB_Val1_dec.Name = "CB_Val1_dec";
            this.CB_Val1_dec.Size = new System.Drawing.Size(43, 21);
            this.CB_Val1_dec.TabIndex = 20;
            // 
            // Cb_Val2_ent
            // 
            this.Cb_Val2_ent.FormattingEnabled = true;
            this.Cb_Val2_ent.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Cb_Val2_ent.Location = new System.Drawing.Point(379, 45);
            this.Cb_Val2_ent.Name = "Cb_Val2_ent";
            this.Cb_Val2_ent.Size = new System.Drawing.Size(43, 21);
            this.Cb_Val2_ent.TabIndex = 21;
            this.Cb_Val2_ent.SelectedIndexChanged += new System.EventHandler(this.Cb_Val2_ent_SelectedIndexChanged);
            // 
            // Cb_Val3_ent
            // 
            this.Cb_Val3_ent.FormattingEnabled = true;
            this.Cb_Val3_ent.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Cb_Val3_ent.Location = new System.Drawing.Point(379, 75);
            this.Cb_Val3_ent.Name = "Cb_Val3_ent";
            this.Cb_Val3_ent.Size = new System.Drawing.Size(43, 21);
            this.Cb_Val3_ent.TabIndex = 23;
            this.Cb_Val3_ent.SelectedIndexChanged += new System.EventHandler(this.Cb_Val3_ent_SelectedIndexChanged);
            // 
            // Cb_Val4_ent
            // 
            this.Cb_Val4_ent.FormattingEnabled = true;
            this.Cb_Val4_ent.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Cb_Val4_ent.Location = new System.Drawing.Point(379, 102);
            this.Cb_Val4_ent.Name = "Cb_Val4_ent";
            this.Cb_Val4_ent.Size = new System.Drawing.Size(43, 21);
            this.Cb_Val4_ent.TabIndex = 26;
            this.Cb_Val4_ent.SelectedIndexChanged += new System.EventHandler(this.Cb_Val4_ent_SelectedIndexChanged);
            // 
            // Cb_Val5_ent
            // 
            this.Cb_Val5_ent.FormattingEnabled = true;
            this.Cb_Val5_ent.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Cb_Val5_ent.Location = new System.Drawing.Point(379, 132);
            this.Cb_Val5_ent.Name = "Cb_Val5_ent";
            this.Cb_Val5_ent.Size = new System.Drawing.Size(43, 21);
            this.Cb_Val5_ent.TabIndex = 28;
            this.Cb_Val5_ent.SelectedIndexChanged += new System.EventHandler(this.Cb_Val5_ent_SelectedIndexChanged);
            // 
            // Cb_Val6_ent
            // 
            this.Cb_Val6_ent.FormattingEnabled = true;
            this.Cb_Val6_ent.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Cb_Val6_ent.Location = new System.Drawing.Point(379, 161);
            this.Cb_Val6_ent.Name = "Cb_Val6_ent";
            this.Cb_Val6_ent.Size = new System.Drawing.Size(43, 21);
            this.Cb_Val6_ent.TabIndex = 30;
            this.Cb_Val6_ent.SelectedIndexChanged += new System.EventHandler(this.Cb_Val6_ent_SelectedIndexChanged);
            // 
            // Cb_Val7_ent
            // 
            this.Cb_Val7_ent.FormattingEnabled = true;
            this.Cb_Val7_ent.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Cb_Val7_ent.Location = new System.Drawing.Point(379, 191);
            this.Cb_Val7_ent.Name = "Cb_Val7_ent";
            this.Cb_Val7_ent.Size = new System.Drawing.Size(43, 21);
            this.Cb_Val7_ent.TabIndex = 32;
            this.Cb_Val7_ent.SelectedIndexChanged += new System.EventHandler(this.Cb_Val7_ent_SelectedIndexChanged);
            // 
            // Cb_Val8_ent
            // 
            this.Cb_Val8_ent.FormattingEnabled = true;
            this.Cb_Val8_ent.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Cb_Val8_ent.Location = new System.Drawing.Point(379, 220);
            this.Cb_Val8_ent.Name = "Cb_Val8_ent";
            this.Cb_Val8_ent.Size = new System.Drawing.Size(43, 21);
            this.Cb_Val8_ent.TabIndex = 34;
            this.Cb_Val8_ent.SelectedIndexChanged += new System.EventHandler(this.Cb_Val8_ent_SelectedIndexChanged);
            // 
            // Cb_Val9_ent
            // 
            this.Cb_Val9_ent.FormattingEnabled = true;
            this.Cb_Val9_ent.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Cb_Val9_ent.Location = new System.Drawing.Point(379, 247);
            this.Cb_Val9_ent.Name = "Cb_Val9_ent";
            this.Cb_Val9_ent.Size = new System.Drawing.Size(43, 21);
            this.Cb_Val9_ent.TabIndex = 36;
            this.Cb_Val9_ent.SelectedIndexChanged += new System.EventHandler(this.Cb_Val9_ent_SelectedIndexChanged);
            // 
            // Cb_Val10_ent
            // 
            this.Cb_Val10_ent.FormattingEnabled = true;
            this.Cb_Val10_ent.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Cb_Val10_ent.Location = new System.Drawing.Point(379, 277);
            this.Cb_Val10_ent.Name = "Cb_Val10_ent";
            this.Cb_Val10_ent.Size = new System.Drawing.Size(43, 21);
            this.Cb_Val10_ent.TabIndex = 38;
            this.Cb_Val10_ent.SelectedIndexChanged += new System.EventHandler(this.Cb_Val10_ent_SelectedIndexChanged);
            // 
            // Cb_Val11_ent
            // 
            this.Cb_Val11_ent.FormattingEnabled = true;
            this.Cb_Val11_ent.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Cb_Val11_ent.Location = new System.Drawing.Point(379, 304);
            this.Cb_Val11_ent.Name = "Cb_Val11_ent";
            this.Cb_Val11_ent.Size = new System.Drawing.Size(43, 21);
            this.Cb_Val11_ent.TabIndex = 40;
            this.Cb_Val11_ent.SelectedIndexChanged += new System.EventHandler(this.Cb_Val11_ent_SelectedIndexChanged);
            // 
            // Cb_Val12_ent
            // 
            this.Cb_Val12_ent.FormattingEnabled = true;
            this.Cb_Val12_ent.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Cb_Val12_ent.Location = new System.Drawing.Point(379, 334);
            this.Cb_Val12_ent.Name = "Cb_Val12_ent";
            this.Cb_Val12_ent.Size = new System.Drawing.Size(43, 21);
            this.Cb_Val12_ent.TabIndex = 42;
            this.Cb_Val12_ent.SelectedIndexChanged += new System.EventHandler(this.Cb_Val12_ent_SelectedIndexChanged);
            // 
            // Cb_Val13_ent
            // 
            this.Cb_Val13_ent.FormattingEnabled = true;
            this.Cb_Val13_ent.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Cb_Val13_ent.Location = new System.Drawing.Point(379, 362);
            this.Cb_Val13_ent.Name = "Cb_Val13_ent";
            this.Cb_Val13_ent.Size = new System.Drawing.Size(43, 21);
            this.Cb_Val13_ent.TabIndex = 44;
            this.Cb_Val13_ent.SelectedIndexChanged += new System.EventHandler(this.Cb_Val13_ent_SelectedIndexChanged);
            // 
            // CB_Val2_dec
            // 
            this.CB_Val2_dec.FormattingEnabled = true;
            this.CB_Val2_dec.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.CB_Val2_dec.Location = new System.Drawing.Point(451, 45);
            this.CB_Val2_dec.Name = "CB_Val2_dec";
            this.CB_Val2_dec.Size = new System.Drawing.Size(43, 21);
            this.CB_Val2_dec.TabIndex = 22;
            // 
            // CB_Val3_dec
            // 
            this.CB_Val3_dec.FormattingEnabled = true;
            this.CB_Val3_dec.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.CB_Val3_dec.Location = new System.Drawing.Point(451, 75);
            this.CB_Val3_dec.Name = "CB_Val3_dec";
            this.CB_Val3_dec.Size = new System.Drawing.Size(43, 21);
            this.CB_Val3_dec.TabIndex = 25;
            // 
            // CB_Val4_dec
            // 
            this.CB_Val4_dec.FormattingEnabled = true;
            this.CB_Val4_dec.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.CB_Val4_dec.Location = new System.Drawing.Point(451, 102);
            this.CB_Val4_dec.Name = "CB_Val4_dec";
            this.CB_Val4_dec.Size = new System.Drawing.Size(43, 21);
            this.CB_Val4_dec.TabIndex = 27;
            // 
            // CB_Val5_dec
            // 
            this.CB_Val5_dec.FormattingEnabled = true;
            this.CB_Val5_dec.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.CB_Val5_dec.Location = new System.Drawing.Point(451, 132);
            this.CB_Val5_dec.Name = "CB_Val5_dec";
            this.CB_Val5_dec.Size = new System.Drawing.Size(43, 21);
            this.CB_Val5_dec.TabIndex = 29;
            // 
            // CB_Val6_dec
            // 
            this.CB_Val6_dec.FormattingEnabled = true;
            this.CB_Val6_dec.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.CB_Val6_dec.Location = new System.Drawing.Point(451, 161);
            this.CB_Val6_dec.Name = "CB_Val6_dec";
            this.CB_Val6_dec.Size = new System.Drawing.Size(43, 21);
            this.CB_Val6_dec.TabIndex = 31;
            this.CB_Val6_dec.SelectedIndexChanged += new System.EventHandler(this.CB_Val6_dec_SelectedIndexChanged);
            // 
            // CB_Val7_dec
            // 
            this.CB_Val7_dec.FormattingEnabled = true;
            this.CB_Val7_dec.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.CB_Val7_dec.Location = new System.Drawing.Point(451, 191);
            this.CB_Val7_dec.Name = "CB_Val7_dec";
            this.CB_Val7_dec.Size = new System.Drawing.Size(43, 21);
            this.CB_Val7_dec.TabIndex = 33;
            // 
            // CB_Val8_dec
            // 
            this.CB_Val8_dec.FormattingEnabled = true;
            this.CB_Val8_dec.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.CB_Val8_dec.Location = new System.Drawing.Point(451, 220);
            this.CB_Val8_dec.Name = "CB_Val8_dec";
            this.CB_Val8_dec.Size = new System.Drawing.Size(43, 21);
            this.CB_Val8_dec.TabIndex = 35;
            // 
            // CB_Val9_dec
            // 
            this.CB_Val9_dec.FormattingEnabled = true;
            this.CB_Val9_dec.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.CB_Val9_dec.Location = new System.Drawing.Point(451, 247);
            this.CB_Val9_dec.Name = "CB_Val9_dec";
            this.CB_Val9_dec.Size = new System.Drawing.Size(43, 21);
            this.CB_Val9_dec.TabIndex = 37;
            // 
            // CB_Val10_dec
            // 
            this.CB_Val10_dec.FormattingEnabled = true;
            this.CB_Val10_dec.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.CB_Val10_dec.Location = new System.Drawing.Point(451, 277);
            this.CB_Val10_dec.Name = "CB_Val10_dec";
            this.CB_Val10_dec.Size = new System.Drawing.Size(43, 21);
            this.CB_Val10_dec.TabIndex = 39;
            // 
            // CB_Val11_dec
            // 
            this.CB_Val11_dec.FormattingEnabled = true;
            this.CB_Val11_dec.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.CB_Val11_dec.Location = new System.Drawing.Point(451, 304);
            this.CB_Val11_dec.Name = "CB_Val11_dec";
            this.CB_Val11_dec.Size = new System.Drawing.Size(43, 21);
            this.CB_Val11_dec.TabIndex = 41;
            // 
            // CB_Val12_dec
            // 
            this.CB_Val12_dec.FormattingEnabled = true;
            this.CB_Val12_dec.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.CB_Val12_dec.Location = new System.Drawing.Point(451, 334);
            this.CB_Val12_dec.Name = "CB_Val12_dec";
            this.CB_Val12_dec.Size = new System.Drawing.Size(43, 21);
            this.CB_Val12_dec.TabIndex = 43;
            // 
            // CB_Val13_dec
            // 
            this.CB_Val13_dec.FormattingEnabled = true;
            this.CB_Val13_dec.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.CB_Val13_dec.Location = new System.Drawing.Point(451, 362);
            this.CB_Val13_dec.Name = "CB_Val13_dec";
            this.CB_Val13_dec.Size = new System.Drawing.Size(43, 21);
            this.CB_Val13_dec.TabIndex = 45;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CB_Val13_dec);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CB_Val12_dec);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CB_Val11_dec);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CB_Val10_dec);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.CB_Val9_dec);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.CB_Val8_dec);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.CB_Val7_dec);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.CB_Val6_dec);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.CB_Val5_dec);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.CB_Val4_dec);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.CB_Val3_dec);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.CB_Val2_dec);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.Cb_Val13_ent);
            this.groupBox1.Controls.Add(this.Cb_Val1_ent);
            this.groupBox1.Controls.Add(this.Cb_Val12_ent);
            this.groupBox1.Controls.Add(this.CB_Val1_dec);
            this.groupBox1.Controls.Add(this.Cb_Val11_ent);
            this.groupBox1.Controls.Add(this.Cb_Val2_ent);
            this.groupBox1.Controls.Add(this.Cb_Val10_ent);
            this.groupBox1.Controls.Add(this.Cb_Val3_ent);
            this.groupBox1.Controls.Add(this.Cb_Val9_ent);
            this.groupBox1.Controls.Add(this.Cb_Val4_ent);
            this.groupBox1.Controls.Add(this.Cb_Val8_ent);
            this.groupBox1.Controls.Add(this.Cb_Val5_ent);
            this.groupBox1.Controls.Add(this.Cb_Val7_ent);
            this.groupBox1.Controls.Add(this.Cb_Val6_ent);
            this.groupBox1.Location = new System.Drawing.Point(674, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 401);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese las calificaciones.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(505, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1110, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(968, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 78);
            this.button1.TabIndex = 48;
            this.button1.Text = "ENVIAR BOLETAS PENDIENTES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistrarCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1309, 590);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarCalificaciones";
            this.Text = "RegistrarCalificaciones";
            this.Load += new System.EventHandler(this.RegistrarCalificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox Cb_Val1_ent;
        private System.Windows.Forms.ComboBox CB_Val1_dec;
        private System.Windows.Forms.ComboBox Cb_Val2_ent;
        private System.Windows.Forms.ComboBox Cb_Val3_ent;
        private System.Windows.Forms.ComboBox Cb_Val4_ent;
        private System.Windows.Forms.ComboBox Cb_Val5_ent;
        private System.Windows.Forms.ComboBox Cb_Val6_ent;
        private System.Windows.Forms.ComboBox Cb_Val7_ent;
        private System.Windows.Forms.ComboBox Cb_Val8_ent;
        private System.Windows.Forms.ComboBox Cb_Val9_ent;
        private System.Windows.Forms.ComboBox Cb_Val10_ent;
        private System.Windows.Forms.ComboBox Cb_Val11_ent;
        private System.Windows.Forms.ComboBox Cb_Val12_ent;
        private System.Windows.Forms.ComboBox Cb_Val13_ent;
        private System.Windows.Forms.ComboBox CB_Val2_dec;
        private System.Windows.Forms.ComboBox CB_Val3_dec;
        private System.Windows.Forms.ComboBox CB_Val4_dec;
        private System.Windows.Forms.ComboBox CB_Val5_dec;
        private System.Windows.Forms.ComboBox CB_Val6_dec;
        private System.Windows.Forms.ComboBox CB_Val7_dec;
        private System.Windows.Forms.ComboBox CB_Val8_dec;
        private System.Windows.Forms.ComboBox CB_Val9_dec;
        private System.Windows.Forms.ComboBox CB_Val10_dec;
        private System.Windows.Forms.ComboBox CB_Val11_dec;
        private System.Windows.Forms.ComboBox CB_Val12_dec;
        private System.Windows.Forms.ComboBox CB_Val13_dec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}