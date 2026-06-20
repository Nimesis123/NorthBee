namespace NorthBee.Forms
{
    partial class AddUpdateForm
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
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label statusIdLabel;
            System.Windows.Forms.Label genderIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TitleLab = new System.Windows.Forms.Label();
            this.TitlePic = new System.Windows.Forms.PictureBox();
            this.genderIdComboBox = new System.Windows.Forms.ComboBox();
            this.guestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northbeeDataSet = new NorthBee.northbeeDataSet();
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.statusIdComboBox = new System.Windows.Forms.ComboBox();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guestTableAdapter = new NorthBee.northbeeDataSetTableAdapters.GuestTableAdapter();
            this.tableAdapterManager = new NorthBee.northbeeDataSetTableAdapters.TableAdapterManager();
            this.genderTableAdapter = new NorthBee.northbeeDataSetTableAdapters.GenderTableAdapter();
            this.statusTableAdapter = new NorthBee.northbeeDataSetTableAdapters.StatusTableAdapter();
            fullNameLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            statusIdLabel = new System.Windows.Forms.Label();
            genderIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northbeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(35, 84);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(34, 13);
            fullNameLabel.TabIndex = 2;
            fullNameLabel.Text = "ФИО";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(35, 122);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(87, 13);
            birthdayLabel.TabIndex = 4;
            birthdayLabel.Text = "День рождения";
            // 
            // statusIdLabel
            // 
            statusIdLabel.AutoSize = true;
            statusIdLabel.Location = new System.Drawing.Point(35, 193);
            statusIdLabel.Name = "statusIdLabel";
            statusIdLabel.Size = new System.Drawing.Size(41, 13);
            statusIdLabel.TabIndex = 8;
            statusIdLabel.Text = "Статус";
            // 
            // genderIdLabel
            // 
            genderIdLabel.AutoSize = true;
            genderIdLabel.Location = new System.Drawing.Point(35, 156);
            genderIdLabel.Name = "genderIdLabel";
            genderIdLabel.Size = new System.Drawing.Size(27, 13);
            genderIdLabel.TabIndex = 10;
            genderIdLabel.Text = "Пол";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(genderIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.genderIdComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(fullNameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.fullNameTextBox);
            this.splitContainer1.Panel2.Controls.Add(birthdayLabel);
            this.splitContainer1.Panel2.Controls.Add(this.birthdayDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(statusIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.statusIdComboBox);
            this.splitContainer1.Size = new System.Drawing.Size(384, 411);
            this.splitContainer1.SplitterDistance = 70;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TitleLab);
            this.panel1.Controls.Add(this.TitlePic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 70);
            this.panel1.TabIndex = 0;
            // 
            // TitleLab
            // 
            this.TitleLab.AutoSize = true;
            this.TitleLab.Location = new System.Drawing.Point(66, 10);
            this.TitleLab.Name = "TitleLab";
            this.TitleLab.Size = new System.Drawing.Size(101, 13);
            this.TitleLab.TabIndex = 1;
            this.TitleLab.Text = "Добавление гостя";
            // 
            // TitlePic
            // 
            this.TitlePic.Image = global::NorthBee.Properties.Resources.bee;
            this.TitlePic.Location = new System.Drawing.Point(10, 10);
            this.TitlePic.Name = "TitlePic";
            this.TitlePic.Size = new System.Drawing.Size(50, 50);
            this.TitlePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TitlePic.TabIndex = 0;
            this.TitlePic.TabStop = false;
            // 
            // genderIdComboBox
            // 
            this.genderIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestBindingSource, "GenderId", true));
            this.genderIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.guestBindingSource, "GenderId", true));
            this.genderIdComboBox.DataSource = this.genderBindingSource;
            this.genderIdComboBox.DisplayMember = "GenderName";
            this.genderIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderIdComboBox.FormattingEnabled = true;
            this.genderIdComboBox.Location = new System.Drawing.Point(146, 153);
            this.genderIdComboBox.Name = "genderIdComboBox";
            this.genderIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.genderIdComboBox.TabIndex = 11;
            this.genderIdComboBox.ValueMember = "IdGender";
            // 
            // guestBindingSource
            // 
            this.guestBindingSource.DataMember = "Guest";
            this.guestBindingSource.DataSource = this.northbeeDataSet;
            // 
            // northbeeDataSet
            // 
            this.northbeeDataSet.DataSetName = "northbeeDataSet";
            this.northbeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataMember = "Gender";
            this.genderBindingSource.DataSource = this.northbeeDataSet;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(100)))), ((int)(((byte)(254)))));
            this.button1.Location = new System.Drawing.Point(60, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 43);
            this.button1.TabIndex = 10;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestBindingSource, "FullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(146, 81);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.fullNameTextBox.TabIndex = 3;
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.guestBindingSource, "Birthday", true));
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(146, 118);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthdayDateTimePicker.TabIndex = 5;
            // 
            // statusIdComboBox
            // 
            this.statusIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestBindingSource, "StatusId", true));
            this.statusIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.guestBindingSource, "StatusId", true));
            this.statusIdComboBox.DataSource = this.statusBindingSource;
            this.statusIdComboBox.DisplayMember = "StatusName";
            this.statusIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusIdComboBox.FormattingEnabled = true;
            this.statusIdComboBox.Location = new System.Drawing.Point(146, 190);
            this.statusIdComboBox.Name = "statusIdComboBox";
            this.statusIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.statusIdComboBox.TabIndex = 9;
            this.statusIdComboBox.ValueMember = "IdStatus";
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.northbeeDataSet;
            // 
            // guestTableAdapter
            // 
            this.guestTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GenderTableAdapter = this.genderTableAdapter;
            this.tableAdapterManager.GuestTableAdapter = this.guestTableAdapter;
            this.tableAdapterManager.HistoryTableAdapter = null;
            this.tableAdapterManager.HotelTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = null;
            this.tableAdapterManager.RoomTypeTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = this.statusTableAdapter;
            this.tableAdapterManager.UpdateOrder = NorthBee.northbeeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // genderTableAdapter
            // 
            this.genderTableAdapter.ClearBeforeFill = true;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // AddUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUpdateForm";
            this.Text = "Добавление гостя";
            this.Load += new System.EventHandler(this.AddUpdateForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northbeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TitleLab;
        private System.Windows.Forms.PictureBox TitlePic;
        private northbeeDataSet northbeeDataSet;
        private System.Windows.Forms.BindingSource guestBindingSource;
        private northbeeDataSetTableAdapters.GuestTableAdapter guestTableAdapter;
        private northbeeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.ComboBox statusIdComboBox;
        private System.Windows.Forms.ComboBox genderIdComboBox;
        private System.Windows.Forms.Button button1;
        private northbeeDataSetTableAdapters.GenderTableAdapter genderTableAdapter;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private northbeeDataSetTableAdapters.StatusTableAdapter statusTableAdapter;
        private System.Windows.Forms.BindingSource statusBindingSource;
    }
}