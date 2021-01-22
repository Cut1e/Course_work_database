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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cycle_commissionDataSet.EnforceConstraints = false;
                // TODO: This line of code loads data into the 'Cycle_commissionDataSet.Event_' table. You can move, or remove it, as needed.
                this.Event_TableAdapter.Fill(this.Cycle_commissionDataSet.Event_);
                // TODO: This line of code loads data into the 'Cycle_commissionDataSet.Responsible' table. You can move, or remove it, as needed.
                this.ResponsibleTableAdapter.Fill(this.Cycle_commissionDataSet.Responsible);
                // TODO: This line of code loads data into the 'Cycle_commissionDataSet.Teacher' table. You can move, or remove it, as needed.
                this.teacherTableAdapter.Fill(this.Cycle_commissionDataSet.Teacher);
                // TODO: This line of code loads data into the 'cycle_commissionDataSet2.type_of_event' table. You can move, or remove it, as needed.
                this.type_of_eventTableAdapter.Fill(this.cycle_commissionDataSet2.type_of_event);
                // TODO: This line of code loads data into the 'Cycle_commissionDataSet.DataTable4' table. You can move, or remove it, as needed.
                this.DataTable4TableAdapter.Fill(this.Cycle_commissionDataSet.DataTable4);
                // TODO: This line of code loads data into the 'Cycle_commissionDataSet.DataTable3' table. You can move, or remove it, as needed.
                this.DataTable3TableAdapter.Fill(this.Cycle_commissionDataSet.DataTable3);
                // TODO: This line of code loads data into the 'Cycle_commissionDataSet.DataTable2' table. You can move, or remove it, as needed.
                this.DataTable2TableAdapter.Fill(this.Cycle_commissionDataSet.DataTable2);
                // TODO: This line of code loads data into the 'Cycle_commissionDataSet.DataTable1' table. You can move, or remove it, as needed.
                this.DataTable1TableAdapter.Fill(this.Cycle_commissionDataSet.DataTable1, comboBox4.Text);
                // TODO: This line of code loads data into the 'Cycle_commissionDataSet.goals' table. You can move, or remove it, as needed.
                this.goalsTableAdapter.Fill(this.Cycle_commissionDataSet.goals);
                // TODO: This line of code loads data into the 'Cycle_commissionDataSet.Years' table. You can move, or remove it, as needed.
                this.yearsTableAdapter.Fill(this.Cycle_commissionDataSet.Years);
                // TODO: This line of code loads data into the 'Cycle_commissionDataSet.Cycle' table. You can move, or remove it, as needed.
                this.CycleTableAdapter.Fill(this.Cycle_commissionDataSet.Cycle);
                this.cycleTableAdapter1.Fill(this.cycle_commissionDataSet1.Cycle);
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
                reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Cycle", comboBox1.Text));
                reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("years", comboBox2.Text));
                this.CycleTableAdapter.Main_rep(Cycle_commissionDataSet.Cycle, comboBox1.Text);
                reportViewer1.RefreshReport();
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
                int id = (int)comboBox3.SelectedValue;
                reportViewer2.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("years", comboBox3.Text));
                reportViewer2.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("description", bunifuTextBox1.Text));
                this.goalsTableAdapter.Goals_report(Cycle_commissionDataSet.goals, id);
                reportViewer2.RefreshReport();
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
                this.DataTable1TableAdapter.Fill(Cycle_commissionDataSet.DataTable1, comboBox4.Text);
                reportViewer3.RefreshReport();
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
                int id = (int)comboBox8.SelectedValue;
                this.DataTable2TableAdapter.Fill2(Cycle_commissionDataSet.DataTable2, id);
                reportViewer4.RefreshReport();
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
                int id = (int)comboBox9.SelectedValue;
                this.DataTable3TableAdapter.FillBy(Cycle_commissionDataSet.DataTable3, id);
                reportViewer5.RefreshReport();
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Event_TableAdapter.Fill(Cycle_commissionDataSet.Event_);
                this.ResponsibleTableAdapter.Fill(Cycle_commissionDataSet.Responsible);
                reportViewer6.RefreshReport();
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            try
            {
                this.Event_TableAdapter.Report_event(Cycle_commissionDataSet.Event_, comboBox5.Text);
                this.ResponsibleTableAdapter.Fill(Cycle_commissionDataSet.Responsible);
                reportViewer6.RefreshReport();
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            try
            {
                this.Event_TableAdapter.Just_cycle(Cycle_commissionDataSet.Event_, comboBox11.Text);
                this.ResponsibleTableAdapter.Fill(Cycle_commissionDataSet.Responsible);
                reportViewer6.RefreshReport();
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton13_Click(object sender, EventArgs e)
        {
            try
            {
                this.Event_TableAdapter.Report_event_cycle(Cycle_commissionDataSet.Event_, comboBox5.Text, comboBox11.Text);
                this.ResponsibleTableAdapter.Fill(Cycle_commissionDataSet.Responsible);
                reportViewer6.RefreshReport();
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)comboBox6.SelectedValue;
                this.Event_TableAdapter.Report_teacher(Cycle_commissionDataSet.Event_, id);
                this.ResponsibleTableAdapter.Fill(Cycle_commissionDataSet.Responsible);
                reportViewer6.RefreshReport();
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
                int id = (int)comboBox6.SelectedValue;
                this.Event_TableAdapter.Report_reacher_cycle(Cycle_commissionDataSet.Event_, id, comboBox11.Text);
                this.ResponsibleTableAdapter.Fill(Cycle_commissionDataSet.Responsible);
                reportViewer6.RefreshReport();
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            try
            {
                this.Event_TableAdapter.Report_years(Cycle_commissionDataSet.Event_, comboBox7.Text);
                this.ResponsibleTableAdapter.Fill(Cycle_commissionDataSet.Responsible);
                reportViewer6.RefreshReport();
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton15_Click(object sender, EventArgs e)
        {
            try
            {
                this.Event_TableAdapter.Report_years_cycle(Cycle_commissionDataSet.Event_, comboBox7.Text, comboBox11.Text);
                this.ResponsibleTableAdapter.Fill(Cycle_commissionDataSet.Responsible);
                reportViewer6.RefreshReport();
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            try
            {
                this.Event_TableAdapter.Report_month(Cycle_commissionDataSet.Event_, Convert.ToInt32(bunifuTextBox2.Text));
                this.ResponsibleTableAdapter.Fill(Cycle_commissionDataSet.Responsible);
                reportViewer6.RefreshReport();
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton16_Click(object sender, EventArgs e)
        {
            try
            {
                this.Event_TableAdapter.Report_month_cycle(Cycle_commissionDataSet.Event_, Convert.ToInt32(bunifuTextBox2.Text), comboBox11.Text);
                this.ResponsibleTableAdapter.Fill(Cycle_commissionDataSet.Responsible);
                reportViewer6.RefreshReport();
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar) ||
                (!string.IsNullOrEmpty(bunifuTextBox2.Text) && e.KeyChar == ','))
                {
                    return;
                }

                e.Handled = true;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
