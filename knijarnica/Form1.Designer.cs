namespace knijarnica
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button_prodajbi = new System.Windows.Forms.Button();
            this.button_stoki = new System.Windows.Forms.Button();
            this.button_oborot = new System.Windows.Forms.Button();
            this.groupBox_dostavchik = new System.Windows.Forms.GroupBox();
            this.textBox_kontakt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_telefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_egn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox_prodajba = new System.Windows.Forms.GroupBox();
            this.textBox_dostavchik_egn = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_data = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_broi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_cena = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_stoki = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox_stoki = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stokiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knijarnicaDataSet = new knijarnica.knijarnicaDataSet();
            this.groupBox_oborot = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dostavchicinaknijarnicatraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dostavchici_na_knijarnicatraTableAdapter = new knijarnica.knijarnicaDataSetTableAdapters.Dostavchici_na_knijarnicatraTableAdapter();
            this.stokiTableAdapter = new knijarnica.knijarnicaDataSetTableAdapters.stokiTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.button_dostavhik = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_dostavchik.SuspendLayout();
            this.groupBox_prodajba.SuspendLayout();
            this.groupBox_stoki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knijarnicaDataSet)).BeginInit();
            this.groupBox_oborot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dostavchicinaknijarnicatraBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_prodajbi
            // 
            this.button_prodajbi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_prodajbi.FlatAppearance.BorderSize = 0;
            this.button_prodajbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_prodajbi.Location = new System.Drawing.Point(0, 132);
            this.button_prodajbi.Name = "button_prodajbi";
            this.button_prodajbi.Size = new System.Drawing.Size(135, 60);
            this.button_prodajbi.TabIndex = 2;
            this.button_prodajbi.Text = "📚Нова продажба";
            this.button_prodajbi.UseVisualStyleBackColor = false;
            this.button_prodajbi.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_stoki
            // 
            this.button_stoki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_stoki.FlatAppearance.BorderSize = 0;
            this.button_stoki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_stoki.Location = new System.Drawing.Point(0, 223);
            this.button_stoki.Name = "button_stoki";
            this.button_stoki.Size = new System.Drawing.Size(135, 58);
            this.button_stoki.TabIndex = 3;
            this.button_stoki.Text = "📚Стоки";
            this.button_stoki.UseVisualStyleBackColor = false;
            this.button_stoki.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_oborot
            // 
            this.button_oborot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_oborot.FlatAppearance.BorderSize = 0;
            this.button_oborot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_oborot.Location = new System.Drawing.Point(0, 391);
            this.button_oborot.Name = "button_oborot";
            this.button_oborot.Size = new System.Drawing.Size(135, 61);
            this.button_oborot.TabIndex = 4;
            this.button_oborot.Text = "📚Продажби/Оборот";
            this.button_oborot.UseVisualStyleBackColor = false;
            this.button_oborot.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox_dostavchik
            // 
            this.groupBox_dostavchik.BackColor = System.Drawing.Color.White;
            this.groupBox_dostavchik.Controls.Add(this.textBox_kontakt);
            this.groupBox_dostavchik.Controls.Add(this.label5);
            this.groupBox_dostavchik.Controls.Add(this.textBox_email);
            this.groupBox_dostavchik.Controls.Add(this.label4);
            this.groupBox_dostavchik.Controls.Add(this.textBox_telefon);
            this.groupBox_dostavchik.Controls.Add(this.label3);
            this.groupBox_dostavchik.Controls.Add(this.textBox_egn);
            this.groupBox_dostavchik.Controls.Add(this.label2);
            this.groupBox_dostavchik.Controls.Add(this.textBox_name);
            this.groupBox_dostavchik.Controls.Add(this.label1);
            this.groupBox_dostavchik.Controls.Add(this.button5);
            this.groupBox_dostavchik.ForeColor = System.Drawing.Color.Black;
            this.groupBox_dostavchik.Location = new System.Drawing.Point(171, 8);
            this.groupBox_dostavchik.Name = "groupBox_dostavchik";
            this.groupBox_dostavchik.Size = new System.Drawing.Size(254, 336);
            this.groupBox_dostavchik.TabIndex = 5;
            this.groupBox_dostavchik.TabStop = false;
            this.groupBox_dostavchik.Text = "Добавяне на нов доставчик";
            this.groupBox_dostavchik.Visible = false;
            // 
            // textBox_kontakt
            // 
            this.textBox_kontakt.Location = new System.Drawing.Point(86, 215);
            this.textBox_kontakt.Multiline = true;
            this.textBox_kontakt.Name = "textBox_kontakt";
            this.textBox_kontakt.Size = new System.Drawing.Size(146, 25);
            this.textBox_kontakt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Лице \r\nза контакт";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(86, 170);
            this.textBox_email.Multiline = true;
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(146, 25);
            this.textBox_email.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "E-mail";
            // 
            // textBox_telefon
            // 
            this.textBox_telefon.Location = new System.Drawing.Point(86, 123);
            this.textBox_telefon.Multiline = true;
            this.textBox_telefon.Name = "textBox_telefon";
            this.textBox_telefon.Size = new System.Drawing.Size(146, 25);
            this.textBox_telefon.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Телефон";
            // 
            // textBox_egn
            // 
            this.textBox_egn.Location = new System.Drawing.Point(86, 76);
            this.textBox_egn.Multiline = true;
            this.textBox_egn.Name = "textBox_egn";
            this.textBox_egn.Size = new System.Drawing.Size(146, 25);
            this.textBox_egn.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ЕИК/ЕГН";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(86, 32);
            this.textBox_name.Multiline = true;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(146, 25);
            this.textBox_name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(30, 304);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(202, 26);
            this.button5.TabIndex = 0;
            this.button5.Text = "Добавй";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // groupBox_prodajba
            // 
            this.groupBox_prodajba.Controls.Add(this.textBox_dostavchik_egn);
            this.groupBox_prodajba.Controls.Add(this.label14);
            this.groupBox_prodajba.Controls.Add(this.textBox_data);
            this.groupBox_prodajba.Controls.Add(this.label7);
            this.groupBox_prodajba.Controls.Add(this.textBox_broi);
            this.groupBox_prodajba.Controls.Add(this.label8);
            this.groupBox_prodajba.Controls.Add(this.textBox_cena);
            this.groupBox_prodajba.Controls.Add(this.label9);
            this.groupBox_prodajba.Controls.Add(this.textBox_stoki);
            this.groupBox_prodajba.Controls.Add(this.label10);
            this.groupBox_prodajba.Controls.Add(this.button6);
            this.groupBox_prodajba.Location = new System.Drawing.Point(441, 8);
            this.groupBox_prodajba.Name = "groupBox_prodajba";
            this.groupBox_prodajba.Size = new System.Drawing.Size(269, 336);
            this.groupBox_prodajba.TabIndex = 6;
            this.groupBox_prodajba.TabStop = false;
            this.groupBox_prodajba.Text = "Добавяне на новa продажба";
            this.groupBox_prodajba.Visible = false;
            // 
            // textBox_dostavchik_egn
            // 
            this.textBox_dostavchik_egn.Location = new System.Drawing.Point(81, 211);
            this.textBox_dostavchik_egn.Multiline = true;
            this.textBox_dostavchik_egn.Name = "textBox_dostavchik_egn";
            this.textBox_dostavchik_egn.Size = new System.Drawing.Size(140, 25);
            this.textBox_dostavchik_egn.TabIndex = 10;
            this.textBox_dostavchik_egn.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 210);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 26);
            this.label14.TabIndex = 9;
            this.label14.Text = "Доставчик \r\nегн";
            // 
            // textBox_data
            // 
            this.textBox_data.Location = new System.Drawing.Point(81, 171);
            this.textBox_data.Multiline = true;
            this.textBox_data.Name = "textBox_data";
            this.textBox_data.Size = new System.Drawing.Size(140, 25);
            this.textBox_data.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Дата";
            // 
            // textBox_broi
            // 
            this.textBox_broi.Location = new System.Drawing.Point(81, 124);
            this.textBox_broi.Multiline = true;
            this.textBox_broi.Name = "textBox_broi";
            this.textBox_broi.Size = new System.Drawing.Size(140, 25);
            this.textBox_broi.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Брой";
            // 
            // textBox_cena
            // 
            this.textBox_cena.Location = new System.Drawing.Point(81, 74);
            this.textBox_cena.Multiline = true;
            this.textBox_cena.Name = "textBox_cena";
            this.textBox_cena.Size = new System.Drawing.Size(140, 25);
            this.textBox_cena.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 26);
            this.label9.TabIndex = 3;
            this.label9.Text = "Продажна\r\n цена";
            // 
            // textBox_stoki
            // 
            this.textBox_stoki.Location = new System.Drawing.Point(81, 30);
            this.textBox_stoki.Multiline = true;
            this.textBox_stoki.Name = "textBox_stoki";
            this.textBox_stoki.Size = new System.Drawing.Size(140, 25);
            this.textBox_stoki.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Стока";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(24, 304);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(215, 26);
            this.button6.TabIndex = 0;
            this.button6.Text = "Добавй";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox_stoki
            // 
            this.groupBox_stoki.Controls.Add(this.button7);
            this.groupBox_stoki.Controls.Add(this.dataGridView1);
            this.groupBox_stoki.Location = new System.Drawing.Point(171, 350);
            this.groupBox_stoki.Name = "groupBox_stoki";
            this.groupBox_stoki.Size = new System.Drawing.Size(830, 150);
            this.groupBox_stoki.TabIndex = 10;
            this.groupBox_stoki.TabStop = false;
            this.groupBox_stoki.Text = "Стоки";
            this.groupBox_stoki.Visible = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(17, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(24, 117);
            this.button7.TabIndex = 1;
            this.button7.Text = "Стоки";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(771, 117);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // stokiBindingSource
            // 
            this.stokiBindingSource.DataMember = "stoki";
            this.stokiBindingSource.DataSource = this.knijarnicaDataSet;
            // 
            // knijarnicaDataSet
            // 
            this.knijarnicaDataSet.DataSetName = "knijarnicaDataSet";
            this.knijarnicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox_oborot
            // 
            this.groupBox_oborot.Controls.Add(this.listBox1);
            this.groupBox_oborot.Controls.Add(this.dateTimePicker1);
            this.groupBox_oborot.Controls.Add(this.button9);
            this.groupBox_oborot.Controls.Add(this.button8);
            this.groupBox_oborot.Controls.Add(this.label12);
            this.groupBox_oborot.Controls.Add(this.label11);
            this.groupBox_oborot.Controls.Add(this.label6);
            this.groupBox_oborot.Location = new System.Drawing.Point(727, 8);
            this.groupBox_oborot.Name = "groupBox_oborot";
            this.groupBox_oborot.Size = new System.Drawing.Size(274, 336);
            this.groupBox_oborot.TabIndex = 11;
            this.groupBox_oborot.TabStop = false;
            this.groupBox_oborot.Text = "Прдожби/Оборот";
            this.groupBox_oborot.Visible = false;
            this.groupBox_oborot.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(22, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 69);
            this.listBox1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(22, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(235, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(140, 289);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(117, 30);
            this.button9.TabIndex = 5;
            this.button9.Text = "Оборот";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(9, 289);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(117, 30);
            this.button8.TabIndex = 4;
            this.button8.Text = "Продажби";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(116, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = " ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(116, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 0;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dostavchicinaknijarnicatraBindingSource
            // 
            this.dostavchicinaknijarnicatraBindingSource.DataMember = "Dostavchici_na_knijarnicatra";
            this.dostavchicinaknijarnicatraBindingSource.DataSource = this.knijarnicaDataSet;
            // 
            // dostavchici_na_knijarnicatraTableAdapter
            // 
            this.dostavchici_na_knijarnicatraTableAdapter.ClearBeforeFill = true;
            // 
            // stokiTableAdapter
            // 
            this.stokiTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button_prodajbi);
            this.panel1.Controls.Add(this.button_oborot);
            this.panel1.Controls.Add(this.button_dostavhik);
            this.panel1.Controls.Add(this.button_stoki);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 512);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(-3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 83);
            this.panel2.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(51, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Меню";
            // 
            // button_dostavhik
            // 
            this.button_dostavhik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_dostavhik.FlatAppearance.BorderSize = 0;
            this.button_dostavhik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dostavhik.Location = new System.Drawing.Point(0, 296);
            this.button_dostavhik.Name = "button_dostavhik";
            this.button_dostavhik.Size = new System.Drawing.Size(135, 58);
            this.button_dostavhik.TabIndex = 1;
            this.button_dostavhik.Text = "📚Доставчици";
            this.button_dostavhik.UseVisualStyleBackColor = false;
            this.button_dostavhik.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::knijarnica.Properties.Resources.library;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1022, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox_oborot);
            this.Controls.Add(this.groupBox_stoki);
            this.Controls.Add(this.groupBox_dostavchik);
            this.Controls.Add(this.groupBox_prodajba);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "книжарница";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_dostavchik.ResumeLayout(false);
            this.groupBox_dostavchik.PerformLayout();
            this.groupBox_prodajba.ResumeLayout(false);
            this.groupBox_prodajba.PerformLayout();
            this.groupBox_stoki.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knijarnicaDataSet)).EndInit();
            this.groupBox_oborot.ResumeLayout(false);
            this.groupBox_oborot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dostavchicinaknijarnicatraBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_dostavhik;
        private System.Windows.Forms.Button button_prodajbi;
        private System.Windows.Forms.Button button_stoki;
        private System.Windows.Forms.Button button_oborot;
        private System.Windows.Forms.GroupBox groupBox_dostavchik;
        private System.Windows.Forms.TextBox textBox_kontakt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_telefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_egn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox_prodajba;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_broi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_cena;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_stoki;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox_stoki;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox_oborot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private knijarnicaDataSet knijarnicaDataSet;
        private System.Windows.Forms.BindingSource dostavchicinaknijarnicatraBindingSource;
        private knijarnicaDataSetTableAdapters.Dostavchici_na_knijarnicatraTableAdapter dostavchici_na_knijarnicatraTableAdapter;
        private System.Windows.Forms.BindingSource stokiBindingSource;
        private knijarnicaDataSetTableAdapters.stokiTableAdapter stokiTableAdapter;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox_data;
        private System.Windows.Forms.TextBox textBox_dostavchik_egn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
    }
}

