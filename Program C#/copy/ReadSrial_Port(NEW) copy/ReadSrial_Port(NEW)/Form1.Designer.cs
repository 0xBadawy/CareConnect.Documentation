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
            this.BTN_Send = new System.Windows.Forms.Button();
            this.BTN_Start = new System.Windows.Forms.Button();
            this.BTN_Stop = new System.Windows.Forms.Button();
            this.comboBox_Port = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.countryid_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.note_txt = new System.Windows.Forms.TextBox();
            this.familyphone_txt = new System.Windows.Forms.TextBox();
            this.bloodtb_txt = new System.Windows.Forms.TextBox();
            this.agetxt = new System.Windows.Forms.TextBox();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBOX_Show_Read = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.uploadbtn = new System.Windows.Forms.Button();
            this.ADD_BTN = new System.Windows.Forms.Button();
            this.CLEAR_BTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Send
            // 
            this.textBox_Send.Location = new System.Drawing.Point(885, 570);
            this.textBox_Send.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Send.Name = "textBox_Send";
            this.textBox_Send.Size = new System.Drawing.Size(373, 22);
            this.textBox_Send.TabIndex = 1;
            // 
            // BTN_Send
            // 
            this.BTN_Send.Location = new System.Drawing.Point(1021, 633);
            this.BTN_Send.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Send.Name = "BTN_Send";
            this.BTN_Send.Size = new System.Drawing.Size(112, 28);
            this.BTN_Send.TabIndex = 2;
            this.BTN_Send.Text = "Send";
            this.BTN_Send.UseVisualStyleBackColor = true;
            this.BTN_Send.Click += new System.EventHandler(this.BTN_Send_Click);
            // 
            // BTN_Start
            // 
            this.BTN_Start.Location = new System.Drawing.Point(1148, 633);
            this.BTN_Start.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(112, 28);
            this.BTN_Start.TabIndex = 3;
            this.BTN_Start.Text = "Start";
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // BTN_Stop
            // 
            this.BTN_Stop.Location = new System.Drawing.Point(885, 633);
            this.BTN_Stop.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Stop.Name = "BTN_Stop";
            this.BTN_Stop.Size = new System.Drawing.Size(112, 28);
            this.BTN_Stop.TabIndex = 4;
            this.BTN_Stop.Text = "Stop";
            this.BTN_Stop.UseVisualStyleBackColor = true;
            this.BTN_Stop.Click += new System.EventHandler(this.BTN_Stop_Click);
            // 
            // comboBox_Port
            // 
            this.comboBox_Port.FormattingEnabled = true;
            this.comboBox_Port.Location = new System.Drawing.Point(885, 599);
            this.comboBox_Port.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Port.Name = "comboBox_Port";
            this.comboBox_Port.Size = new System.Drawing.Size(373, 24);
            this.comboBox_Port.TabIndex = 5;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.countryid_txt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.note_txt);
            this.panel1.Controls.Add(this.familyphone_txt);
            this.panel1.Controls.Add(this.bloodtb_txt);
            this.panel1.Controls.Add(this.agetxt);
            this.panel1.Controls.Add(this.Nametxt);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBOX_Show_Read);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 500);
            this.panel1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(744, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "COUNTRY ID";
            // 
            // countryid_txt
            // 
            this.countryid_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.countryid_txt.Location = new System.Drawing.Point(744, 170);
            this.countryid_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countryid_txt.Name = "countryid_txt";
            this.countryid_txt.Size = new System.Drawing.Size(245, 34);
            this.countryid_txt.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(461, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Note :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(744, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Blood Type :";
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
            this.label3.Location = new System.Drawing.Point(461, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Family Phone :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(461, 87);
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
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(357, 485);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // note_txt
            // 
            this.note_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note_txt.Location = new System.Drawing.Point(461, 242);
            this.note_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.note_txt.Multiline = true;
            this.note_txt.Name = "note_txt";
            this.note_txt.Size = new System.Drawing.Size(736, 242);
            this.note_txt.TabIndex = 13;
            // 
            // familyphone_txt
            // 
            this.familyphone_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.familyphone_txt.Location = new System.Drawing.Point(461, 170);
            this.familyphone_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.familyphone_txt.Name = "familyphone_txt";
            this.familyphone_txt.Size = new System.Drawing.Size(241, 34);
            this.familyphone_txt.TabIndex = 12;
            // 
            // bloodtb_txt
            // 
            this.bloodtb_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.bloodtb_txt.Location = new System.Drawing.Point(744, 107);
            this.bloodtb_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bloodtb_txt.Name = "bloodtb_txt";
            this.bloodtb_txt.Size = new System.Drawing.Size(245, 34);
            this.bloodtb_txt.TabIndex = 11;
            // 
            // agetxt
            // 
            this.agetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.agetxt.Location = new System.Drawing.Point(461, 107);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 624);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uploadbtn
            // 
            this.uploadbtn.Location = new System.Drawing.Point(12, 570);
            this.uploadbtn.Margin = new System.Windows.Forms.Padding(4);
            this.uploadbtn.Name = "uploadbtn";
            this.uploadbtn.Size = new System.Drawing.Size(165, 41);
            this.uploadbtn.TabIndex = 8;
            this.uploadbtn.Text = "Upload Photo";
            this.uploadbtn.UseVisualStyleBackColor = true;
            this.uploadbtn.Click += new System.EventHandler(this.uploadbtn_Click);
            // 
            // ADD_BTN
            // 
            this.ADD_BTN.Location = new System.Drawing.Point(185, 570);
            this.ADD_BTN.Margin = new System.Windows.Forms.Padding(4);
            this.ADD_BTN.Name = "ADD_BTN";
            this.ADD_BTN.Size = new System.Drawing.Size(165, 41);
            this.ADD_BTN.TabIndex = 9;
            this.ADD_BTN.Text = "Add";
            this.ADD_BTN.UseVisualStyleBackColor = true;
            this.ADD_BTN.Click += new System.EventHandler(this.ADD_BTN_Click);
            // 
            // CLEAR_BTN
            // 
            this.CLEAR_BTN.Location = new System.Drawing.Point(185, 624);
            this.CLEAR_BTN.Margin = new System.Windows.Forms.Padding(4);
            this.CLEAR_BTN.Name = "CLEAR_BTN";
            this.CLEAR_BTN.Size = new System.Drawing.Size(165, 38);
            this.CLEAR_BTN.TabIndex = 10;
            this.CLEAR_BTN.Text = "Clear";
            this.CLEAR_BTN.UseVisualStyleBackColor = true;
            this.CLEAR_BTN.Visible = false;
            this.CLEAR_BTN.Click += new System.EventHandler(this.CLEAR_BTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 673);
            this.Controls.Add(this.CLEAR_BTN);
            this.Controls.Add(this.ADD_BTN);
            this.Controls.Add(this.uploadbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox_Port);
            this.Controls.Add(this.BTN_Stop);
            this.Controls.Add(this.BTN_Start);
            this.Controls.Add(this.BTN_Send);
            this.Controls.Add(this.textBox_Send);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button uploadbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox countryid_txt;
        private System.Windows.Forms.Button ADD_BTN;
        private System.Windows.Forms.Button CLEAR_BTN;
    }
}

