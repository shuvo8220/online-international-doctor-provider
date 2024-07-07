namespace KnockDoc
{
    partial class hospitalDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hospitalDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textHospitalName = new System.Windows.Forms.TextBox();
            this.textDoctorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textqualification = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textSpecialization = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textLocation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.HospitalList = new System.Windows.Forms.DataGridView();
            this.hospitaltblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knock_docDataSet3 = new KnockDoc.knock_docDataSet3();
            this.knock_docDataSet2 = new KnockDoc.knock_docDataSet2();
            this.knockdocDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitaltblTableAdapter = new KnockDoc.knock_docDataSet3TableAdapters.HospitaltblTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitaltblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knock_docDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knock_docDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knockdocDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-61, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 50);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(974, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 34);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1040, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doctor Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hospital Name";
            // 
            // textHospitalName
            // 
            this.textHospitalName.Location = new System.Drawing.Point(180, 6);
            this.textHospitalName.Name = "textHospitalName";
            this.textHospitalName.Size = new System.Drawing.Size(241, 27);
            this.textHospitalName.TabIndex = 6;
            // 
            // textDoctorName
            // 
            this.textDoctorName.Location = new System.Drawing.Point(180, 55);
            this.textDoctorName.Name = "textDoctorName";
            this.textDoctorName.Size = new System.Drawing.Size(241, 27);
            this.textDoctorName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Doctor Name";
            // 
            // textqualification
            // 
            this.textqualification.Location = new System.Drawing.Point(658, 3);
            this.textqualification.Name = "textqualification";
            this.textqualification.Size = new System.Drawing.Size(241, 27);
            this.textqualification.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(491, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Qualification";
            // 
            // textSpecialization
            // 
            this.textSpecialization.Location = new System.Drawing.Point(658, 58);
            this.textSpecialization.Name = "textSpecialization";
            this.textSpecialization.Size = new System.Drawing.Size(241, 27);
            this.textSpecialization.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Specialization";
            // 
            // textLocation
            // 
            this.textLocation.Location = new System.Drawing.Point(180, 112);
            this.textLocation.Name = "textLocation";
            this.textLocation.Size = new System.Drawing.Size(241, 27);
            this.textLocation.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Location";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textLocation);
            this.panel2.Controls.Add(this.textHospitalName);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textSpecialization);
            this.panel2.Controls.Add(this.textDoctorName);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textqualification);
            this.panel2.Location = new System.Drawing.Point(67, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(909, 217);
            this.panel2.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(541, 161);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 40);
            this.button4.TabIndex = 19;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(213, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 40);
            this.button2.TabIndex = 18;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SlateBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(382, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 40);
            this.button3.TabIndex = 17;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // HospitalList
            // 
            this.HospitalList.AllowUserToDeleteRows = false;
            this.HospitalList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HospitalList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.HospitalList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.HospitalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HospitalList.Location = new System.Drawing.Point(67, 321);
            this.HospitalList.Name = "HospitalList";
            this.HospitalList.RowHeadersWidth = 51;
            this.HospitalList.RowTemplate.Height = 24;
            this.HospitalList.Size = new System.Drawing.Size(909, 283);
            this.HospitalList.TabIndex = 18;
            // 
            // hospitaltblBindingSource
            // 
            this.hospitaltblBindingSource.DataMember = "Hospitaltbl";
            this.hospitaltblBindingSource.DataSource = this.knock_docDataSet3;
            // 
            // knock_docDataSet3
            // 
            this.knock_docDataSet3.DataSetName = "knock_docDataSet3";
            this.knock_docDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // knock_docDataSet2
            // 
            this.knock_docDataSet2.DataSetName = "knock_docDataSet2";
            this.knock_docDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // knockdocDataSet2BindingSource
            // 
            this.knockdocDataSet2BindingSource.DataSource = this.knock_docDataSet2;
            this.knockdocDataSet2BindingSource.Position = 0;
            // 
            // hospitaltblTableAdapter
            // 
            this.hospitaltblTableAdapter.ClearBeforeFill = true;
            // 
            // hospitalDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1046, 616);
            this.Controls.Add(this.HospitalList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "hospitalDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hospitalDashboard";
            this.Load += new System.EventHandler(this.hospitalDashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitaltblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knock_docDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knock_docDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knockdocDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textHospitalName;
        private System.Windows.Forms.TextBox textDoctorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textqualification;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textSpecialization;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textLocation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView HospitalList;
        private knock_docDataSet2 knock_docDataSet2;
        private System.Windows.Forms.BindingSource knockdocDataSet2BindingSource;
        private knock_docDataSet3 knock_docDataSet3;
        private System.Windows.Forms.BindingSource hospitaltblBindingSource;
        private knock_docDataSet3TableAdapters.HospitaltblTableAdapter hospitaltblTableAdapter;
    }
}