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
    public partial class Add_cabinets : Form
    {
        public Add_cabinets()
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
                        main.cabinetsTableAdapter.InsertQuery(bunifuTextBox1.Text, Convert.ToInt32(bunifuTextBox2.Text));
                        main.cabinetsTableAdapter.Fill(main.cycle_commissionDataSet.Cabinets);
                        main.cabinetsTableAdapter.Adapter.Update(main.cycle_commissionDataSet.Cabinets);
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
                    if (MessageBox.Show("Вы уверены что хотите добавить запись?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cycle_selection main = this.Owner as Cycle_selection;
                        if (main != null)
                        {
                            main.cabinetsTableAdapter.InsertQuery(bunifuTextBox1.Text, Convert.ToInt32(bunifuTextBox2.Text));
                            main.cabinetsTableAdapter.Fill(main.cycle_commissionDataSet.Cabinets);
                            main.cabinetsTableAdapter.Adapter.Update(main.cycle_commissionDataSet.Cabinets);
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

