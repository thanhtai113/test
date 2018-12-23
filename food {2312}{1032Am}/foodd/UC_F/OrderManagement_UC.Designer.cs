namespace foodd.UC_F
{
    partial class OrderManagement_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderManagement_UC));
            this.dataGridTempt = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridHis = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDishDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOrderDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderHistorysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearTempt = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnClearHis = new System.Windows.Forms.Button();
            this.btnRefTempt = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelStatus = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.btnRefHis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTempt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistorysBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTempt
            // 
            this.dataGridTempt.AllowUserToAddRows = false;
            this.dataGridTempt.AllowUserToDeleteRows = false;
            this.dataGridTempt.AutoGenerateColumns = false;
            this.dataGridTempt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTempt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.numberDishDataGridViewTextBoxColumn,
            this.dateOrderDataGridViewTextBoxColumn});
            this.dataGridTempt.DataSource = this.cusOrdersBindingSource;
            this.dataGridTempt.Location = new System.Drawing.Point(39, 60);
            this.dataGridTempt.Name = "dataGridTempt";
            this.dataGridTempt.ReadOnly = true;
            this.dataGridTempt.Size = new System.Drawing.Size(447, 519);
            this.dataGridTempt.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberDishDataGridViewTextBoxColumn
            // 
            this.numberDishDataGridViewTextBoxColumn.DataPropertyName = "numberDish";
            this.numberDishDataGridViewTextBoxColumn.HeaderText = "numberDish";
            this.numberDishDataGridViewTextBoxColumn.Name = "numberDishDataGridViewTextBoxColumn";
            this.numberDishDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOrderDataGridViewTextBoxColumn
            // 
            this.dateOrderDataGridViewTextBoxColumn.DataPropertyName = "dateOrder";
            this.dateOrderDataGridViewTextBoxColumn.HeaderText = "dateOrder";
            this.dateOrderDataGridViewTextBoxColumn.Name = "dateOrderDataGridViewTextBoxColumn";
            this.dateOrderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cusOrdersBindingSource
            // 
            this.cusOrdersBindingSource.DataSource = typeof(Model.CusOrders);
            // 
            // dataGridHis
            // 
            this.dataGridHis.AllowUserToAddRows = false;
            this.dataGridHis.AllowUserToDeleteRows = false;
            this.dataGridHis.AutoGenerateColumns = false;
            this.dataGridHis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.numberDishDataGridViewTextBoxColumn1,
            this.dateOrderDataGridViewTextBoxColumn1});
            this.dataGridHis.DataSource = this.orderHistorysBindingSource;
            this.dataGridHis.Location = new System.Drawing.Point(651, 60);
            this.dataGridHis.Name = "dataGridHis";
            this.dataGridHis.ReadOnly = true;
            this.dataGridHis.Size = new System.Drawing.Size(447, 519);
            this.dataGridHis.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // numberDishDataGridViewTextBoxColumn1
            // 
            this.numberDishDataGridViewTextBoxColumn1.DataPropertyName = "numberDish";
            this.numberDishDataGridViewTextBoxColumn1.HeaderText = "numberDish";
            this.numberDishDataGridViewTextBoxColumn1.Name = "numberDishDataGridViewTextBoxColumn1";
            this.numberDishDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dateOrderDataGridViewTextBoxColumn1
            // 
            this.dateOrderDataGridViewTextBoxColumn1.DataPropertyName = "dateOrder";
            this.dateOrderDataGridViewTextBoxColumn1.HeaderText = "dateOrder";
            this.dateOrderDataGridViewTextBoxColumn1.Name = "dateOrderDataGridViewTextBoxColumn1";
            this.dateOrderDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // orderHistorysBindingSource
            // 
            this.orderHistorysBindingSource.DataSource = typeof(Model.OrderHistorys);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer orders:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(645, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order history:";
            // 
            // btnClearTempt
            // 
            this.btnClearTempt.BackColor = System.Drawing.Color.Crimson;
            this.btnClearTempt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClearTempt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTempt.ForeColor = System.Drawing.Color.White;
            this.btnClearTempt.Location = new System.Drawing.Point(351, 586);
            this.btnClearTempt.Name = "btnClearTempt";
            this.btnClearTempt.Size = new System.Drawing.Size(135, 45);
            this.btnClearTempt.TabIndex = 3;
            this.btnClearTempt.Text = "Clear";
            this.btnClearTempt.UseVisualStyleBackColor = false;
            this.btnClearTempt.Click += new System.EventHandler(this.btnClearTempt_Click);
            // 
            // btnExport
            // 
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Location = new System.Drawing.Point(978, 585);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(57, 45);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnClearHis
            // 
            this.btnClearHis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearHis.Location = new System.Drawing.Point(1041, 585);
            this.btnClearHis.Name = "btnClearHis";
            this.btnClearHis.Size = new System.Drawing.Size(57, 45);
            this.btnClearHis.TabIndex = 5;
            this.btnClearHis.Text = "Clear history";
            this.btnClearHis.UseVisualStyleBackColor = true;
            this.btnClearHis.Click += new System.EventHandler(this.btnClearHis_Click);
            // 
            // btnRefTempt
            // 
            this.btnRefTempt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefTempt.BackgroundImage")));
            this.btnRefTempt.FlatAppearance.BorderSize = 0;
            this.btnRefTempt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefTempt.Location = new System.Drawing.Point(492, 60);
            this.btnRefTempt.Name = "btnRefTempt";
            this.btnRefTempt.Size = new System.Drawing.Size(28, 28);
            this.btnRefTempt.TabIndex = 7;
            this.btnRefTempt.UseVisualStyleBackColor = true;
            this.btnRefTempt.Click += new System.EventHandler(this.btnRefTempt_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(299, 586);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(46, 45);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(33, 586);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTotal.Location = new System.Drawing.Point(122, 587);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(29, 31);
            this.labelTotal.TabIndex = 10;
            this.labelTotal.Text = "$";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(651, 586);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(321, 40);
            this.progressBar.TabIndex = 11;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(799, 629);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(82, 13);
            this.labelStatus.TabIndex = 12;
            this.labelStatus.Text = "Processing...0%";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // btnRefHis
            // 
            this.btnRefHis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefHis.BackgroundImage")));
            this.btnRefHis.FlatAppearance.BorderSize = 0;
            this.btnRefHis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefHis.Location = new System.Drawing.Point(1104, 60);
            this.btnRefHis.Name = "btnRefHis";
            this.btnRefHis.Size = new System.Drawing.Size(28, 28);
            this.btnRefHis.TabIndex = 13;
            this.btnRefHis.UseVisualStyleBackColor = true;
            this.btnRefHis.Click += new System.EventHandler(this.btnRefHis_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(492, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 128);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderManagement_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRefHis);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRefTempt);
            this.Controls.Add(this.btnClearHis);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnClearTempt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridHis);
            this.Controls.Add(this.dataGridTempt);
            this.Name = "OrderManagement_UC";
            this.Size = new System.Drawing.Size(1164, 648);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTempt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistorysBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTempt;
        private System.Windows.Forms.DataGridView dataGridHis;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cusOrdersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDishDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOrderDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource orderHistorysBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearTempt;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnClearHis;
        private System.Windows.Forms.Button btnRefTempt;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button btnRefHis;
        private System.Windows.Forms.Button button1;
    }
}
