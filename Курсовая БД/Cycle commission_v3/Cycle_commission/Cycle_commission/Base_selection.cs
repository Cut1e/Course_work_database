using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Cycle_commission
{
    public partial class Base_Selection : Form
    {
        string writePath = @"put.dat";
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Base_Selection()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Base_Selection_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Base_Selection_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(writePath))
                {
                    using (StreamReader sr = new StreamReader(writePath))
                    {
                        bunifuTextBox1.Text = sr.ReadLine();
                        string connectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True;", bunifuTextBox1.Text, bunifuTextBox2.Text);
                        SqlHelper class1 = new SqlHelper(connectionString);
                        if (class1.isConnection)
                        {
                            MessageBox.Show("Соединение успешно установлено", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            this.Show();
                    }
                }
                else
                {
                    this.ActiveControl = label1;
                    bunifuTextBox1.Text = (string.Format(@"{0}\MSSQLSERVER12", Environment.MachineName));
                    bunifuTextBox2.Text = "Cycle_commission";
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True;", bunifuTextBox1.Text, bunifuTextBox2.Text);
            try
            {
                SqlHelper class1 = new SqlHelper(connectionString);
                if (class1.isConnection)
                    MessageBox.Show("Соединение успешно установлено", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True;", bunifuTextBox1.Text, bunifuTextBox2.Text);
            File.Delete(writePath);
            try
            {
                SqlHelper class1 = new SqlHelper(connectionString);
                if (class1.isConnection)
                {
                    AppSetting setting = new AppSetting();
                    setting.SaceConectionString("Cycle_commission.Properties.Settings.Cycle_commissionConnectionString", connectionString);
                    MessageBox.Show("Для применения настроек перезапустите программу", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                using (StreamWriter sw = File.AppendText(writePath))
                {

                    sw.WriteLine(bunifuTextBox1.Text);
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                
                    if (MessageBox.Show("Вы уверены что хотите закрыть программу?", "Выйти?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
