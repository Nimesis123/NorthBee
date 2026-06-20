namespace NorthBee.Forms
{
    partial class HistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TitleLab = new System.Windows.Forms.Label();
            this.TitlePic = new System.Windows.Forms.PictureBox();
            this.historyDataGridView = new System.Windows.Forms.DataGridView();
            this.hotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northbeeDataSet = new NorthBee.northbeeDataSet();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historyTableAdapter = new NorthBee.northbeeDataSetTableAdapters.HistoryTableAdapter();
            this.tableAdapterManager = new NorthBee.northbeeDataSetTableAdapters.TableAdapterManager();
            this.roomTableAdapter = new NorthBee.northbeeDataSetTableAdapters.RoomTableAdapter();
            this.hotelTableAdapter = new NorthBee.northbeeDataSetTableAdapters.HotelTableAdapter();
            this.RoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northbeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.historyDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(784, 411);
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
            this.panel1.Size = new System.Drawing.Size(784, 70);
            this.panel1.TabIndex = 0;
            // 
            // TitleLab
            // 
            this.TitleLab.AutoSize = true;
            this.TitleLab.Location = new System.Drawing.Point(66, 10);
            this.TitleLab.Name = "TitleLab";
            this.TitleLab.Size = new System.Drawing.Size(137, 13);
            this.TitleLab.TabIndex = 1;
            this.TitleLab.Text = "История остановок гостя";
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
            // historyDataGridView
            // 
            this.historyDataGridView.AllowUserToAddRows = false;
            this.historyDataGridView.AllowUserToDeleteRows = false;
            this.historyDataGridView.AutoGenerateColumns = false;
            this.historyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomId,
            this.Column1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.historyDataGridView.DataSource = this.historyBindingSource;
            this.historyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyDataGridView.Location = new System.Drawing.Point(0, 0);
            this.historyDataGridView.Name = "historyDataGridView";
            this.historyDataGridView.ReadOnly = true;
            this.historyDataGridView.Size = new System.Drawing.Size(784, 337);
            this.historyDataGridView.TabIndex = 0;
            // 
            // hotelBindingSource
            // 
            this.hotelBindingSource.DataMember = "Hotel";
            this.hotelBindingSource.DataSource = this.northbeeDataSet;
            // 
            // northbeeDataSet
            // 
            this.northbeeDataSet.DataSetName = "northbeeDataSet";
            this.northbeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.northbeeDataSet;
            // 
            // historyBindingSource
            // 
            this.historyBindingSource.DataMember = "History";
            this.historyBindingSource.DataSource = this.northbeeDataSet;
            // 
            // historyTableAdapter
            // 
            this.historyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.GuestTableAdapter = null;
            this.tableAdapterManager.HistoryTableAdapter = this.historyTableAdapter;
            this.tableAdapterManager.HotelTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = null;
            this.tableAdapterManager.RoomTypeTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NorthBee.northbeeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // hotelTableAdapter
            // 
            this.hotelTableAdapter.ClearBeforeFill = true;
            // 
            // RoomId
            // 
            this.RoomId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoomId.DataPropertyName = "HotelName";
            this.RoomId.HeaderText = "Название отеля";
            this.RoomId.Name = "RoomId";
            this.RoomId.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "RoomNumber";
            this.Column1.HeaderText = "Номер комнаты";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CheckIn";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата заселения";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CheckOut";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата выселения";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn6.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistoryForm";
            this.Text = "История остановок гостя";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northbeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TitleLab;
        private System.Windows.Forms.PictureBox TitlePic;
        private northbeeDataSet northbeeDataSet;
        private System.Windows.Forms.BindingSource historyBindingSource;
        private northbeeDataSetTableAdapters.HistoryTableAdapter historyTableAdapter;
        private northbeeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView historyDataGridView;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private northbeeDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.BindingSource hotelBindingSource;
        private northbeeDataSetTableAdapters.HotelTableAdapter hotelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}