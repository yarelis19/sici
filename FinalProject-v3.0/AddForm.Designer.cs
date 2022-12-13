namespace FinalProject
{
    partial class AddForm
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
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.txtBoxArea = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.checkExtraFees = new System.Windows.Forms.CheckBox();
            this.btnSaveAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.txtBoxDisc = new System.Windows.Forms.TextBox();
            this.numericDay = new System.Windows.Forms.NumericUpDown();
            this.labelRecords = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.comboBoxDescr = new System.Windows.Forms.ComboBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.txtBoxNotes = new System.Windows.Forms.TextBox();
            this.txtBoxYear = new System.Windows.Forms.TextBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.textBoxExtra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxMarerials = new System.Windows.Forms.TextBox();
            this.checkBoxDisc = new System.Windows.Forms.CheckBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(101, 90);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(197, 23);
            this.txtBoxName.TabIndex = 0;
            this.txtBoxName.TextChanged += new System.EventHandler(this.txtBoxName_TextChanged);
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(101, 124);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(197, 23);
            this.txtBoxID.TabIndex = 1;
            this.txtBoxID.TextChanged += new System.EventHandler(this.txtBoxID_TextChanged);
            this.txtBoxID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxID_Key);
            // 
            // txtBoxArea
            // 
            this.txtBoxArea.Location = new System.Drawing.Point(488, 85);
            this.txtBoxArea.Name = "txtBoxArea";
            this.txtBoxArea.Size = new System.Drawing.Size(100, 23);
            this.txtBoxArea.TabIndex = 3;
            this.txtBoxArea.TextChanged += new System.EventHandler(this.txtBoxArea_TextChanged);
            this.txtBoxArea.Enter += new System.EventHandler(this.area_enter);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(22, 90);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(64, 25);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelID.Location = new System.Drawing.Point(22, 124);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(37, 25);
            this.labelID.TabIndex = 5;
            this.labelID.Text = " ID";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCost.Location = new System.Drawing.Point(337, 119);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(145, 25);
            this.labelCost.TabIndex = 6;
            this.labelCost.Text = "Catalog Price $";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelArea.Location = new System.Drawing.Point(337, 80);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(111, 25);
            this.labelArea.TabIndex = 7;
            this.labelArea.Text = "Area (sq ft)";
            // 
            // checkExtraFees
            // 
            this.checkExtraFees.AutoSize = true;
            this.checkExtraFees.Location = new System.Drawing.Point(387, 203);
            this.checkExtraFees.Name = "checkExtraFees";
            this.checkExtraFees.Size = new System.Drawing.Size(84, 19);
            this.checkExtraFees.TabIndex = 8;
            this.checkExtraFees.Text = "Extra Fees: ";
            this.checkExtraFees.UseVisualStyleBackColor = true;
            // 
            // btnSaveAdd
            // 
            this.btnSaveAdd.Location = new System.Drawing.Point(131, 373);
            this.btnSaveAdd.Name = "btnSaveAdd";
            this.btnSaveAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAdd.TabIndex = 10;
            this.btnSaveAdd.Text = "Save";
            this.btnSaveAdd.UseVisualStyleBackColor = true;
            this.btnSaveAdd.Click += new System.EventHandler(this.btnSaveAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(291, 373);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(444, 373);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 12;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // txtBoxDisc
            // 
            this.txtBoxDisc.Location = new System.Drawing.Point(488, 161);
            this.txtBoxDisc.Name = "txtBoxDisc";
            this.txtBoxDisc.Size = new System.Drawing.Size(100, 23);
            this.txtBoxDisc.TabIndex = 15;
            this.txtBoxDisc.TextChanged += new System.EventHandler(this.txtBoxDays_TextChanged);
            // 
            // numericDay
            // 
            this.numericDay.Location = new System.Drawing.Point(115, 211);
            this.numericDay.Name = "numericDay";
            this.numericDay.Size = new System.Drawing.Size(43, 23);
            this.numericDay.TabIndex = 17;
            this.numericDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericDay.ValueChanged += new System.EventHandler(this.numericDays_ValueChanged);
            // 
            // labelRecords
            // 
            this.labelRecords.AutoSize = true;
            this.labelRecords.BackColor = System.Drawing.Color.LightGray;
            this.labelRecords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRecords.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRecords.Location = new System.Drawing.Point(140, 23);
            this.labelRecords.Name = "labelRecords";
            this.labelRecords.Size = new System.Drawing.Size(151, 39);
            this.labelRecords.TabIndex = 18;
            this.labelRecords.Text = "New Order";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProject.Properties.Resources.Ok_icon;
            this.pictureBox1.Location = new System.Drawing.Point(444, 301);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FinalProject.Properties.Resources.Actions_edit_clear_locationbar_ltr_icon;
            this.pictureBox2.Location = new System.Drawing.Point(291, 301);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FinalProject.Properties.Resources.floppy_icon;
            this.pictureBox3.Location = new System.Drawing.Point(134, 301);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(72, 66);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::FinalProject.Properties.Resources.Order_history_icon;
            this.pictureBox4.Location = new System.Drawing.Point(56, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 72);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDate.Location = new System.Drawing.Point(22, 212);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(53, 25);
            this.labelDate.TabIndex = 24;
            this.labelDate.Text = "Date";
            // 
            // comboBoxDescr
            // 
            this.comboBoxDescr.FormattingEnabled = true;
            this.comboBoxDescr.Items.AddRange(new object[] {
            "Interior",
            "Exterior"});
            this.comboBoxDescr.Location = new System.Drawing.Point(177, 255);
            this.comboBoxDescr.Name = "comboBoxDescr";
            this.comboBoxDescr.Size = new System.Drawing.Size(121, 23);
            this.comboBoxDescr.TabIndex = 27;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(14, 255);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(151, 25);
            this.labelDescription.TabIndex = 28;
            this.labelDescription.Text = "Job Description";
            // 
            // txtBoxNotes
            // 
            this.txtBoxNotes.Location = new System.Drawing.Point(488, 232);
            this.txtBoxNotes.Multiline = true;
            this.txtBoxNotes.Name = "txtBoxNotes";
            this.txtBoxNotes.PlaceholderText = "...";
            this.txtBoxNotes.Size = new System.Drawing.Size(100, 48);
            this.txtBoxNotes.TabIndex = 30;
            // 
            // txtBoxYear
            // 
            this.txtBoxYear.Location = new System.Drawing.Point(228, 211);
            this.txtBoxYear.Name = "txtBoxYear";
            this.txtBoxYear.PlaceholderText = "YYYY";
            this.txtBoxYear.Size = new System.Drawing.Size(63, 23);
            this.txtBoxYear.TabIndex = 31;
            this.txtBoxYear.TextChanged += new System.EventHandler(this.txtBoxYear_TextChanged);
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "Sepember",
            "October",
            "November",
            "December"});
            this.comboBoxMonth.Location = new System.Drawing.Point(164, 211);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(58, 23);
            this.comboBoxMonth.TabIndex = 32;
            this.comboBoxMonth.Text = "Select";
            // 
            // textBoxExtra
            // 
            this.textBoxExtra.Location = new System.Drawing.Point(488, 199);
            this.textBoxExtra.Name = "textBoxExtra";
            this.textBoxExtra.Size = new System.Drawing.Size(100, 23);
            this.textBoxExtra.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Notes";
            // 
            // txtBoxMarerials
            // 
            this.txtBoxMarerials.Location = new System.Drawing.Point(488, 124);
            this.txtBoxMarerials.Name = "txtBoxMarerials";
            this.txtBoxMarerials.Size = new System.Drawing.Size(100, 23);
            this.txtBoxMarerials.TabIndex = 36;
            // 
            // checkBoxDisc
            // 
            this.checkBoxDisc.Location = new System.Drawing.Point(359, 147);
            this.checkBoxDisc.Name = "checkBoxDisc";
            this.checkBoxDisc.Size = new System.Drawing.Size(123, 52);
            this.checkBoxDisc.TabIndex = 37;
            this.checkBoxDisc.Text = "Discount ( in $)";
            this.checkBoxDisc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxDisc.UseVisualStyleBackColor = true;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.Location = new System.Drawing.Point(22, 161);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(59, 25);
            this.labelEmail.TabIndex = 38;
            this.labelEmail.Text = "Email";
            this.labelEmail.Click += new System.EventHandler(this.labelEmail_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(101, 166);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(197, 23);
            this.textBoxEmail.TabIndex = 40;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.TextBoxEmail_TextChanged);
            this.textBoxEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.emailVal);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "(Press Enter)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "(Press Enter)";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 416);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.checkBoxDisc);
            this.Controls.Add(this.txtBoxMarerials);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxExtra);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.txtBoxYear);
            this.Controls.Add(this.txtBoxNotes);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.comboBoxDescr);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelRecords);
            this.Controls.Add(this.numericDay);
            this.Controls.Add(this.txtBoxDisc);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSaveAdd);
            this.Controls.Add(this.checkExtraFees);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txtBoxArea);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.txtBoxName);
            this.Name = "AddForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBoxName;
        private TextBox txtBoxID;
        private TextBox txtBoxArea;
        private Label labelName;
        private Label labelID;
        private Label labelCost;
        private Label labelArea;
        private CheckBox checkExtraFees;
        private Button btnSaveAdd;
        private Button btnClear;
        private Button btnDone;
        private TextBox txtBoxDisc;
        private NumericUpDown numericDay;
        private Label labelRecords;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label labelDate;
        private ComboBox comboBoxDescr;
        private Label labelDescription;
        private TextBox txtBoxNotes;
        private TextBox txtBoxYear;
        private ComboBox comboBoxMonth;
        private TextBox textBoxExtra;
        private Label label1;
        private TextBox txtBoxMarerials;
        private CheckBox checkBoxDisc;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label label2;
        private Label label3;
    }
}