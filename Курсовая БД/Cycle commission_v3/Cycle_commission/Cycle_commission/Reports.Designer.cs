namespace Cycle_commission
{
    partial class Reports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.CycleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Cycle_commissionDataSet = new Cycle_commission.Cycle_commissionDataSet();
            this.goalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Event_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ResponsibleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yearsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cycle_commissionDataSet1 = new Cycle_commission.Cycle_commissionDataSet();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeofeventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cycle_commissionDataSet2 = new Cycle_commission.Cycle_commissionDataSet();
            this.CycleTableAdapter = new Cycle_commission.Cycle_commissionDataSetTableAdapters.CycleTableAdapter();
            this.yearsTableAdapter = new Cycle_commission.Cycle_commissionDataSetTableAdapters.YearsTableAdapter();
            this.cycleTableAdapter1 = new Cycle_commission.Cycle_commissionDataSetTableAdapters.CycleTableAdapter();
            this.goalsTableAdapter = new Cycle_commission.Cycle_commissionDataSetTableAdapters.goalsTableAdapter();
            this.tableAdapterManager = new Cycle_commission.Cycle_commissionDataSetTableAdapters.TableAdapterManager();
            this.DataTable1TableAdapter = new Cycle_commission.Cycle_commissionDataSetTableAdapters.DataTable1TableAdapter();
            this.DataTable2TableAdapter = new Cycle_commission.Cycle_commissionDataSetTableAdapters.DataTable2TableAdapter();
            this.DataTable3TableAdapter = new Cycle_commission.Cycle_commissionDataSetTableAdapters.DataTable3TableAdapter();
            this.DataTable4TableAdapter = new Cycle_commission.Cycle_commissionDataSetTableAdapters.DataTable4TableAdapter();
            this.type_of_eventTableAdapter = new Cycle_commission.Cycle_commissionDataSetTableAdapters.type_of_eventTableAdapter();
            this.teacherTableAdapter = new Cycle_commission.Cycle_commissionDataSetTableAdapters.TeacherTableAdapter();
            this.Event_TableAdapter = new Cycle_commission.Cycle_commissionDataSetTableAdapters.Event_TableAdapter();
            this.ResponsibleTableAdapter = new Cycle_commission.Cycle_commissionDataSetTableAdapters.ResponsibleTableAdapter();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.bunifuTextBox2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CycleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cycle_commissionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Event_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResponsibleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cycle_commissionDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofeventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cycle_commissionDataSet2)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CycleBindingSource
            // 
            this.CycleBindingSource.DataMember = "Cycle";
            this.CycleBindingSource.DataSource = this.Cycle_commissionDataSet;
            // 
            // Cycle_commissionDataSet
            // 
            this.Cycle_commissionDataSet.DataSetName = "Cycle_commissionDataSet";
            this.Cycle_commissionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // goalsBindingSource
            // 
            this.goalsBindingSource.DataMember = "goals";
            this.goalsBindingSource.DataSource = this.Cycle_commissionDataSet;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.Cycle_commissionDataSet;
            // 
            // DataTable2BindingSource
            // 
            this.DataTable2BindingSource.DataMember = "DataTable2";
            this.DataTable2BindingSource.DataSource = this.Cycle_commissionDataSet;
            // 
            // DataTable3BindingSource
            // 
            this.DataTable3BindingSource.DataMember = "DataTable3";
            this.DataTable3BindingSource.DataSource = this.Cycle_commissionDataSet;
            // 
            // Event_BindingSource
            // 
            this.Event_BindingSource.DataMember = "Event_";
            this.Event_BindingSource.DataSource = this.Cycle_commissionDataSet;
            // 
            // ResponsibleBindingSource
            // 
            this.ResponsibleBindingSource.DataMember = "Responsible";
            this.ResponsibleBindingSource.DataSource = this.Cycle_commissionDataSet;
            // 
            // DataTable4BindingSource
            // 
            this.DataTable4BindingSource.DataMember = "DataTable4";
            this.DataTable4BindingSource.DataSource = this.Cycle_commissionDataSet;
            // 
            // DataTable5BindingSource
            // 
            this.DataTable5BindingSource.DataMember = "DataTable5";
            this.DataTable5BindingSource.DataSource = this.Cycle_commissionDataSet;
            // 
            // yearsBindingSource
            // 
            this.yearsBindingSource.DataMember = "Years";
            this.yearsBindingSource.DataSource = this.Cycle_commissionDataSet;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Cycle";
            this.bindingSource1.DataSource = this.cycle_commissionDataSet1;
            // 
            // cycle_commissionDataSet1
            // 
            this.cycle_commissionDataSet1.DataSetName = "Cycle_commissionDataSet";
            this.cycle_commissionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "Teacher";
            this.teacherBindingSource.DataSource = this.Cycle_commissionDataSet;
            // 
            // typeofeventBindingSource
            // 
            this.typeofeventBindingSource.DataMember = "type_of_event";
            this.typeofeventBindingSource.DataSource = this.cycle_commissionDataSet2;
            // 
            // cycle_commissionDataSet2
            // 
            this.cycle_commissionDataSet2.DataSetName = "Cycle_commissionDataSet";
            this.cycle_commissionDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CycleTableAdapter
            // 
            this.CycleTableAdapter.ClearBeforeFill = true;
            // 
            // yearsTableAdapter
            // 
            this.yearsTableAdapter.ClearBeforeFill = true;
            // 
            // cycleTableAdapter1
            // 
            this.cycleTableAdapter1.ClearBeforeFill = true;
            // 
            // goalsTableAdapter
            // 
            this.goalsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Additional_eventTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CabinetsTableAdapter = null;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.DisciplineTableAdapter = null;
            this.tableAdapterManager.goalsTableAdapter = this.goalsTableAdapter;
            this.tableAdapterManager.type_of_eventTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Cycle_commission.Cycle_commissionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.YearsTableAdapter = this.yearsTableAdapter;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // DataTable2TableAdapter
            // 
            this.DataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // DataTable3TableAdapter
            // 
            this.DataTable3TableAdapter.ClearBeforeFill = true;
            // 
            // DataTable4TableAdapter
            // 
            this.DataTable4TableAdapter.ClearBeforeFill = true;
            // 
            // type_of_eventTableAdapter
            // 
            this.type_of_eventTableAdapter.ClearBeforeFill = true;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // Event_TableAdapter
            // 
            this.Event_TableAdapter.ClearBeforeFill = true;
            // 
            // ResponsibleTableAdapter
            // 
            this.ResponsibleTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.bunifuTextBox1);
            this.tabPage1.Controls.Add(this.bunifuTextBox2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.bunifuFlatButton2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1212, 505);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Брак";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CycleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cycle_commission.Main_page.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(8, 6);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1201, 314);
            this.reportViewer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.label2.Location = new System.Drawing.Point(8, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 88;
            this.label2.Text = "Средство";
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = false;
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 1;
            this.bunifuFlatButton2.ButtonText = "Просмотр";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 5;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = false;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = false;
            this.bunifuFlatButton2.IconZoom = 65D;
            this.bunifuFlatButton2.IsTab = true;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(5, 471);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(1199, 31);
            this.bunifuFlatButton2.TabIndex = 90;
            this.bunifuFlatButton2.Tag = "0";
            this.bunifuFlatButton2.Text = "Просмотр";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(8, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 91;
            this.label1.Text = "Поверитель";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1220, 531);
            this.tabControl1.TabIndex = 0;
            // 
            // bunifuTextBox2
            // 
            this.bunifuTextBox2.AcceptsReturn = false;
            this.bunifuTextBox2.AcceptsTab = false;
            this.bunifuTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox2.BackgroundImage")));
            this.bunifuTextBox2.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.bunifuTextBox2.BorderColorDisabled = System.Drawing.Color.WhiteSmoke;
            this.bunifuTextBox2.BorderColorHover = System.Drawing.Color.Black;
            this.bunifuTextBox2.BorderColorIdle = System.Drawing.SystemColors.ControlDark;
            this.bunifuTextBox2.BorderRadius = 1;
            this.bunifuTextBox2.BorderThickness = 1;
            this.bunifuTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox2.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuTextBox2.DefaultText = "";
            this.bunifuTextBox2.FillColor = System.Drawing.Color.Gainsboro;
            this.bunifuTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.bunifuTextBox2.HideSelection = true;
            this.bunifuTextBox2.IconLeft = global::Cycle_commission.Properties.Resources.icons8_Linux_Server_32;
            this.bunifuTextBox2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox2.IconPadding = 10;
            this.bunifuTextBox2.IconRight = null;
            this.bunifuTextBox2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox2.Location = new System.Drawing.Point(12, 347);
            this.bunifuTextBox2.MaxLength = 32767;
            this.bunifuTextBox2.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBox2.Modified = false;
            this.bunifuTextBox2.Name = "bunifuTextBox2";
            this.bunifuTextBox2.PasswordChar = '\0';
            this.bunifuTextBox2.ReadOnly = false;
            this.bunifuTextBox2.SelectedText = "";
            this.bunifuTextBox2.SelectionLength = 0;
            this.bunifuTextBox2.SelectionStart = 0;
            this.bunifuTextBox2.ShortcutsEnabled = true;
            this.bunifuTextBox2.Size = new System.Drawing.Size(1192, 46);
            this.bunifuTextBox2.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox2.TabIndex = 92;
            this.bunifuTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox2.TextMarginLeft = 5;
            this.bunifuTextBox2.TextPlaceholder = "Средство...";
            this.bunifuTextBox2.UseSystemPasswordChar = false;
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.AcceptsReturn = false;
            this.bunifuTextBox1.AcceptsTab = false;
            this.bunifuTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.BackgroundImage")));
            this.bunifuTextBox1.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.bunifuTextBox1.BorderColorDisabled = System.Drawing.Color.WhiteSmoke;
            this.bunifuTextBox1.BorderColorHover = System.Drawing.Color.Black;
            this.bunifuTextBox1.BorderColorIdle = System.Drawing.SystemColors.ControlDark;
            this.bunifuTextBox1.BorderRadius = 1;
            this.bunifuTextBox1.BorderThickness = 1;
            this.bunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox1.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuTextBox1.DefaultText = "";
            this.bunifuTextBox1.FillColor = System.Drawing.Color.Gainsboro;
            this.bunifuTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.bunifuTextBox1.HideSelection = true;
            this.bunifuTextBox1.IconLeft = global::Cycle_commission.Properties.Resources.icons8_Linux_Server_32;
            this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox1.IconPadding = 10;
            this.bunifuTextBox1.IconRight = null;
            this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox1.Location = new System.Drawing.Point(12, 419);
            this.bunifuTextBox1.MaxLength = 32767;
            this.bunifuTextBox1.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBox1.Modified = false;
            this.bunifuTextBox1.Name = "bunifuTextBox1";
            this.bunifuTextBox1.PasswordChar = '\0';
            this.bunifuTextBox1.ReadOnly = false;
            this.bunifuTextBox1.SelectedText = "";
            this.bunifuTextBox1.SelectionLength = 0;
            this.bunifuTextBox1.SelectionStart = 0;
            this.bunifuTextBox1.ShortcutsEnabled = true;
            this.bunifuTextBox1.Size = new System.Drawing.Size(1192, 46);
            this.bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox1.TabIndex = 93;
            this.bunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox1.TextMarginLeft = 5;
            this.bunifuTextBox1.TextPlaceholder = "Поверитель...";
            this.bunifuTextBox1.UseSystemPasswordChar = false;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1220, 531);
            this.Controls.Add(this.tabControl1);
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёты";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CycleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cycle_commissionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Event_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResponsibleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cycle_commissionDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofeventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cycle_commissionDataSet2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource CycleBindingSource;
        private Cycle_commissionDataSet Cycle_commissionDataSet;
        private Cycle_commissionDataSetTableAdapters.CycleTableAdapter CycleTableAdapter;
        private System.Windows.Forms.BindingSource yearsBindingSource;
        private Cycle_commissionDataSetTableAdapters.YearsTableAdapter yearsTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Cycle_commissionDataSet cycle_commissionDataSet1;
        private Cycle_commissionDataSetTableAdapters.CycleTableAdapter cycleTableAdapter1;
        private System.Windows.Forms.BindingSource goalsBindingSource;
        private Cycle_commissionDataSetTableAdapters.goalsTableAdapter goalsTableAdapter;
        private Cycle_commissionDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private Cycle_commissionDataSetTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.BindingSource DataTable2BindingSource;
        private Cycle_commissionDataSetTableAdapters.DataTable2TableAdapter DataTable2TableAdapter;
        private System.Windows.Forms.BindingSource DataTable3BindingSource;
        private Cycle_commissionDataSetTableAdapters.DataTable3TableAdapter DataTable3TableAdapter;
        private System.Windows.Forms.BindingSource DataTable4BindingSource;
        private Cycle_commissionDataSetTableAdapters.DataTable4TableAdapter DataTable4TableAdapter;
        private System.Windows.Forms.BindingSource DataTable5BindingSource;
        private Cycle_commissionDataSet cycle_commissionDataSet2;
        private System.Windows.Forms.BindingSource typeofeventBindingSource;
        private Cycle_commissionDataSetTableAdapters.type_of_eventTableAdapter type_of_eventTableAdapter;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private Cycle_commissionDataSetTableAdapters.TeacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.BindingSource Event_BindingSource;
        private System.Windows.Forms.BindingSource ResponsibleBindingSource;
        private Cycle_commissionDataSetTableAdapters.Event_TableAdapter Event_TableAdapter;
        private Cycle_commissionDataSetTableAdapters.ResponsibleTableAdapter ResponsibleTableAdapter;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        public System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabControl tabControl1;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox bunifuTextBox1;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox bunifuTextBox2;
    }
}