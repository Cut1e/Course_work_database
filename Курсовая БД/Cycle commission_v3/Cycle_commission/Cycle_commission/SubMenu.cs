using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimtToo.VisualReactive;

namespace Cycle_commission
{
    public partial class SubMenu : UserControl
    {
        public SubMenu()
        {
            try
            {
                InitializeComponent();
                if (Program.IsInDesignMode()) return;
                hider.Height = 25;
                VSReactive<int>.Subscribe("event", e => tabControl1.SelectedIndex = e);
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bunifuFlatButton20_Click(object sender, EventArgs e)
        {
            try
            {
                Add_additional_event form1 = new Add_additional_event();
                Cycle_selection main;
                main = (Cycle_selection)this.FindForm();
                form1.Owner = main;
                form1.ShowDialog();
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
                Add_discipline form1 = new Add_discipline();
                Cycle_selection main;
                main = (Cycle_selection)this.FindForm();
                form1.Owner = main;
                form1.ShowDialog();
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
                if (MessageBox.Show("Вы уверены что хотите обновить выбранную запись?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cycle_selection main;
                    main = (Cycle_selection)this.FindForm();
                    this.Focus();
                    main.disciplineTableAdapter.Adapter.Update(main.cycle_commissionDataSet.Discipline);
                }
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
                if (MessageBox.Show("Вы уверены что хотите удалить выбранную запись?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cycle_selection main;
                    main = (Cycle_selection)this.FindForm();
                    main.disciplineTableAdapter.DeleteQuery(System.Convert.ToInt32(main.bunifuDataGridView3.SelectedCells[0].Value));
                    main.disciplineTableAdapter.Fill(main.cycle_commissionDataSet.Discipline);
                    main.event_TableAdapter.Fill(main.cycle_commissionDataSet.Event_);
                }
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
                Cycle_selection main;
                main = (Cycle_selection)this.FindForm();
                main.disciplineTableAdapter.Update(main.cycle_commissionDataSet.Discipline);
                main.disciplineTableAdapter.Fill(main.cycle_commissionDataSet.Discipline);
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton24_Click(object sender, EventArgs e)
        {
            try
            {
                Add_type_of_event form1 = new Add_type_of_event();
                Cycle_selection main;
                main = (Cycle_selection)this.FindForm();
                form1.Owner = main;
                form1.ShowDialog();
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
                if (MessageBox.Show("Вы уверены что хотите обновить выбранную запись?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cycle_selection main;
                    main = (Cycle_selection)this.FindForm();
                    this.Focus();
                    if ((main.bunifuDataGridView9.SelectedCells[2].Value != DBNull.Value))
                    {
                        main.event_TableAdapter.UpdateQuery(System.Convert.ToString(main.bunifuDataGridView9.SelectedCells[1].Value),
                        System.Convert.ToString(main.bunifuDataGridView9.SelectedCells[2].Value),
                       System.Convert.ToString(main.bunifuDataGridView9.SelectedCells[3].Value),
                       System.Convert.ToInt32(main.bunifuDataGridView9.SelectedCells[4].Value),
                       System.Convert.ToInt32(main.bunifuDataGridView9.SelectedCells[5].Value),
                       System.Convert.ToInt32(main.bunifuDataGridView9.SelectedCells[6].Value),
                       System.Convert.ToInt32(main.bunifuDataGridView9.SelectedCells[7].Value),
                       System.Convert.ToInt32(main.bunifuDataGridView9.SelectedCells[8].Value),
                       System.Convert.ToInt32(main.bunifuDataGridView9.SelectedCells[0].Value));
                        main.event_TableAdapter.Fill(main.cycle_commissionDataSet.Event_);
                    }
                    if ((main.bunifuDataGridView9.SelectedCells[2].Value == DBNull.Value))
                    {
                        main.event_TableAdapter.UpdateQuery1(System.Convert.ToString(main.bunifuDataGridView9.SelectedCells[1].Value),
                       System.Convert.ToString(main.bunifuDataGridView9.SelectedCells[3].Value),
                       System.Convert.ToInt32(main.bunifuDataGridView9.SelectedCells[4].Value),
                       System.Convert.ToInt32(main.bunifuDataGridView9.SelectedCells[5].Value),
                       System.Convert.ToInt32(main.bunifuDataGridView9.SelectedCells[6].Value),
                       System.Convert.ToInt32(main.bunifuDataGridView9.SelectedCells[7].Value),
                       System.Convert.ToInt32(main.bunifuDataGridView9.SelectedCells[8].Value),
                       System.Convert.ToInt32(main.bunifuDataGridView9.SelectedCells[0].Value));
                        main.event_TableAdapter.Fill(main.cycle_commissionDataSet.Event_);
                    }
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton23_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены что хотите обновить выбранную запись?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cycle_selection main;
                    main = (Cycle_selection)this.FindForm();
                    this.Focus();
                    main.type_of_eventTableAdapter.Adapter.Update(main.cycle_commissionDataSet.type_of_event);
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton22_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены что хотите удалить выбранную запись?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cycle_selection main;
                    main = (Cycle_selection)this.FindForm();
                    main.type_of_eventTableAdapter.DeleteQuery(System.Convert.ToInt32(main.bunifuDataGridView1.SelectedCells[0].Value));
                    main.type_of_eventTableAdapter.Fill(main.cycle_commissionDataSet.type_of_event);
                    main.event_TableAdapter.Fill(main.cycle_commissionDataSet.Event_);
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton21_Click(object sender, EventArgs e)
        {
            try
            {
                Cycle_selection main;
                main = (Cycle_selection)this.FindForm();
                main.type_of_eventTableAdapter.Update(main.cycle_commissionDataSet.type_of_event);
                main.type_of_eventTableAdapter.Fill(main.cycle_commissionDataSet.type_of_event);
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton28_Click(object sender, EventArgs e)
        {
            try
            {
                Add_years form1 = new Add_years();
                Cycle_selection main;
                main = (Cycle_selection)this.FindForm();
                form1.Owner = main;
                form1.ShowDialog();
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton32_Click(object sender, EventArgs e)
        {
            try
            {
                Add_goals form1 = new Add_goals();
                Cycle_selection main;
                main = (Cycle_selection)this.FindForm();
                form1.Owner = main;
                form1.ShowDialog();
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton27_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены что хотите обновить выбранную запись?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cycle_selection main;
                    main = (Cycle_selection)this.FindForm();
                    this.Focus();
                    main.yearsTableAdapter.Adapter.Update(main.cycle_commissionDataSet.Years);
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton31_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены что хотите обновить выбранную запись?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cycle_selection main;
                    main = (Cycle_selection)this.FindForm();
                    this.Focus();
                    main.goalsTableAdapter.Adapter.Update(main.cycle_commissionDataSet.goals);
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton26_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены что хотите удалить выбранную запись?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cycle_selection main;
                    main = (Cycle_selection)this.FindForm();
                    main.yearsTableAdapter.DeleteQuery(System.Convert.ToInt32(main.bunifuDataGridView2.SelectedCells[0].Value));
                    main.yearsTableAdapter.Fill(main.cycle_commissionDataSet.Years);
                    main.event_TableAdapter.Fill(main.cycle_commissionDataSet.Event_);
                    main.goalsTableAdapter.Fill(main.cycle_commissionDataSet.goals);
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton30_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены что хотите удалить выбранную запись?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cycle_selection main;
                    main = (Cycle_selection)this.FindForm();
                    main.goalsTableAdapter.DeleteQuery(System.Convert.ToInt32(main.bunifuDataGridView4.SelectedCells[0].Value));
                    main.goalsTableAdapter.Fill(main.cycle_commissionDataSet.goals);
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton25_Click(object sender, EventArgs e)
        {
            try
            {
                Cycle_selection main;
                main = (Cycle_selection)this.FindForm();
                main.yearsTableAdapter.Update(main.cycle_commissionDataSet.Years);
                main.yearsTableAdapter.Fill(main.cycle_commissionDataSet.Years);
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton29_Click(object sender, EventArgs e)
        {
            try
            {
                Cycle_selection main;
                main = (Cycle_selection)this.FindForm();
                main.goalsTableAdapter.Update(main.cycle_commissionDataSet.goals);
                main.goalsTableAdapter.Fill(main.cycle_commissionDataSet.goals);
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton35_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены что хотите обновить выбранную запись?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cycle_selection main;
                    main = (Cycle_selection)this.FindForm();
                    this.Focus();
                    main.cabinetsTableAdapter.Adapter.Update(main.cycle_commissionDataSet.Cabinets);
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton34_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены что хотите удалить выбранную запись?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cycle_selection main;
                    main = (Cycle_selection)this.FindForm();
                    main.cabinetsTableAdapter.DeleteQuery(System.Convert.ToInt32(main.bunifuDataGridView5.SelectedCells[0].Value));
                    main.cabinetsTableAdapter.Fill(main.cycle_commissionDataSet.Cabinets);
                    main.teacherTableAdapter.Fill(main.cycle_commissionDataSet.Teacher);
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton33_Click(object sender, EventArgs e)
        {
            try
            {
                Cycle_selection main;
                main = (Cycle_selection)this.FindForm();
                main.cabinetsTableAdapter.Update(main.cycle_commissionDataSet.Cabinets);
                main.cabinetsTableAdapter.Fill(main.cycle_commissionDataSet.Cabinets);
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton36_Click(object sender, EventArgs e)
        {
            try
            {
                Add_cabinets form1 = new Add_cabinets();
                Cycle_selection main;
                main = (Cycle_selection)this.FindForm();
                form1.Owner = main;
                form1.ShowDialog();
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
                Add_teachers form1 = new Add_teachers();
                Cycle_selection main;
                main = (Cycle_selection)this.FindForm();
                form1.Owner = main;
                form1.ShowDialog();
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
                if (MessageBox.Show("Вы уверены что хотите удалить выбранную запись?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cycle_selection main;
                    main = (Cycle_selection)this.FindForm();

                    main.teacherTableAdapter.DeleteQuery(System.Convert.ToInt32(main.bunifuDataGridView6.SelectedCells[0].Value));
                    main.teacherTableAdapter.Fill(main.cycle_commissionDataSet.Teacher);
                    main.responsibleTableAdapter.Fill(main.cycle_commissionDataSet.Responsible);
                    main.event_TableAdapter.Fill(main.cycle_commissionDataSet.Event_);
                    main.cycleTableAdapter.Fill(main.cycle_commissionDataSet.Cycle);
                }
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
                if (MessageBox.Show("Вы уверены что хотите обновить выбранную запись?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cycle_selection main;
                    main = (Cycle_selection)this.FindForm();
                    this.Focus();

                    if ((main.bunifuDataGridView6.SelectedCells[5].Value == DBNull.Value))
                    {
                        main.teacherTableAdapter.UpdateQuery1(System.Convert.ToString(main.bunifuDataGridView6.SelectedCells[1].Value),
           System.Convert.ToString(main.bunifuDataGridView6.SelectedCells[2].Value),
                    System.Convert.ToInt32(main.bunifuDataGridView6.SelectedCells[0].Value));
                        main.teacherTableAdapter.Fill(main.cycle_commissionDataSet.Teacher);
                    }
                    if ((main.bunifuDataGridView6.SelectedCells[3].Value != DBNull.Value))
                    {
                        main.teacherTableAdapter.UpdateQuery(System.Convert.ToString(main.bunifuDataGridView6.SelectedCells[1].Value),
               System.Convert.ToString(main.bunifuDataGridView6.SelectedCells[2].Value),
                        System.Convert.ToInt32(main.bunifuDataGridView6.SelectedCells[5].Value),
                      System.Convert.ToInt32(main.bunifuDataGridView6.SelectedCells[0].Value));
                        main.teacherTableAdapter.Fill(main.cycle_commissionDataSet.Teacher);
                    }
                }
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
                Cycle_selection main;
                main = (Cycle_selection)this.FindForm();
                main.teacherTableAdapter.Fill(main.cycle_commissionDataSet.Teacher);
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
                Add_category form1 = new Add_category();
                Cycle_selection main;
                main = (Cycle_selection)this.FindForm();
                form1.Owner = main;
                form1.ShowDialog();
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton20_Click_1(object sender, EventArgs e)
        {
            try
            {
                Add_additional_event form1 = new Add_additional_event();
                Cycle_selection main;
                main = (Cycle_selection)this.FindForm();
                form1.Owner = main;
                form1.ShowDialog();
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
                if (MessageBox.Show("Вы уверены что хотите обновить выбранную запись?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cycle_selection main;
                    main = (Cycle_selection)this.FindForm();
                    this.Focus();
                    main.categoryTableAdapter.Adapter.Update(main.cycle_commissionDataSet.Category);
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton8_Click_1(object sender, EventArgs e)
        {
            try
            {
                Cycle_selection main;
                main = (Cycle_selection)this.FindForm();
                main.categoryTableAdapter.Update(main.cycle_commissionDataSet.Category);
                main.categoryTableAdapter.Fill(main.cycle_commissionDataSet.Category);
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
                if (MessageBox.Show("Вы уверены что хотите удалить выбранную запись?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cycle_selection main;
                    main = (Cycle_selection)this.FindForm();
                    main.categoryTableAdapter.DeleteQuery(System.Convert.ToInt32(main.bunifuDataGridView7.SelectedCells[0].Value));
                    main.categoryTableAdapter.Fill(main.cycle_commissionDataSet.Category);
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton18_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены что хотите удалить выбранную запись?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cycle_selection main;
                    main = (Cycle_selection)this.FindForm();
                    main.additional_eventTableAdapter.DeleteQuery(System.Convert.ToInt32(main.bunifuDataGridView8.SelectedCells[0].Value));
                    main.additional_eventTableAdapter.Fill(main.cycle_commissionDataSet.Additional_event);
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton19_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены что хотите обновить выбранную запись?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cycle_selection main;
                    main = (Cycle_selection)this.FindForm();
                    this.Focus();
                    main.additional_eventTableAdapter.Adapter.Update(main.cycle_commissionDataSet.Additional_event);
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton17_Click(object sender, EventArgs e)
        {
            try
            {
                Cycle_selection main;
                main = (Cycle_selection)this.FindForm();
                main.additional_eventTableAdapter.Update(main.cycle_commissionDataSet.Additional_event);
                main.additional_eventTableAdapter.Fill(main.cycle_commissionDataSet.Additional_event);
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton40_Click(object sender, EventArgs e)
        {
            try
            {
                Add_cycle form1 = new Add_cycle();
                Cycle_selection main;
                main = (Cycle_selection)this.FindForm();
                form1.Owner = main;
                form1.ShowDialog();
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton39_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены что хотите обновить выбранную запись?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cycle_selection main;
                    main = (Cycle_selection)this.FindForm();
                    this.Focus();
                    main.cycleTableAdapter.UpdateQuery(System.Convert.ToString(main.bunifuDataGridView11.SelectedCells[1].Value),
              System.Convert.ToInt32(main.bunifuDataGridView11.SelectedCells[2].Value),
                       System.Convert.ToInt32(main.bunifuDataGridView11.SelectedCells[0].Value));
                    main.teacherTableAdapter.Fill(main.cycle_commissionDataSet.Teacher);
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton38_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены что хотите удалить выбранную запись?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cycle_selection main;
                    main = (Cycle_selection)this.FindForm();
                    main.cycleTableAdapter.DeleteQuery(System.Convert.ToInt32(main.bunifuDataGridView11.SelectedCells[0].Value));
                    main.cycleTableAdapter.Fill(main.cycle_commissionDataSet.Cycle);
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton37_Click(object sender, EventArgs e)
        {
            try
            {
                Cycle_selection main;
                main = (Cycle_selection)this.FindForm();
                main.cycleTableAdapter.Fill(main.cycle_commissionDataSet.Cycle);
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
                Add_event form1 = new Add_event();
                Cycle_selection main;
                main = (Cycle_selection)this.FindForm();
                form1.Owner = main;
                form1.ShowDialog();
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
                Cycle_selection main;
                main = (Cycle_selection)this.FindForm();
                main.event_TableAdapter.Fill(main.cycle_commissionDataSet.Event_);
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
                if (MessageBox.Show("Вы уверены что хотите удалить выбранную запись?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cycle_selection main;
                    main = (Cycle_selection)this.FindForm();
                    main.event_TableAdapter.DeleteQuery(System.Convert.ToInt32(main.bunifuDataGridView9.SelectedCells[0].Value));
                    main.event_TableAdapter.Fill(main.cycle_commissionDataSet.Event_);
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bunifuFlatButton41_Click(object sender, EventArgs e)
        {
            try
            {
                Inquries_event form1 = new Inquries_event();
                Cycle_selection main;
                main = (Cycle_selection)this.FindForm();
                form1.Owner = main;
                form1.Show();
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton45_Click(object sender, EventArgs e)
        {
            try
            {
                Add_responsible form1 = new Add_responsible();
                Cycle_selection main;
                main = (Cycle_selection)this.FindForm();
                form1.Owner = main;
                form1.Show();
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton44_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены что хотите обновить выбранную запись?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cycle_selection main;
                    main = (Cycle_selection)this.FindForm();
                    this.Focus();
                    main.responsibleTableAdapter.UpdateQuery(System.Convert.ToInt32(main.bunifuDataGridView10.SelectedCells[2].Value), System.Convert.ToInt32(main.bunifuDataGridView9.SelectedCells[0].Value), System.Convert.ToInt32(main.bunifuDataGridView10.SelectedCells[0].Value));
                }
            }

            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton43_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены что хотите удалить выбранную запись?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cycle_selection main;
                    main = (Cycle_selection)this.FindForm();
                    main.responsibleTableAdapter.DeleteQuery(System.Convert.ToInt32(main.bunifuDataGridView10.SelectedCells[0].Value));
                    main.responsibleTableAdapter.Fill(main.cycle_commissionDataSet.Responsible);
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton42_Click(object sender, EventArgs e)
        {
            try
            {
                Cycle_selection main;
                main = (Cycle_selection)this.FindForm();
                main.responsibleTableAdapter.Fill(main.cycle_commissionDataSet.Responsible);
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton46_Click(object sender, EventArgs e)
        {
            try
            {
                Reports form1 = new Reports();
                Cycle_selection main;
                main = (Cycle_selection)this.FindForm();
                form1.Owner = main;
                form1.Show();
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}