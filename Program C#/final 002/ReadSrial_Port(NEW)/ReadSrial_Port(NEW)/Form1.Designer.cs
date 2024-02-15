namespace ReadSrial_Port_NEW_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_Send = new System.Windows.Forms.TextBox();
            this.comboBox_Port = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.countryid_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.note_txt = new System.Windows.Forms.TextBox();
            this.familyphone_txt = new System.Windows.Forms.TextBox();
            this.bloodtb_txt = new System.Windows.Forms.TextBox();
            this.agetxt = new System.Windows.Forms.TextBox();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.textBOX_Show_Read = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CLEAR_BTN = new System.Windows.Forms.Button();
            this.ADD_BTN = new System.Windows.Forms.Button();
            this.uploadbtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_Stop = new System.Windows.Forms.Button();
            this.BTN_Start = new System.Windows.Forms.Button();
            this.BTN_Send = new System.Windows.Forms.Button();
            this.DIABETSTXT = new System.Windows.Forms.TextBox();
            this.PRESSURETXT = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Send
            // 
            this.textBox_Send.Location = new System.Drawing.Point(622, 731);
            this.textBox_Send.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Send.Name = "textBox_Send";
            this.textBox_Send.Size = new System.Drawing.Size(441, 22);
            this.textBox_Send.TabIndex = 1;
            // 
            // comboBox_Port
            // 
            this.comboBox_Port.FormattingEnabled = true;
            this.comboBox_Port.Items.AddRange(new object[] {
            "Defult"});
            this.comboBox_Port.Location = new System.Drawing.Point(622, 764);
            this.comboBox_Port.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Port.Name = "comboBox_Port";
            this.comboBox_Port.Size = new System.Drawing.Size(441, 24);
            this.comboBox_Port.TabIndex = 5;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.CLEAR_BTN);
            this.panel1.Controls.Add(this.ADD_BTN);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.uploadbtn);
            this.panel1.Controls.Add(this.countryid_txt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.note_txt);
            this.panel1.Controls.Add(this.familyphone_txt);
            this.panel1.Controls.Add(this.agetxt);
            this.panel1.Controls.Add(this.Nametxt);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBOX_Show_Read);
            this.panel1.Location = new System.Drawing.Point(146, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1343, 703);
            this.panel1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(457, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "COUNTRY ID";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // countryid_txt
            // 
            this.countryid_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.countryid_txt.Location = new System.Drawing.Point(457, 184);
            this.countryid_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countryid_txt.Name = "countryid_txt";
            this.countryid_txt.Size = new System.Drawing.Size(245, 34);
            this.countryid_txt.TabIndex = 21;
            this.countryid_txt.TextChanged += new System.EventHandler(this.countryid_txt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(457, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Note :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(744, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(744, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Family Phone :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(461, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Age :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // note_txt
            // 
            this.note_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note_txt.Location = new System.Drawing.Point(457, 267);
            this.note_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.note_txt.Multiline = true;
            this.note_txt.Name = "note_txt";
            this.note_txt.Size = new System.Drawing.Size(738, 189);
            this.note_txt.TabIndex = 13;
            this.note_txt.TextChanged += new System.EventHandler(this.note_txt_TextChanged);
            // 
            // familyphone_txt
            // 
            this.familyphone_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.familyphone_txt.Location = new System.Drawing.Point(744, 116);
            this.familyphone_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.familyphone_txt.Name = "familyphone_txt";
            this.familyphone_txt.Size = new System.Drawing.Size(241, 34);
            this.familyphone_txt.TabIndex = 12;
            // 
            // bloodtb_txt
            // 
            this.bloodtb_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bloodtb_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bloodtb_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.bloodtb_txt.ForeColor = System.Drawing.SystemColors.Info;
            this.bloodtb_txt.Location = new System.Drawing.Point(172, 65);
            this.bloodtb_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bloodtb_txt.Multiline = true;
            this.bloodtb_txt.Name = "bloodtb_txt";
            this.bloodtb_txt.Size = new System.Drawing.Size(110, 89);
            this.bloodtb_txt.TabIndex = 11;
            this.bloodtb_txt.Text = "A";
            this.bloodtb_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bloodtb_txt.TextChanged += new System.EventHandler(this.bloodtb_txt_TextChanged);
            // 
            // agetxt
            // 
            this.agetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.agetxt.Location = new System.Drawing.Point(461, 116);
            this.agetxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.agetxt.Name = "agetxt";
            this.agetxt.Size = new System.Drawing.Size(241, 34);
            this.agetxt.TabIndex = 10;
            // 
            // Nametxt
            // 
            this.Nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nametxt.Location = new System.Drawing.Point(461, 48);
            this.Nametxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(241, 34);
            this.Nametxt.TabIndex = 9;
            // 
            // textBOX_Show_Read
            // 
            this.textBOX_Show_Read.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBOX_Show_Read.Location = new System.Drawing.Point(748, 48);
            this.textBOX_Show_Read.Margin = new System.Windows.Forms.Padding(4);
            this.textBOX_Show_Read.Multiline = true;
            this.textBOX_Show_Read.Name = "textBOX_Show_Read";
            this.textBOX_Show_Read.Size = new System.Drawing.Size(241, 38);
            this.textBOX_Show_Read.TabIndex = 7;
            this.textBOX_Show_Read.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBOX_Show_Read_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(103)))), ((int)(((byte)(166)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(101, 852);
            this.panel2.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::ReadSrial_Port_NEW_.Properties.Resources.PRESURE_CARD;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Controls.Add(this.PRESSURETXT);
            this.panel5.Location = new System.Drawing.Point(1048, 475);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(282, 213);
            this.panel5.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::ReadSrial_Port_NEW_.Properties.Resources.CARD_DIABETS;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Controls.Add(this.DIABETSTXT);
            this.panel4.Location = new System.Drawing.Point(748, 475);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(282, 213);
            this.panel4.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::ReadSrial_Port_NEW_.Properties.Resources.CARD_BLOOD1;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.bloodtb_txt);
            this.panel3.Location = new System.Drawing.Point(457, 475);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(282, 213);
            this.panel3.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(103)))), ((int)(((byte)(166)))));
            this.button2.BackgroundImage = global::ReadSrial_Port_NEW_.Properties.Resources.insurance;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(-1, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 64);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ReadSrial_Port_NEW_.Properties.Resources.logout;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(34, 802);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 36);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CLEAR_BTN
            // 
            this.CLEAR_BTN.BackColor = System.Drawing.Color.Transparent;
            this.CLEAR_BTN.BackgroundImage = global::ReadSrial_Port_NEW_.Properties.Resources.clear_data;
            this.CLEAR_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CLEAR_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CLEAR_BTN.FlatAppearance.BorderSize = 0;
            this.CLEAR_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CLEAR_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CLEAR_BTN.Location = new System.Drawing.Point(13, 541);
            this.CLEAR_BTN.Margin = new System.Windows.Forms.Padding(4);
            this.CLEAR_BTN.Name = "CLEAR_BTN";
            this.CLEAR_BTN.Size = new System.Drawing.Size(170, 57);
            this.CLEAR_BTN.TabIndex = 10;
            this.CLEAR_BTN.UseVisualStyleBackColor = false;
            this.CLEAR_BTN.Click += new System.EventHandler(this.CLEAR_BTN_Click);
            // 
            // ADD_BTN
            // 
            this.ADD_BTN.BackColor = System.Drawing.Color.Transparent;
            this.ADD_BTN.BackgroundImage = global::ReadSrial_Port_NEW_.Properties.Resources.add_button1;
            this.ADD_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ADD_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ADD_BTN.FlatAppearance.BorderSize = 0;
            this.ADD_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ADD_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ADD_BTN.Location = new System.Drawing.Point(200, 541);
            this.ADD_BTN.Margin = new System.Windows.Forms.Padding(4);
            this.ADD_BTN.Name = "ADD_BTN";
            this.ADD_BTN.Size = new System.Drawing.Size(170, 57);
            this.ADD_BTN.TabIndex = 9;
            this.ADD_BTN.UseVisualStyleBackColor = false;
            this.ADD_BTN.Click += new System.EventHandler(this.ADD_BTN_Click);
            // 
            // uploadbtn
            // 
            this.uploadbtn.BackColor = System.Drawing.Color.Transparent;
            this.uploadbtn.BackgroundImage = global::ReadSrial_Port_NEW_.Properties.Resources.upload;
            this.uploadbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uploadbtn.FlatAppearance.BorderSize = 0;
            this.uploadbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.uploadbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadbtn.Location = new System.Drawing.Point(1027, 201);
            this.uploadbtn.Margin = new System.Windows.Forms.Padding(4);
            this.uploadbtn.Name = "uploadbtn";
            this.uploadbtn.Size = new System.Drawing.Size(172, 41);
            this.uploadbtn.TabIndex = 8;
            this.uploadbtn.UseVisualStyleBackColor = false;
            this.uploadbtn.Click += new System.EventHandler(this.uploadbtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(417, 523);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1027, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_Stop
            // 
            this.BTN_Stop.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Stop.BackgroundImage = global::ReadSrial_Port_NEW_.Properties.Resources.close_btn;
            this.BTN_Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Stop.FlatAppearance.BorderSize = 0;
            this.BTN_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Stop.Location = new System.Drawing.Point(607, 791);
            this.BTN_Stop.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Stop.Name = "BTN_Stop";
            this.BTN_Stop.Size = new System.Drawing.Size(146, 62);
            this.BTN_Stop.TabIndex = 4;
            this.BTN_Stop.UseVisualStyleBackColor = false;
            this.BTN_Stop.Click += new System.EventHandler(this.BTN_Stop_Click);
            // 
            // BTN_Start
            // 
            this.BTN_Start.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Start.BackgroundImage = global::ReadSrial_Port_NEW_.Properties.Resources.start_btn;
            this.BTN_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Start.FlatAppearance.BorderSize = 0;
            this.BTN_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Start.Location = new System.Drawing.Point(931, 791);
            this.BTN_Start.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(146, 62);
            this.BTN_Start.TabIndex = 3;
            this.BTN_Start.UseVisualStyleBackColor = false;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // BTN_Send
            // 
            this.BTN_Send.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Send.BackgroundImage = global::ReadSrial_Port_NEW_.Properties.Resources.send_btn;
            this.BTN_Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Send.FlatAppearance.BorderSize = 0;
            this.BTN_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Send.Location = new System.Drawing.Point(769, 791);
            this.BTN_Send.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Send.Name = "BTN_Send";
            this.BTN_Send.Size = new System.Drawing.Size(146, 62);
            this.BTN_Send.TabIndex = 2;
            this.BTN_Send.UseVisualStyleBackColor = false;
            this.BTN_Send.Click += new System.EventHandler(this.BTN_Send_Click);
            // 
            // DIABETSTXT
            // 
            this.DIABETSTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(174)))), ((int)(((byte)(178)))));
            this.DIABETSTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DIABETSTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.DIABETSTXT.ForeColor = System.Drawing.SystemColors.Info;
            this.DIABETSTXT.Location = new System.Drawing.Point(179, 65);
            this.DIABETSTXT.Name = "DIABETSTXT";
            this.DIABETSTXT.Size = new System.Drawing.Size(100, 85);
            this.DIABETSTXT.TabIndex = 0;
            this.DIABETSTXT.Text = "a";
            // 
            // PRESSURETXT
            // 
            this.PRESSURETXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(181)))), ((int)(((byte)(119)))));
            this.PRESSURETXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PRESSURETXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.PRESSURETXT.ForeColor = System.Drawing.SystemColors.Info;
            this.PRESSURETXT.Location = new System.Drawing.Point(181, 66);
            this.PRESSURETXT.Name = "PRESSURETXT";
            this.PRESSURETXT.Size = new System.Drawing.Size(100, 85);
            this.PRESSURETXT.TabIndex = 1;
            this.PRESSURETXT.Text = "a";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 852);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox_Port);
            this.Controls.Add(this.BTN_Stop);
            this.Controls.Add(this.BTN_Start);
            this.Controls.Add(this.BTN_Send);
            this.Controls.Add(this.textBox_Send);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Send;
        private System.Windows.Forms.Button BTN_Send;
        private System.Windows.Forms.Button BTN_Start;
        private System.Windows.Forms.Button BTN_Stop;
        private System.Windows.Forms.ComboBox comboBox_Port;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox note_txt;
        private System.Windows.Forms.TextBox familyphone_txt;
        private System.Windows.Forms.TextBox bloodtb_txt;
        private System.Windows.Forms.TextBox agetxt;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.TextBox textBOX_Show_Read;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button uploadbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox countryid_txt;
        private System.Windows.Forms.Button CLEAR_BTN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ADD_BTN;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox PRESSURETXT;
        private System.Windows.Forms.TextBox DIABETSTXT;
    }
}

