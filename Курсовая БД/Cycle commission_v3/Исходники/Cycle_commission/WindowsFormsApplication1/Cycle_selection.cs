using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Cycle_selection : Form
    {
        public Cycle_selection()
        {
            InitializeComponent();
        }

        private void Cycle_selection_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cycle_commissionDataSet.Composition' table. You can move, or remove it, as needed.
            this.compositionTableAdapter.Fill(this.cycle_commissionDataSet.Composition);
            // TODO: This line of code loads data into the 'cycle_commissionDataSet.Cycle' table. You can move, or remove it, as needed.
            this.cycleTableAdapter.Fill(this.cycle_commissionDataSet.Cycle);

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
                MessageBox.Show(help.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
