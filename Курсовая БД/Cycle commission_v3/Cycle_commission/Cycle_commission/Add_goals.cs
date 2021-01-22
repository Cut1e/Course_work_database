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
    public partial class Add_goals : Form
    {
        public Add_goals()
        {
            InitializeComponent();
        }

        private void bunifuTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    bunifuTextBox2.Focus();
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
                    Cycle_selection main = this.Owner as Cycle_selection;
                    if (main != null)
                    {
                        main.goalsTableAdapter.InsertQuery(bunifuTextBox1.Text, bunifuTextBox2.Text, Convert.ToInt32(main.bunifuDataGridView2.Rows[main.bunifuDataGridView2.CurrentCell.RowIndex].Cells[0].Value));
                        main.goalsTableAdapter.Fill(main.cycle_commissionDataSet.goals);
                        main.goalsTableAdapter.Adapter.Update(main.cycle_commissionDataSet.goals);
                        bunifuTextBox1.Text = "";
                        bunifuTextBox2.Text = "";

                    }
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (MessageBox.Show("Вы уверены что хотите добавить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cycle_selection main = this.Owner as Cycle_selection;
                        if (main != null)
                        {
                            main.goalsTableAdapter.InsertQuery(bunifuTextBox1.Text, bunifuTextBox2.Text, Convert.ToInt32(main.bunifuDataGridView2.Rows[main.bunifuDataGridView2.CurrentCell.RowIndex].Cells[0].Value));
                            main.goalsTableAdapter.Fill(main.cycle_commissionDataSet.goals);
                            main.goalsTableAdapter.Adapter.Update(main.cycle_commissionDataSet.goals);
                            bunifuTextBox1.Text = "";
                            bunifuTextBox2.Text = "";

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
