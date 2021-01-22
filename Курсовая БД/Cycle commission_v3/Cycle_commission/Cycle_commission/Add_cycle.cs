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
    public partial class Add_cycle : Form
    {
        public Add_cycle()
        {
            InitializeComponent();
        }

        private void Add_cycle_Load(object sender, EventArgs e)
        {
            try
            {
                this.cycle_commissionDataSet.EnforceConstraints = false;
                // TODO: This line of code loads data into the 'cycle_commissionDataSet.Teacher' table. You can move, or remove it, as needed.
                this.teacherTableAdapter.Fill(this.cycle_commissionDataSet.Teacher);
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
                    int id = (int)comboBox1.SelectedValue;
                    Cycle_selection main = this.Owner as Cycle_selection;
                    if (main != null)
                    {
                        main.cycleTableAdapter.InsertQuery(bunifuTextBox1.Text, id);
                        main.cycleTableAdapter.Fill(main.cycle_commissionDataSet.Cycle);
                        main.cycleTableAdapter.Adapter.Update(main.cycle_commissionDataSet.Cycle);
                        bunifuTextBox1.Text = "";
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
