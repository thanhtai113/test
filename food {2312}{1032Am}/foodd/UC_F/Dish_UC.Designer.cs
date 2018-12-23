namespace foodd.UC_F
{
    partial class Dish_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dish_UC));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panCRUD = new System.Windows.Forms.Panel();
            this.btnLock_Unclock = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridDish = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isLock = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodDishBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDataGrid = new System.Windows.Forms.Button();
            this.panSave = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnSizeRef = new System.Windows.Forms.Button();
            this.btnTypeRef = new System.Windows.Forms.Button();
            this.comboSize = new System.Windows.Forms.ComboBox();
            this.foodSizeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboType = new System.Windows.Forms.ComboBox();
            this.foodTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtD_Description = new System.Windows.Forms.TextBox();
            this.txtD_Price = new System.Windows.Forms.TextBox();
            this.txtD_Name = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridSize = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridType = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combTypeFilter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.combSizeFilter = new System.Windows.Forms.ComboBox();
            this.panFilter = new System.Windows.Forms.Panel();
            this.panType_Size = new System.Windows.Forms.Panel();
            this.panCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodDishBindingSource)).BeginInit();
            this.panSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodSizeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridType)).BeginInit();
            this.panFilter.SuspendLayout();
            this.panType_Size.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(310, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(299, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(306, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(307, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(261, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Description:";
            // 
            // panCRUD
            // 
            this.panCRUD.BackColor = System.Drawing.Color.White;
            this.panCRUD.Controls.Add(this.btnLock_Unclock);
            this.panCRUD.Controls.Add(this.btnSearch);
            this.panCRUD.Controls.Add(this.txtSearch);
            this.panCRUD.Controls.Add(this.btnDelete);
            this.panCRUD.Controls.Add(this.btnEdit);
            this.panCRUD.Controls.Add(this.btnAdd);
            this.panCRUD.Location = new System.Drawing.Point(462, 180);
            this.panCRUD.Name = "panCRUD";
            this.panCRUD.Size = new System.Drawing.Size(653, 39);
            this.panCRUD.TabIndex = 1;
            // 
            // btnLock_Unclock
            // 
            this.btnLock_Unclock.BackColor = System.Drawing.Color.Red;
            this.btnLock_Unclock.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLock_Unclock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLock_Unclock.ForeColor = System.Drawing.Color.White;
            this.btnLock_Unclock.Location = new System.Drawing.Point(353, 3);
            this.btnLock_Unclock.Name = "btnLock_Unclock";
            this.btnLock_Unclock.Size = new System.Drawing.Size(81, 30);
            this.btnLock_Unclock.TabIndex = 13;
            this.btnLock_Unclock.Text = "Lock/Unlock";
            this.btnLock_Unclock.UseVisualStyleBackColor = false;
            this.btnLock_Unclock.Click += new System.EventHandler(this.btnLock_Unclock_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(244, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 30);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtSearch.Location = new System.Drawing.Point(3, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(235, 26);
            this.txtSearch.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(584, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(512, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(66, 30);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Blue;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(440, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridDish
            // 
            this.dataGridDish.AllowUserToAddRows = false;
            this.dataGridDish.AllowUserToDeleteRows = false;
            this.dataGridDish.AutoGenerateColumns = false;
            this.dataGridDish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDish.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.isLock,
            this.stock,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.TypeId,
            this.SizeId});
            this.dataGridDish.DataSource = this.foodDishBindingSource;
            this.dataGridDish.Location = new System.Drawing.Point(29, 21);
            this.dataGridDish.MultiSelect = false;
            this.dataGridDish.Name = "dataGridDish";
            this.dataGridDish.ReadOnly = true;
            this.dataGridDish.Size = new System.Drawing.Size(746, 150);
            this.dataGridDish.TabIndex = 2;
            this.dataGridDish.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 45;
            // 
            // isLock
            // 
            this.isLock.DataPropertyName = "isLock";
            this.isLock.HeaderText = "Locked";
            this.isLock.Name = "isLock";
            this.isLock.ReadOnly = true;
            this.isLock.Width = 45;
            // 
            // stock
            // 
            this.stock.DataPropertyName = "stock";
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn3.HeaderText = "description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn4.HeaderText = "price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // TypeId
            // 
            this.TypeId.DataPropertyName = "TypeId";
            this.TypeId.HeaderText = "TypeId";
            this.TypeId.Name = "TypeId";
            this.TypeId.ReadOnly = true;
            this.TypeId.Width = 50;
            // 
            // SizeId
            // 
            this.SizeId.DataPropertyName = "SizeId";
            this.SizeId.HeaderText = "SizeId";
            this.SizeId.Name = "SizeId";
            this.SizeId.ReadOnly = true;
            this.SizeId.Width = 50;
            // 
            // foodDishBindingSource
            // 
            this.foodDishBindingSource.DataSource = typeof(Model.Food_Dish);
            // 
            // btnDataGrid
            // 
            this.btnDataGrid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDataGrid.BackgroundImage")));
            this.btnDataGrid.FlatAppearance.BorderSize = 0;
            this.btnDataGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataGrid.Location = new System.Drawing.Point(1121, 24);
            this.btnDataGrid.Name = "btnDataGrid";
            this.btnDataGrid.Size = new System.Drawing.Size(28, 28);
            this.btnDataGrid.TabIndex = 6;
            this.btnDataGrid.UseVisualStyleBackColor = true;
            this.btnDataGrid.Click += new System.EventHandler(this.btnDataGrid_Click);
            // 
            // panSave
            // 
            this.panSave.Controls.Add(this.label9);
            this.panSave.Controls.Add(this.txtStock);
            this.panSave.Controls.Add(this.btnSizeRef);
            this.panSave.Controls.Add(this.btnTypeRef);
            this.panSave.Controls.Add(this.comboSize);
            this.panSave.Controls.Add(this.comboType);
            this.panSave.Controls.Add(this.btnBrowse);
            this.panSave.Controls.Add(this.picBox);
            this.panSave.Controls.Add(this.btnCancel);
            this.panSave.Controls.Add(this.btnSave);
            this.panSave.Controls.Add(this.txtD_Description);
            this.panSave.Controls.Add(this.txtD_Price);
            this.panSave.Controls.Add(this.txtD_Name);
            this.panSave.Controls.Add(this.label2);
            this.panSave.Controls.Add(this.label4);
            this.panSave.Controls.Add(this.label1);
            this.panSave.Controls.Add(this.label5);
            this.panSave.Controls.Add(this.label3);
            this.panSave.Location = new System.Drawing.Point(26, 249);
            this.panSave.Name = "panSave";
            this.panSave.Size = new System.Drawing.Size(951, 379);
            this.panSave.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(300, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Stock:";
            // 
            // txtStock
            // 
            this.txtStock.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodDishBindingSource, "stock", true));
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtStock.Location = new System.Drawing.Point(360, 162);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 26);
            this.txtStock.TabIndex = 6;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // btnSizeRef
            // 
            this.btnSizeRef.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSizeRef.BackgroundImage")));
            this.btnSizeRef.FlatAppearance.BorderSize = 0;
            this.btnSizeRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSizeRef.Location = new System.Drawing.Point(601, 91);
            this.btnSizeRef.Name = "btnSizeRef";
            this.btnSizeRef.Size = new System.Drawing.Size(28, 28);
            this.btnSizeRef.TabIndex = 5;
            this.btnSizeRef.UseVisualStyleBackColor = true;
            this.btnSizeRef.Click += new System.EventHandler(this.btnSizeRef_Click);
            // 
            // btnTypeRef
            // 
            this.btnTypeRef.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTypeRef.BackgroundImage")));
            this.btnTypeRef.FlatAppearance.BorderSize = 0;
            this.btnTypeRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeRef.Location = new System.Drawing.Point(601, 54);
            this.btnTypeRef.Name = "btnTypeRef";
            this.btnTypeRef.Size = new System.Drawing.Size(28, 28);
            this.btnTypeRef.TabIndex = 5;
            this.btnTypeRef.UseVisualStyleBackColor = true;
            this.btnTypeRef.Click += new System.EventHandler(this.btnTypeRef_Click);
            // 
            // comboSize
            // 
            this.comboSize.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodSizeBindingSource, "name", true));
            this.comboSize.DataSource = this.foodSizeBindingSource;
            this.comboSize.DisplayMember = "name";
            this.comboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboSize.FormattingEnabled = true;
            this.comboSize.Location = new System.Drawing.Point(360, 92);
            this.comboSize.Name = "comboSize";
            this.comboSize.Size = new System.Drawing.Size(235, 28);
            this.comboSize.TabIndex = 4;
            this.comboSize.ValueMember = "name";
            // 
            // foodSizeBindingSource
            // 
            this.foodSizeBindingSource.DataSource = typeof(Model.Food_Size);
            // 
            // comboType
            // 
            this.comboType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodTypeBindingSource, "nameType", true));
            this.comboType.DataSource = this.foodTypeBindingSource;
            this.comboType.DisplayMember = "nameType";
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(360, 56);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(235, 28);
            this.comboType.TabIndex = 4;
            this.comboType.ValueMember = "nameType";
            // 
            // foodTypeBindingSource
            // 
            this.foodTypeBindingSource.DataSource = typeof(Model.Food_Type);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.ForeColor = System.Drawing.Color.Black;
            this.btnBrowse.Location = new System.Drawing.Point(75, 286);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(66, 30);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(3, 3);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(232, 277);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(388, 346);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(66, 30);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(316, 346);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtD_Description
            // 
            this.txtD_Description.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodDishBindingSource, "description", true));
            this.txtD_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtD_Description.Location = new System.Drawing.Point(360, 196);
            this.txtD_Description.Multiline = true;
            this.txtD_Description.Name = "txtD_Description";
            this.txtD_Description.Size = new System.Drawing.Size(558, 142);
            this.txtD_Description.TabIndex = 1;
            // 
            // txtD_Price
            // 
            this.txtD_Price.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodDishBindingSource, "price", true));
            this.txtD_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtD_Price.Location = new System.Drawing.Point(360, 128);
            this.txtD_Price.Name = "txtD_Price";
            this.txtD_Price.Size = new System.Drawing.Size(122, 26);
            this.txtD_Price.TabIndex = 1;
            this.txtD_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtD_Price_KeyPress);
            // 
            // txtD_Name
            // 
            this.txtD_Name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodDishBindingSource, "name", true));
            this.txtD_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtD_Name.Location = new System.Drawing.Point(360, 22);
            this.txtD_Name.Name = "txtD_Name";
            this.txtD_Name.Size = new System.Drawing.Size(235, 26);
            this.txtD_Name.TabIndex = 1;
            // 
            // dataGridSize
            // 
            this.dataGridSize.AllowUserToAddRows = false;
            this.dataGridSize.AllowUserToDeleteRows = false;
            this.dataGridSize.AutoGenerateColumns = false;
            this.dataGridSize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSize.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridSize.DataSource = this.foodSizeBindingSource;
            this.dataGridSize.Location = new System.Drawing.Point(170, 3);
            this.dataGridSize.Name = "dataGridSize";
            this.dataGridSize.ReadOnly = true;
            this.dataGridSize.Size = new System.Drawing.Size(164, 150);
            this.dataGridSize.TabIndex = 7;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 20;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridType
            // 
            this.dataGridType.AllowUserToAddRows = false;
            this.dataGridType.AllowUserToDeleteRows = false;
            this.dataGridType.AutoGenerateColumns = false;
            this.dataGridType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameTypeDataGridViewTextBoxColumn});
            this.dataGridType.DataSource = this.foodTypeBindingSource;
            this.dataGridType.Location = new System.Drawing.Point(3, 3);
            this.dataGridType.Name = "dataGridType";
            this.dataGridType.ReadOnly = true;
            this.dataGridType.Size = new System.Drawing.Size(164, 150);
            this.dataGridType.TabIndex = 8;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 50;
            // 
            // nameTypeDataGridViewTextBoxColumn
            // 
            this.nameTypeDataGridViewTextBoxColumn.DataPropertyName = "nameType";
            this.nameTypeDataGridViewTextBoxColumn.HeaderText = "nameType";
            this.nameTypeDataGridViewTextBoxColumn.Name = "nameTypeDataGridViewTextBoxColumn";
            this.nameTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // combTypeFilter
            // 
            this.combTypeFilter.DataSource = this.foodTypeBindingSource;
            this.combTypeFilter.DisplayMember = "nameType";
            this.combTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combTypeFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combTypeFilter.FormattingEnabled = true;
            this.combTypeFilter.Location = new System.Drawing.Point(68, 26);
            this.combTypeFilter.Name = "combTypeFilter";
            this.combTypeFilter.Size = new System.Drawing.Size(87, 21);
            this.combTypeFilter.TabIndex = 9;
            this.combTypeFilter.ValueMember = "Id";
            this.combTypeFilter.SelectedIndexChanged += new System.EventHandler(this.combTypeFilter_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(10, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Filter:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(64, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(179, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Size";
            // 
            // combSizeFilter
            // 
            this.combSizeFilter.DataSource = this.foodSizeBindingSource;
            this.combSizeFilter.DisplayMember = "name";
            this.combSizeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combSizeFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combSizeFilter.FormattingEnabled = true;
            this.combSizeFilter.Location = new System.Drawing.Point(183, 26);
            this.combSizeFilter.Name = "combSizeFilter";
            this.combSizeFilter.Size = new System.Drawing.Size(82, 21);
            this.combSizeFilter.TabIndex = 11;
            this.combSizeFilter.ValueMember = "Id";
            this.combSizeFilter.SelectedIndexChanged += new System.EventHandler(this.combSizeFilter_SelectedIndexChanged);
            // 
            // panFilter
            // 
            this.panFilter.Controls.Add(this.combSizeFilter);
            this.panFilter.Controls.Add(this.combTypeFilter);
            this.panFilter.Controls.Add(this.label8);
            this.panFilter.Controls.Add(this.label7);
            this.panFilter.Controls.Add(this.label6);
            this.panFilter.Location = new System.Drawing.Point(29, 183);
            this.panFilter.Name = "panFilter";
            this.panFilter.Size = new System.Drawing.Size(283, 60);
            this.panFilter.TabIndex = 12;
            // 
            // panType_Size
            // 
            this.panType_Size.Controls.Add(this.dataGridType);
            this.panType_Size.Controls.Add(this.dataGridSize);
            this.panType_Size.Location = new System.Drawing.Point(781, 21);
            this.panType_Size.Name = "panType_Size";
            this.panType_Size.Size = new System.Drawing.Size(334, 153);
            this.panType_Size.TabIndex = 13;
            // 
            // Dish_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panType_Size);
            this.Controls.Add(this.panFilter);
            this.Controls.Add(this.btnDataGrid);
            this.Controls.Add(this.panSave);
            this.Controls.Add(this.panCRUD);
            this.Controls.Add(this.dataGridDish);
            this.Name = "Dish_UC";
            this.Size = new System.Drawing.Size(1164, 648);
            this.Load += new System.EventHandler(this.Dish_UC_Load);
            this.panCRUD.ResumeLayout(false);
            this.panCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodDishBindingSource)).EndInit();
            this.panSave.ResumeLayout(false);
            this.panSave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodSizeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridType)).EndInit();
            this.panFilter.ResumeLayout(false);
            this.panFilter.PerformLayout();
            this.panType_Size.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panCRUD;
        private System.Windows.Forms.DataGridView dataGridDish;
        private System.Windows.Forms.Panel panSave;
        private System.Windows.Forms.TextBox txtD_Name;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.TextBox txtD_Description;
        private System.Windows.Forms.TextBox txtD_Price;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;

        private System.Windows.Forms.ComboBox comboSize;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.BindingSource foodDishBindingSource;
        private System.Windows.Forms.Button btnSizeRef;
        private System.Windows.Forms.Button btnTypeRef;
        private System.Windows.Forms.BindingSource foodSizeBindingSource;
        private System.Windows.Forms.BindingSource foodTypeBindingSource;
        private System.Windows.Forms.Button btnDataGrid;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridSize;
        private System.Windows.Forms.DataGridView dataGridType;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox combTypeFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combSizeFilter;
        private System.Windows.Forms.Panel panFilter;
        private System.Windows.Forms.Button btnLock_Unclock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isLock;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeId;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panType_Size;
    }
}
