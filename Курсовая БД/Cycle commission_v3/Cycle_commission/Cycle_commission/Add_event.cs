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
    public partial class Add_event : Form
    {
        public Add_event()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dateTimePicker1.Visible = true;
                label3.Text = "Фактическая дата";
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
                dateTimePicker1.Visible = false;
                label3.Text = "Нету даты";
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_event_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'cycle_commissionDataSet.goals' table. You can move, or remove it, as needed.
                this.goalsTableAdapter.Fill(this.cycle_commissionDataSet.goals);
                // TODO: This line of code loads data into the 'cycle_commissionDataSet.type_of_event' table. You can move, or remove it, as needed.
                this.type_of_eventTableAdapter.Fill(this.cycle_commissionDataSet.type_of_event);
                // TODO: This line of code loads data into the 'cycle_commissionDataSet.Cycle' table. You can move, or remove it, as needed.
                this.cycleTableAdapter.Fill(this.cycle_commissionDataSet.Cycle);
                // TODO: This line of code loads data into the 'cycle_commissionDataSet.Years' table. You can move, or remove it, as needed.
                this.yearsTableAdapter.Fill(this.cycle_commissionDataSet.Years);
                // TODO: This line of code loads data into the 'cycle_commissionDataSet.Discipline' table. You can move, or remove it, as needed.
                this.disciplineTableAdapter.Fill(this.cycle_commissionDataSet.Discipline);
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
                        int id2 = (int)comboBox2.SelectedValue;
                        int id3 = (int)comboBox3.SelectedValue;
                        int id4 = (int)comboBox4.SelectedValue;
                        int id5 = (int)comboBox5.SelectedValue;
                        string data = String.Format(dateTimePicker2.Value.ToShortDateString());
                        string data2 = String.Format(dateTimePicker1.Value.ToShortDateString());
                        Cycle_selection main = this.Owner as Cycle_selection;
                        if (main != null)
                        {
                            main.event_TableAdapter.InsertQuery(data, data2, bunifuTextBox1.Text, id, id2, id3, id4, id5);
                            main.event_TableAdapter.Fill(main.cycle_commissionDataSet.Event_);
                            main.event_TableAdapter.Adapter.Update(main.cycle_commissionDataSet.Event_);
                            bunifuTextBox1.Text = "";
                        }

                    }

                    if (radioButton2.Checked == true)
                    {
                        int id = (int)comboBox1.SelectedValue;
                        int id2 = (int)comboBox2.SelectedValue;
                        int id3 = (int)comboBox3.SelectedValue;
                        int id4 = (int)comboBox4.SelectedValue;
                        int id5 = (int)comboBox5.SelectedValue;
                        string data = String.Format(dateTimePicker2.Value.ToShortDateString());
                        Cycle_selection main = this.Owner as Cycle_selection;
                        if (main != null)
                        {
                            main.event_TableAdapter.InsertQuery1(data, bunifuTextBox1.Text, id, id2, id3, id4, id5);
                            main.event_TableAdapter.Fill(main.cycle_commissionDataSet.Event_);
                            main.event_TableAdapter.Adapter.Update(main.cycle_commissionDataSet.Event_);
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
    }
}
