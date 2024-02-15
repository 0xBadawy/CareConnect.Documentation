using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.InteropServices;
using System.IO.Ports;

namespace ReadSrial_Port_NEW_
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
             (
       int nLeftRect,
       int nTopRect,
       int nRightRect,
       int nBottomRect,
       int nWidthEllipse,
       int nHeightEllipse
          );

        SqlConnection conn = new SqlConnection(@"Server=DESKTOP-2V1AEKV\SQLEXPRESS; Database=DB-S; Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] strPortName = SerialPort.GetPortNames();
            foreach (string n in strPortName)
            {
                comboBox_Port.Items.Add(n);
            }
            comboBox_Port.SelectedIndex = 0;
        }


        private void BTN_Start_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.BaudRate = 9600;
                //serialPort1.PortName = comboBox1.SelectedItem + "";
                //serialPort1.PortName = "COM9";
                serialPort1.PortName = comboBox_Port.Text;
                serialPort1.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            textBOX_Show_Read.AppendText(serialPort1.ReadLine());
            //textBOX_Show_Read.AppendText("\n");
        }

        private void BTN_Stop_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
        }

        private void BTN_Send_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    //serialPort1.WriteLine(textBox_Send.Text + Environment.NewLine);
                    //serialPort1.WriteLine(textBox_Send.Text.ToString());
                    //serialPort1.WriteLine("ON");
                    serialPort1.Write(textBox_Send.Text.ToString());
                    //textBox1.AppendText("ON");
                    //serialPort1.Write("ON");

                    textBox_Send.Clear();
                    textBOX_Show_Read.Text = serialPort1.ReadExisting();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void uploadbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ope = new OpenFileDialog();
            ope.Filter = "Photos | *.png; *.jpg; *.gif; *.bmp";
            if(ope.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ope.FileName);
            }
        }

        private void ADD_BTN_Click(object sender, EventArgs e)
        {
            //insert command string
            cmd = new SqlCommand("INSERT INTO TBL Values (@NAME, @NOTES, @PHONE_NUMBER, @AGE, @BLOOD_TYPE, @PICTURE, @COUNTRY_ID, @FING_ID, @PRESSURE, @DIABETS)", conn);

            //inizializing varibales
            SqlParameter[] param = new SqlParameter[10];

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] image = ms.ToArray();

            //sql parameters
            param[0] = new SqlParameter("@NAME",SqlDbType.VarChar,50);
            param[0].Value = Nametxt.Text;

            param[1] = new SqlParameter("@NOTES", SqlDbType.VarChar);
            param[1].Value =Convert.ToString( note_txt.Text);

            param[2] = new SqlParameter("@PHONE_NUMBER", SqlDbType.VarChar,50);
            param[2].Value = familyphone_txt.Text;

            param[3] = new SqlParameter("@AGE", SqlDbType.VarChar);
            param[3].Value = agetxt.Text;

            param[4] = new SqlParameter("@BLOOD_TYPE", SqlDbType.VarChar,10);
            param[4].Value = bloodtb_txt.Text;

            param[5] = new SqlParameter("@PICTURE", SqlDbType.Image);
            param[5].Value = image;

            param[6] = new SqlParameter("@COUNTRY_ID", SqlDbType.VarChar);
            param[6].Value = countryid_txt.Text;

            param[7] = new SqlParameter("@FING_ID", SqlDbType.VarChar);
            param[7].Value = textBOX_Show_Read.Text;
            
            param[8] = new SqlParameter("@PRESSURE", SqlDbType.VarChar);
            param[8].Value = PRESSURETXT.Text;

            param[9] = new SqlParameter("@DIABETS", SqlDbType.VarChar);
            param[9].Value = DIABETSTXT.Text;



            conn.Open();
            cmd.Parameters.AddRange(param);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("تم اضافه شخص جديد في قاعده البيانات","الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBOX_Show_Read_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                cmd = new SqlCommand("SELECT * FROM TBL WHERE FING_ID = @FING_ID",conn);
                cmd.Parameters.Add(new SqlParameter("@FING_ID",textBOX_Show_Read.Text));
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    Nametxt.Text = dr.GetString(1);
                    note_txt.Text = dr.GetString(2);
                    familyphone_txt.Text = dr.GetString(3);
                    agetxt.Text = dr.GetString(4);
                    byte[] image = (byte[])dr[6];
                    MemoryStream ms = new MemoryStream(image);
                    pictureBox1.Image = Image.FromStream(ms);
                    bloodtb_txt.Text = dr.GetString(5);
                    countryid_txt.Text = dr.GetString(7);
                    textBOX_Show_Read.Text = dr.GetString(8);
                    PRESSURETXT.Text = Convert.ToString(dr.GetString(9));
                    DIABETSTXT.Text = dr.GetString(10);
                }
                dr.Close();
                conn.Close();
            }
        }

        private void CLEAR_BTN_Click(object sender, EventArgs e)
        {
            Nametxt.Clear();
            agetxt.Clear();
            countryid_txt.Clear();
            textBOX_Show_Read.Clear();
            bloodtb_txt.Clear();
            familyphone_txt.Clear();
            note_txt.Clear();
        }

        private void bloodtb_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void countryid_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void note_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void agetxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
