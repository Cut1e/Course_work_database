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
    public partial class Add_years : Form
    {
        public Add_years()
        {
            InitializeComponent();
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
                        main.yearsTableAdapter.InsertQuery(bunifuTextBox1.Text);
                        main.yearsTableAdapter.Fill(main.cycle_commissionDataSet.Years);
                        main.yearsTableAdapter.Adapter.Update(main.cycle_commissionDataSet.Years);
                        bunifuTextBox1.Text = "";
                    }
                }
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
                if (MessageBox.Show("Вы уверены что хотите добавить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        Cycle_selection main = this.Owner as Cycle_selection;
                        if (main != null)
                        {
                            main.yearsTableAdapter.InsertQuery(bunifuTextBox1.Text);
                            main.yearsTableAdapter.Fill(main.cycle_commissionDataSet.Years);
                            main.yearsTableAdapter.Adapter.Update(main.cycle_commissionDataSet.Years);
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
