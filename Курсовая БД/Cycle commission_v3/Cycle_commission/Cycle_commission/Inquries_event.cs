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
    public partial class Inquries_event : Form
    {
        public Inquries_event()
        {
            InitializeComponent();
        }

        private void Inquries_event_Load(object sender, EventArgs e)
        {
            try
            {
                this.cycle_commissionDataSet.EnforceConstraints = false;
                // TODO: This line of code loads data into the 'cycle_commissionDataSet.Teacher' table. You can move, or remove it, as needed.
                this.teacherTableAdapter.Fill(this.cycle_commissionDataSet.Teacher);
                // TODO: This line of code loads data into the 'cycle_commissionDataSet.Composition' table. You can move, or remove it, as needed.
                this.compositionTableAdapter.Fill(this.cycle_commissionDataSet.Composition);
                // TODO: This line of code loads data into the 'cycle_commissionDataSet.Cycle' table. You can move, or remove it, as needed.
                this.cycleTableAdapter.Fill(this.cycle_commissionDataSet.Cycle);
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
                int id = (int)comboBox2.SelectedValue;
                Cycle_selection main = this.Owner as Cycle_selection;
                if (main != null)
                {
                    main.event_TableAdapter.Cycle_fill(main.cycle_commissionDataSet.Event_, id);
                }
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
                Cycle_selection main = this.Owner as Cycle_selection;
                if (main != null)
                {
                    main.event_TableAdapter.Fill(main.cycle_commissionDataSet.Event_);
                }
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
                Cycle_selection main = this.Owner as Cycle_selection;
                if (main != null)
                {
                    main.event_TableAdapter.Teacher_fill(main.cycle_commissionDataSet.Event_, Convert.ToInt32(listBox1.SelectedValue));
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                Cycle_selection main = this.Owner as Cycle_selection;
                if (main != null)
                {
                    main.event_TableAdapter.Fill(main.cycle_commissionDataSet.Event_);
                }
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
                int id2 = (int)comboBox2.SelectedValue;
                int id = (int)comboBox1.SelectedValue;
                compositionTableAdapter.InsertQuery(id, id2);
                compositionTableAdapter.Fill(cycle_commissionDataSet.Composition);
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                compositionTableAdapter.DeleteQuery(Convert.ToInt32(listBox2.SelectedValue));
                compositionTableAdapter.Fill(cycle_commissionDataSet.Composition);
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
