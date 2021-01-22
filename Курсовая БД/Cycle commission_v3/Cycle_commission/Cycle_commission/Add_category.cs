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
    public partial class Add_category : Form
    {
        public Add_category()
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
                    string data = String.Format(dateTimePicker2.Value.ToShortDateString());
                    Cycle_selection main = this.Owner as Cycle_selection;
                    if (main != null)
                    {
                        main.categoryTableAdapter.InsertQuery(bunifuTextBox1.Text, data, bunifuTextBox2.Text, Convert.ToInt32(main.bunifuDataGridView6.Rows[main.bunifuDataGridView6.CurrentCell.RowIndex].Cells[0].Value));
                        main.categoryTableAdapter.Fill(main.cycle_commissionDataSet.Category);
                        main.categoryTableAdapter.Adapter.Update(main.cycle_commissionDataSet.Category);
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
                if (MessageBox.Show("Вы уверены что хотите добавить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        string data = String.Format(dateTimePicker2.Value.ToShortDateString());
                        Cycle_selection main = this.Owner as Cycle_selection;
                        if (main != null)
                        {
                            main.categoryTableAdapter.InsertQuery(bunifuTextBox1.Text, data, bunifuTextBox2.Text, Convert.ToInt32(main.bunifuDataGridView6.Rows[main.bunifuDataGridView6.CurrentCell.RowIndex].Cells[0].Value));
                            main.categoryTableAdapter.Fill(main.cycle_commissionDataSet.Category);
                            main.categoryTableAdapter.Adapter.Update(main.cycle_commissionDataSet.Category);
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
