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
namespace WindowsFormsApplication1
{
    public partial class Base_selection : Form
    {
        string writePath = @"put.dat";
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Base_selection()
        {
            InitializeComponent();
        }



        private void Base_selection_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void leftpicture_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Base_selection_Load(object sender, EventArgs e)
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
                    bunifuTextBox1.Text = (string.Format(@"{0}\MSSQLSERVER12", Environment.MachineName));
                    bunifuTextBox2.Text = "Cycle_commission";
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   

        private void bunifuButton2_Click(object sender, EventArgs e)
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

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True;", bunifuTextBox1.Text, bunifuTextBox2.Text);
            File.Delete(writePath);
            try
            {
                SqlHelper class1 = new SqlHelper(connectionString);
                if (class1.isConnection)
                {
                    AppSetting setting = new AppSetting();
                    setting.SaceConectionString("WindowsFormsApplication1.Properties.Settings.Cycle_commissionConnectionString", connectionString);
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
    }
}
