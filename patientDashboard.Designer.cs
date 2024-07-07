namespace KnockDoc
{
    partial class patientDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(patientDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbSpecialized = new System.Windows.Forms.ComboBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.docNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docSpecializedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospitalNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewProfile = new System.Windows.Forms.DataGridViewButtonColumn();
            this.doctorTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knock_docDataSet1 = new KnockDoc.knock_docDataSet1();
            this.knock_docDataSet = new KnockDoc.knock_docDataSet();
            this.knockdocDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTblTableAdapter = new KnockDoc.knock_docDataSet1TableAdapters.DoctorTblTableAdapter();
            this.HospitalList2 = new System.Windows.Forms.DataGridView();
            this.hospitaltblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knock_docDataSet4 = new KnockDoc.knock_docDataSet4();
            this.hospitaltblTableAdapter = new KnockDoc.knock_docDataSet4TableAdapters.HospitaltblTableAdapter();
            this.hnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dspecializationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profile = new System.Windows.Forms.DataGridViewButtonColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knock_docDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knock_docDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knockdocDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalList2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitaltblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knock_docDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 723);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Make Appointment";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.searchbox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.cmbSpecialized);
            this.panel2.Controls.Add(this.cmbCountry);
            this.panel2.Location = new System.Drawing.Point(166, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(930, 77);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MidnightBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(791, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 33);
            this.button3.TabIndex = 8;
            this.button3.Text = "REFRESH";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(549, 30);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(139, 30);
            this.searchbox.TabIndex = 7;
            this.searchbox.Text = "By Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Country";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Specialization";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(694, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "SEARCH";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbSpecialized
            // 
            this.cmbSpecialized.FormattingEnabled = true;
            this.cmbSpecialized.Items.AddRange(new object[] {
            "Nephrologist",
            "Cardiology",
            "Obstetrics & Gynecology",
            "Gastroenterology"});
            this.cmbSpecialized.Location = new System.Drawing.Point(146, 30);
            this.cmbSpecialized.Name = "cmbSpecialized";
            this.cmbSpecialized.Size = new System.Drawing.Size(145, 31);
            this.cmbSpecialized.TabIndex = 3;
            this.cmbSpecialized.Text = "Select";
            this.cmbSpecialized.SelectedIndexChanged += new System.EventHandler(this.cmbSpecialized_SelectedIndexChanged);
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Items.AddRange(new object[] {
            "India",
            "Singapore",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "Malaysia"});
            this.cmbCountry.Location = new System.Drawing.Point(383, 30);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(143, 31);
            this.cmbCountry.TabIndex = 0;
            this.cmbCountry.Text = "Select";
            this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1110, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(90, 24);
            this.toolStripMenuItem1.Text = "Logout";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripMenuItem2.Size = new System.Drawing.Size(176, 24);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click_1);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.docNameDataGridViewTextBoxColumn,
            this.docSpecializedDataGridViewTextBoxColumn,
            this.docCountryDataGridViewTextBoxColumn,
            this.hospitalNameDataGridViewTextBoxColumn,
            this.ViewProfile});
            this.dataGridView.DataSource = this.doctorTblBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(172, 115);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(924, 411);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick_1);
            // 
            // docNameDataGridViewTextBoxColumn
            // 
            this.docNameDataGridViewTextBoxColumn.DataPropertyName = "DocName";
            this.docNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.docNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.docNameDataGridViewTextBoxColumn.Name = "docNameDataGridViewTextBoxColumn";
            this.docNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // docSpecializedDataGridViewTextBoxColumn
            // 
            this.docSpecializedDataGridViewTextBoxColumn.DataPropertyName = "DocSpecialized";
            this.docSpecializedDataGridViewTextBoxColumn.HeaderText = "Specialization";
            this.docSpecializedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.docSpecializedDataGridViewTextBoxColumn.Name = "docSpecializedDataGridViewTextBoxColumn";
            this.docSpecializedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // docCountryDataGridViewTextBoxColumn
            // 
            this.docCountryDataGridViewTextBoxColumn.DataPropertyName = "DocCountry";
            this.docCountryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.docCountryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.docCountryDataGridViewTextBoxColumn.Name = "docCountryDataGridViewTextBoxColumn";
            this.docCountryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hospitalNameDataGridViewTextBoxColumn
            // 
            this.hospitalNameDataGridViewTextBoxColumn.DataPropertyName = "HospitalName";
            this.hospitalNameDataGridViewTextBoxColumn.HeaderText = "Hospital";
            this.hospitalNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hospitalNameDataGridViewTextBoxColumn.Name = "hospitalNameDataGridViewTextBoxColumn";
            this.hospitalNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ViewProfile
            // 
            this.ViewProfile.HeaderText = "View Profile";
            this.ViewProfile.MinimumWidth = 6;
            this.ViewProfile.Name = "ViewProfile";
            this.ViewProfile.ReadOnly = true;
            this.ViewProfile.Text = "View Profile";
            this.ViewProfile.UseColumnTextForButtonValue = true;
            // 
            // doctorTblBindingSource
            // 
            this.doctorTblBindingSource.DataMember = "DoctorTbl";
            this.doctorTblBindingSource.DataSource = this.knock_docDataSet1;
            // 
            // knock_docDataSet1
            // 
            this.knock_docDataSet1.DataSetName = "knock_docDataSet1";
            this.knock_docDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // knock_docDataSet
            // 
            this.knock_docDataSet.DataSetName = "knock_docDataSet";
            this.knock_docDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // knockdocDataSetBindingSource
            // 
            this.knockdocDataSetBindingSource.DataSource = this.knock_docDataSet;
            this.knockdocDataSetBindingSource.Position = 0;
            // 
            // doctorTblTableAdapter
            // 
            this.doctorTblTableAdapter.ClearBeforeFill = true;
            // 
            // HospitalList2
            // 
            this.HospitalList2.AllowUserToDeleteRows = false;
            this.HospitalList2.AutoGenerateColumns = false;
            this.HospitalList2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HospitalList2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HospitalList2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HospitalList2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hnameDataGridViewTextBoxColumn,
            this.dnameDataGridViewTextBoxColumn,
            this.dspecializationDataGridViewTextBoxColumn,
            this.dLocationDataGridViewTextBoxColumn,
            this.Profile});
            this.HospitalList2.DataSource = this.hospitaltblBindingSource;
            this.HospitalList2.Location = new System.Drawing.Point(180, 576);
            this.HospitalList2.Name = "HospitalList2";
            this.HospitalList2.RowHeadersWidth = 51;
            this.HospitalList2.RowTemplate.Height = 24;
            this.HospitalList2.Size = new System.Drawing.Size(916, 163);
            this.HospitalList2.TabIndex = 6;
            this.HospitalList2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HospitalList2_CellContentClick);
            // 
            // hospitaltblBindingSource
            // 
            this.hospitaltblBindingSource.DataMember = "Hospitaltbl";
            this.hospitaltblBindingSource.DataSource = this.knock_docDataSet4;
            // 
            // knock_docDataSet4
            // 
            this.knock_docDataSet4.DataSetName = "knock_docDataSet4";
            this.knock_docDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospitaltblTableAdapter
            // 
            this.hospitaltblTableAdapter.ClearBeforeFill = true;
            // 
            // hnameDataGridViewTextBoxColumn
            // 
            this.hnameDataGridViewTextBoxColumn.DataPropertyName = "H_name";
            this.hnameDataGridViewTextBoxColumn.HeaderText = "Hospital Name";
            this.hnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hnameDataGridViewTextBoxColumn.Name = "hnameDataGridViewTextBoxColumn";
            // 
            // dnameDataGridViewTextBoxColumn
            // 
            this.dnameDataGridViewTextBoxColumn.DataPropertyName = "D_name";
            this.dnameDataGridViewTextBoxColumn.HeaderText = "Doctor Name";
            this.dnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dnameDataGridViewTextBoxColumn.Name = "dnameDataGridViewTextBoxColumn";
            // 
            // dspecializationDataGridViewTextBoxColumn
            // 
            this.dspecializationDataGridViewTextBoxColumn.DataPropertyName = "D_specialization";
            this.dspecializationDataGridViewTextBoxColumn.HeaderText = "Specialization";
            this.dspecializationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dspecializationDataGridViewTextBoxColumn.Name = "dspecializationDataGridViewTextBoxColumn";
            // 
            // dLocationDataGridViewTextBoxColumn
            // 
            this.dLocationDataGridViewTextBoxColumn.DataPropertyName = "D_Location";
            this.dLocationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.dLocationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dLocationDataGridViewTextBoxColumn.Name = "dLocationDataGridViewTextBoxColumn";
            // 
            // Profile
            // 
            this.Profile.HeaderText = "Profile";
            this.Profile.MinimumWidth = 6;
            this.Profile.Name = "Profile";
            this.Profile.Text = "Profile";
            this.Profile.UseColumnTextForButtonValue = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hospital A",
            "Hospital B"});
            this.comboBox1.Location = new System.Drawing.Point(401, 534);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 31);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 542);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Filter by Hospital Name";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MidnightBlue;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(654, 532);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 33);
            this.button4.TabIndex = 9;
            this.button4.Text = "REFRESH";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // patientDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1110, 751);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.HospitalList2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "patientDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "patientDashboard";
            this.Load += new System.EventHandler(this.patientDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knock_docDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knock_docDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knockdocDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalList2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitaltblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knock_docDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.ComboBox cmbSpecialized;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.DataGridView dataGridView;
        private knock_docDataSet knock_docDataSet;
        private System.Windows.Forms.BindingSource knockdocDataSetBindingSource;
        private knock_docDataSet1 knock_docDataSet1;
        private System.Windows.Forms.BindingSource doctorTblBindingSource;
        private knock_docDataSet1TableAdapters.DoctorTblTableAdapter doctorTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn docNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docSpecializedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ViewProfile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.DataGridView HospitalList2;
        private knock_docDataSet4 knock_docDataSet4;
        private System.Windows.Forms.BindingSource hospitaltblBindingSource;
        private knock_docDataSet4TableAdapters.HospitaltblTableAdapter hospitaltblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dspecializationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Profile;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
    }
}