using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimtToo.VisualReactive;
using System.Diagnostics;

namespace Cycle_commission
{
    public partial class Cycle_selection : Form
    {
        public Cycle_selection()
        {
            InitializeComponent();
            bunifuDataGridView6.DataError += new DataGridViewDataErrorEventHandler(bunifuDataGridView6_DataError);
        }
        bool mnuExpanded = false;
        private void MouseDetect_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!bunifuTransition1.IsCompleted) return;
                if (pnlMainMenu.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
                {
                    if (!mnuExpanded)
                    {
                        mnuExpanded = true;
                        pnlMainMenu.Width = 205;
                    }
                }
                else
                {
                    if (mnuExpanded)
                    {
                        mnuExpanded = false;
                        pnlMainMenu.Visible = false;
                        pnlMainMenu.Width = 45;
                        bunifuTransition1.Show(pnlMainMenu);
                    }
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tab1_Click(object sender, EventArgs e)
        {
            try
            {
                VSReactive<int>.SetState("event", int.Parse(((Control)sender).Tag.ToString()));
                teachers.Visible = false;
                Discipline.Visible = false;
                type_of_event.Visible = false;
                goals_and_years.Visible = false;
                kabinets.Visible = false;
                Events.Visible = true;
                Cycle.Visible = false;
                teacherBindingSource.Filter = null;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tab2_Click(object sender, EventArgs e)
        {
            try
            {
                VSReactive<int>.SetState("event", int.Parse(((Control)sender).Tag.ToString()));
                teachers.Visible = true;
                Discipline.Visible = false;
                type_of_event.Visible = false;
                goals_and_years.Visible = false;
                kabinets.Visible = false;
                Events.Visible = false;
                Cycle.Visible = false;
                teacherBindingSource.Filter = null;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tab3_Click(object sender, EventArgs e)
        {
            try
            {
                VSReactive<int>.SetState("event", int.Parse(((Control)sender).Tag.ToString()));
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cycle_selection_Load(object sender, EventArgs e)
        {
            try
            {
                this.cycle_commissionDataSet1.EnforceConstraints = false;
                this.cycle_commissionDataSet.EnforceConstraints = false;
                this.teacherTableAdapter.Fill(this.cycle_commissionDataSet.Teacher);
                // TODO: This line of code loads data into the 'cycle_commissionDataSet.Responsible' table. You can move, or remove it, as needed.
                this.responsibleTableAdapter.Fill(this.cycle_commissionDataSet.Responsible);
                // TODO: This line of code loads data into the 'cycle_commissionDataSet.Composition' table. You can move, or remove it, as needed.
                this.compositionTableAdapter.Fill(this.cycle_commissionDataSet.Composition);
                // TODO: This line of code loads data into the 'cycle_commissionDataSet.Event_' table. You can move, or remove it, as needed.
                this.event_TableAdapter.Fill(this.cycle_commissionDataSet.Event_);
                // TODO: This line of code loads data into the 'cycle_commissionDataSet.Cycle' table. You can move, or remove it, as needed.
                this.cycleTableAdapter.Fill(this.cycle_commissionDataSet.Cycle);
                this.cycleTableAdapter.Fill(this.cycle_commissionDataSet1.Cycle);

                // TODO: This line of code loads data into the 'cycle_commissionDataSet1.Cabinets' table. You can move, or remove it, as needed.
                this.cabinetsTableAdapter.Fill(this.cycle_commissionDataSet1.Cabinets);
                // TODO: This line of code loads data into the 'cycle_commissionDataSet.Additional_event' table. You can move, or remove it, as needed.
                this.additional_eventTableAdapter.Fill(this.cycle_commissionDataSet.Additional_event);
                // TODO: This line of code loads data into the 'cycle_commissionDataSet.Category' table. You can move, or remove it, as needed.
                this.categoryTableAdapter.Fill(this.cycle_commissionDataSet.Category);
                // TODO: This line of code loads data into the 'cycle_commissionDataSet.Teacher' table. You can move, or remove it, as needed.

                this.additional_eventTableAdapter.Fill(this.cycle_commissionDataSet.Additional_event);
                // TODO: This line of code loads data into the 'cycle_commissionDataSet.Category' table. You can move, or remove it, as needed.
                this.categoryTableAdapter.Fill(this.cycle_commissionDataSet.Category);
                // TODO: This line of code loads data into the 'cycle_commissionDataSet1.Teacher' table. You can move, or remove it, as needed.

                // TODO: This line of code loads data into the 'cycle_commissionDataSet.Cabinets' table. You can move, or remove it, as needed.
                this.cabinetsTableAdapter.Fill(this.cycle_commissionDataSet.Cabinets);
                // TODO: This line of code loads data into the 'cycle_commissionDataSet.goals' table. You can move, or remove it, as needed.
                this.goalsTableAdapter.Fill(this.cycle_commissionDataSet.goals);
                // TODO: This line of code loads data into the 'cycle_commissionDataSet.goals' table. You can move, or remove it, as needed.
                this.goalsTableAdapter.Fill(this.cycle_commissionDataSet.goals);
                // TODO: This line of code loads data into the 'cycle_commissionDataSet.Years' table. You can move, or remove it, as needed.
                this.yearsTableAdapter.Fill(this.cycle_commissionDataSet.Years);
                // TODO: This line of code loads data into the 'cycle_commissionDataSet.type_of_event' table. You can move, or remove it, as needed.
                this.type_of_eventTableAdapter.Fill(this.cycle_commissionDataSet.type_of_event);
                // TODO: This line of code loads data into the 'cycle_commissionDataSet.Discipline' table. You can move, or remove it, as needed.
                this.disciplineTableAdapter.Fill(this.cycle_commissionDataSet.Discipline);
                Add_discipline form1 = new Add_discipline();
                form1.Owner = this;
                Add_additional_event form2 = new Add_additional_event();
                form2.Owner = this;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                VSReactive<int>.SetState("event", int.Parse(((Control)sender).Tag.ToString()));
                Discipline.Visible = true;
                type_of_event.Visible = false;
                goals_and_years.Visible = false;
                kabinets.Visible = false;
                teachers.Visible = false;
                Events.Visible = false;
                Cycle.Visible = false;
                teacherBindingSource.Filter = null;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuTextBox1_TextChange_1(object sender, EventArgs e)
        {
            try
            {
                disciplineBindingSource.Filter = "[title_discipline] LIKE'" + bunifuTextBox1.Text + "%'";
                if (bunifuTextBox1.Text == "")
                    disciplineBindingSource.Filter = null;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            try
            {
                disciplineBindingSource.Filter = null;
                bunifuTextBox1.Text = "";
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                VSReactive<int>.SetState("event", int.Parse(((Control)sender).Tag.ToString()));
                Discipline.Visible = false;
                type_of_event.Visible = true;
                goals_and_years.Visible = false;
                kabinets.Visible = false;
                teachers.Visible = false;
                Events.Visible = false;
                Cycle.Visible = false;
                teacherBindingSource.Filter = null;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuTextBox2_TextChange(object sender, EventArgs e)
        {
            try
            {
                typeofeventBindingSource.Filter = "[title_type_of_event] LIKE'" + bunifuTextBox2.Text + "%'";
                if (bunifuTextBox2.Text == "")
                    typeofeventBindingSource.Filter = null;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                kabinets.Visible = false;
                typeofeventBindingSource.Filter = null;
                bunifuTextBox2.Text = "";
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            try
            {
                VSReactive<int>.SetState("event", int.Parse(((Control)sender).Tag.ToString()));
                Discipline.Visible = false;
                type_of_event.Visible = false;
                goals_and_years.Visible = true;
                kabinets.Visible = false;
                teachers.Visible = false;
                Events.Visible = false;
                Cycle.Visible = false;
                teacherBindingSource.Filter = null;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuTextBox3_TextChange(object sender, EventArgs e)
        {
            try
            {
                fKgoalsidyears1FCDBCEBBindingSource.Filter = "[title_of_goals] LIKE'" + bunifuTextBox3.Text + "%' or [goals_description] LIKE'" + bunifuTextBox3.Text + "%'";
                if (bunifuTextBox3.Text == "")
                    fKgoalsidyears1FCDBCEBBindingSource.Filter = null;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            try
            {
                fKgoalsidyears1FCDBCEBBindingSource.Filter = null;
                bunifuTextBox3.Text = null;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            try
            {
                VSReactive<int>.SetState("event", int.Parse(((Control)sender).Tag.ToString()));
                Discipline.Visible = false;
                type_of_event.Visible = false;
                goals_and_years.Visible = false;
                kabinets.Visible = true;
                teachers.Visible = false;
                Events.Visible = false;
                Cycle.Visible = false;
                teacherBindingSource.Filter = null;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuTextBox4_TextChange(object sender, EventArgs e)
        {
            try
            {
                if (bunifuDropdown2.selectedIndex == 0)
                    cabinetsBindingSource.Filter = "[title_of_cabinets] LIKE'" + bunifuTextBox4.Text + "%'";
                if (bunifuDropdown2.selectedIndex == 1 && bunifuTextBox4.Text != "")
                    cabinetsBindingSource.Filter = "[number_of_cabinets]=\'" + bunifuTextBox4.Text + "\'";
                if (bunifuTextBox4.Text == "")
                    cabinetsBindingSource.Filter = null;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            try
            {
                cabinetsBindingSource.Filter = null;
                bunifuTextBox4.Text = "1";
                bunifuTextBox4.Text = "";
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuDropdown2_onItemSelected_1(object sender, EventArgs e)
        {
            try
            {
                bunifuTextBox4.Text = "";
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuDataGridView6_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                e.ThrowException = false;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuDataGridView6_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            try
            {
                String value = e.Value as string;
                if ((value != null) && value.Equals(e.CellStyle.DataSourceNullValue))
                {
                    e.Value = e.CellStyle.NullValue;
                    e.FormattingApplied = true;
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void удалитьКабинетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                teacherTableAdapter.UpdateQuery1(System.Convert.ToString(bunifuDataGridView6.SelectedCells[1].Value),
       System.Convert.ToString(bunifuDataGridView6.SelectedCells[2].Value),
                System.Convert.ToInt32(bunifuDataGridView6.SelectedCells[0].Value));
                teacherTableAdapter.Fill(cycle_commissionDataSet.Teacher);
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bunifuTextBox5_TextChange(object sender, EventArgs e)
        {
            try
            {
                teacherBindingSource.Filter = "[FIO_teatcher] LIKE'" + bunifuTextBox5.Text + "%'";
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            try
            {
                teacherBindingSource.Filter = null;
                bunifuTextBox5.Text = "";
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bunifuTextBox6_TextChange(object sender, EventArgs e)
        {
            try
            {
                if (bunifuTextBox6.Text == "")
                {
                    teacherTableAdapter.Fill(cycle_commissionDataSet.Teacher);
                }
                if (bunifuTextBox6.Text != "")
                    teacherTableAdapter.FillBy(cycle_commissionDataSet.Teacher, Convert.ToInt32(bunifuTextBox6.Text));
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            try
            {
                VSReactive<int>.SetState("event", int.Parse(((Control)sender).Tag.ToString()));
                Discipline.Visible = false;
                type_of_event.Visible = false;
                goals_and_years.Visible = false;
                kabinets.Visible = false;
                teachers.Visible = false;
                Events.Visible = false;
                Cycle.Visible = true;
                teacherBindingSource.Filter = null;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            try
            {
                cycleBindingSource.Filter = null;
                bunifuTextBox8.Text = "";
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuTextBox8_TextChange(object sender, EventArgs e)
        {
            try
            {
                cycleBindingSource.Filter = "[title_of_cycle] LIKE'" + bunifuTextBox8.Text + "%' or [FIO_teatcher] LIKE'" + bunifuTextBox8.Text + "%'";
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            try
            {
                eventBindingSource.Filter = null;
                bunifuTextBox7.Text = null;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuDataGridView9_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                e.ThrowException = false;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuDataGridView10_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                e.ThrowException = false;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuTextBox7_TextChange(object sender, EventArgs e)
        {
            try
            {
                eventBindingSource.Filter = "[description_of_event] LIKE'" + bunifuTextBox7.Text + "%' or [title_discipline] LIKE'" + bunifuTextBox7.Text +
                    "%' or [title_of_goals] LIKE'" + bunifuTextBox7.Text + "%' or [title_of_cycle] LIKE'" + bunifuTextBox7.Text + "%' or [title_type_of_event] LIKE'" +
                    bunifuTextBox7.Text + "%' or [goals_description] LIKE'" + bunifuTextBox7.Text + "%' or [title_years] LIKE'" + bunifuTextBox7.Text + "%'";
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuDataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                e.ThrowException = false;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuDataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                e.ThrowException = false;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuDataGridView3_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                e.ThrowException = false;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuDataGridView4_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                e.ThrowException = false;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuDataGridView5_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                e.ThrowException = false;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuDataGridView7_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                e.ThrowException = false;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuDataGridView8_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                e.ThrowException = false;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuDataGridView11_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                e.ThrowException = false;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.SelectedValue != null)
                {
                    int id = (int)comboBox2.SelectedValue;
                    event_TableAdapter.Cycle_fill(cycle_commissionDataSet.Event_, id);
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cycle_selection_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    e.Cancel = true;
                    if (MessageBox.Show("Вы уверены что хотите закрыть программу?", "Выйти?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            try
            {
                event_TableAdapter.Fill(cycle_commissionDataSet.Event_);
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            try
            {
                Process SysInfo = new Process();
                SysInfo.StartInfo.ErrorDialog = true;
                SysInfo.StartInfo.FileName = "References.chm";
                SysInfo.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }
       
    

