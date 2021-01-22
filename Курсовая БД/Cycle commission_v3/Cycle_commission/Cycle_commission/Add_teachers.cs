using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cycle_commission
{
    public partial class Add_teachers : Form
    {
        public Add_teachers()
        {
            InitializeComponent();
        }

        private void Add_teachers_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'cycle_commissionDataSet.Cabinets' table. You can move, or remove it, as needed.
                this.cabinetsTableAdapter.Fill(this.cycle_commissionDataSet.Cabinets);
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bunifuTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    comboBox1.Focus();
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены что хотите добавить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (radioButton1.Checked == true)
                    {
                        int id = (int)comboBox1.SelectedValue;
                        string data = String.Format(dateTimePicker2.Value.ToShortDateString());
                        Cycle_selection main = this.Owner as Cycle_selection;
                        if (main != null)
                        {
                            main.teacherTableAdapter.InsertQuery(bunifuTextBox1.Text, data, id);
                            main.teacherTableAdapter.Fill(main.cycle_commissionDataSet.Teacher);
                            main.teacherTableAdapter.Adapter.Update(main.cycle_commissionDataSet.Teacher);
                            bunifuTextBox1.Text = "";
                        }
                    }
                    if (radioButton2.Checked == true)
                    {
                        string data = String.Format(dateTimePicker2.Value.ToShortDateString());
                        Cycle_selection main = this.Owner as Cycle_selection;
                        if (main != null)
                        {
                            main.teacherTableAdapter.InsertQuery1(bunifuTextBox1.Text, data);
                            main.teacherTableAdapter.Fill(main.cycle_commissionDataSet.Teacher);
                            main.teacherTableAdapter.Adapter.Update(main.cycle_commissionDataSet.Teacher);
                            bunifuTextBox1.Text = "";
                        }
                    }
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены что хотите добавить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        if (radioButton1.Checked == true)
                        {
                            int id = (int)comboBox1.SelectedValue;
                            string data = String.Format(dateTimePicker2.Value.ToShortDateString());
                            Cycle_selection main = this.Owner as Cycle_selection;
                            if (main != null)
                            {
                                main.teacherTableAdapter.InsertQuery(bunifuTextBox1.Text, data, id);
                                main.teacherTableAdapter.Fill(main.cycle_commissionDataSet.Teacher);
                                main.teacherTableAdapter.Adapter.Update(main.cycle_commissionDataSet.Teacher);
                                bunifuTextBox1.Text = "";
                            }
                        }
                        if (radioButton2.Checked == true)
                        {
                            string data = String.Format(dateTimePicker2.Value.ToShortDateString());
                            Cycle_selection main = this.Owner as Cycle_selection;
                            if (main != null)
                            {
                                main.teacherTableAdapter.InsertQuery1(bunifuTextBox1.Text, data);
                                main.teacherTableAdapter.Fill(main.cycle_commissionDataSet.Teacher);
                                main.teacherTableAdapter.Adapter.Update(main.cycle_commissionDataSet.Teacher);
                                bunifuTextBox1.Text = "";
                            }
                        }
                    }
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                label4.Text = "Кабинет";
                comboBox1.Visible = true;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                label4.Text = "Кабинета нету";
                comboBox1.Visible = false;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
