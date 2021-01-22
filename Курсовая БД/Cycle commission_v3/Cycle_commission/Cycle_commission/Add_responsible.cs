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
    public partial class Add_responsible : Form
    {
        public Add_responsible()
        {
            InitializeComponent();
        }

        private void Add_responsible_Load(object sender, EventArgs e)
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
                        main.responsibleTableAdapter.InsertQuery(Convert.ToInt32(main.bunifuDataGridView9.Rows[main.bunifuDataGridView9.CurrentCell.RowIndex].Cells[0].Value), id);
                        main.responsibleTableAdapter.Fill(main.cycle_commissionDataSet.Responsible);
                        main.responsibleTableAdapter.Adapter.Update(main.cycle_commissionDataSet.Responsible);
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
