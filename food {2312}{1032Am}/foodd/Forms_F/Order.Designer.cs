namespace foodd.Forms_F
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.dataDishView = new System.Windows.Forms.DataGridView();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodDishBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.picBox = new System.Windows.Forms.PictureBox();
            this.txtD_Description = new System.Windows.Forms.TextBox();
            this.txtD_Price = new System.Windows.Forms.TextBox();
            this.txtD_Name = new System.Windows.Forms.TextBox();
            this.panView = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDataGridRef = new System.Windows.Forms.Button();
            this.panFilter = new System.Windows.Forms.Panel();
            this.combSizeFilter = new System.Windows.Forms.ComboBox();
            this.foodSizeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combTypeFilter = new System.Windows.Forms.ComboBox();
            this.foodTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumberD = new System.Windows.Forms.TextBox();
            this.cusOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataCusOrder = new System.Windows.Forms.DataGridView();
            this.dateOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChangeQuan = new System.Windows.Forms.Button();
            this.txtChangeQuan = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCusO_Ref = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataDishView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodDishBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.panView.SuspendLayout();
            this.panFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodSizeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCusOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDishView
            // 
            this.dataDishView.AllowUserToAddRows = false;
            this.dataDishView.AllowUserToDeleteRows = false;
            this.dataDishView.AutoGenerateColumns = false;
            this.dataDishView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDishView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stock,
            this.nameDataGridViewTextBoxColumn});
            this.dataDishView.DataSource = this.foodDishBindingSource;
            this.dataDishView.Location = new System.Drawing.Point(12, 97);
            this.dataDishView.Name = "dataDishView";
            this.dataDishView.ReadOnly = true;
            this.dataDishView.Size = new System.Drawing.Size(240, 570);
            this.dataDishView.TabIndex = 0;
            this.dataDishView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDishView_CellClick);
            // 
            // stock
            // 
            this.stock.DataPropertyName = "stock";
            this.stock.HeaderText = "Left";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Width = 35;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nameDataGridViewTextBoxColumn.Width = 160;
            // 
            // foodDishBindingSource
            // 
            this.foodDishBindingSource.DataSource = typeof(Model.Food_Dish);
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(0, 18);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(232, 277);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // txtD_Description
            // 
            this.txtD_Description.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodDishBindingSource, "description", true));
            this.txtD_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtD_Description.Location = new System.Drawing.Point(364, 113);
            this.txtD_Description.Multiline = true;
            this.txtD_Description.Name = "txtD_Description";
            this.txtD_Description.ReadOnly = true;
            this.txtD_Description.Size = new System.Drawing.Size(302, 182);
            this.txtD_Description.TabIndex = 1;
            // 
            // txtD_Price
            // 
            this.txtD_Price.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodDishBindingSource, "price", true));
            this.txtD_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtD_Price.Location = new System.Drawing.Point(364, 64);
            this.txtD_Price.Name = "txtD_Price";
            this.txtD_Price.ReadOnly = true;
            this.txtD_Price.Size = new System.Drawing.Size(302, 26);
            this.txtD_Price.TabIndex = 1;
            // 
            // txtD_Name
            // 
            this.txtD_Name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodDishBindingSource, "name", true));
            this.txtD_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtD_Name.ForeColor = System.Drawing.Color.Red;
            this.txtD_Name.Location = new System.Drawing.Point(364, 22);
            this.txtD_Name.Name = "txtD_Name";
            this.txtD_Name.ReadOnly = true;
            this.txtD_Name.Size = new System.Drawing.Size(302, 26);
            this.txtD_Name.TabIndex = 1;
            // 
            // panView
            // 
            this.panView.Controls.Add(this.picBox);
            this.panView.Controls.Add(this.txtD_Description);
            this.panView.Controls.Add(this.txtD_Price);
            this.panView.Controls.Add(this.txtD_Name);
            this.panView.Controls.Add(this.label2);
            this.panView.Controls.Add(this.label5);
            this.panView.Controls.Add(this.label3);
            this.panView.Location = new System.Drawing.Point(301, 30);
            this.panView.Name = "panView";
            this.panView.Size = new System.Drawing.Size(682, 322);
            this.panView.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(303, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(265, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(310, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Price:";
            // 
            // btnDataGridRef
            // 
            this.btnDataGridRef.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDataGridRef.BackgroundImage")));
            this.btnDataGridRef.FlatAppearance.BorderSize = 0;
            this.btnDataGridRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataGridRef.Location = new System.Drawing.Point(257, 97);
            this.btnDataGridRef.Name = "btnDataGridRef";
            this.btnDataGridRef.Size = new System.Drawing.Size(28, 28);
            this.btnDataGridRef.TabIndex = 7;
            this.btnDataGridRef.UseVisualStyleBackColor = true;
            this.btnDataGridRef.Click += new System.EventHandler(this.btnDataGridRef_Click);
            // 
            // panFilter
            // 
            this.panFilter.Controls.Add(this.combSizeFilter);
            this.panFilter.Controls.Add(this.combTypeFilter);
            this.panFilter.Controls.Add(this.label8);
            this.panFilter.Controls.Add(this.label7);
            this.panFilter.Location = new System.Drawing.Point(12, 12);
            this.panFilter.Name = "panFilter";
            this.panFilter.Size = new System.Drawing.Size(283, 30);
            this.panFilter.TabIndex = 13;
            // 
            // combSizeFilter
            // 
            this.combSizeFilter.DataSource = this.foodSizeBindingSource;
            this.combSizeFilter.DisplayMember = "name";
            this.combSizeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combSizeFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combSizeFilter.FormattingEnabled = true;
            this.combSizeFilter.Location = new System.Drawing.Point(191, 3);
            this.combSizeFilter.Name = "combSizeFilter";
            this.combSizeFilter.Size = new System.Drawing.Size(82, 21);
            this.combSizeFilter.TabIndex = 11;
            this.combSizeFilter.ValueMember = "Id";
            this.combSizeFilter.SelectedIndexChanged += new System.EventHandler(this.combSizeFilter_SelectedIndexChanged);
            // 
            // foodSizeBindingSource
            // 
            this.foodSizeBindingSource.DataSource = typeof(Model.Food_Size);
            // 
            // combTypeFilter
            // 
            this.combTypeFilter.DataSource = this.foodTypeBindingSource;
            this.combTypeFilter.DisplayMember = "nameType";
            this.combTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combTypeFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combTypeFilter.FormattingEnabled = true;
            this.combTypeFilter.Location = new System.Drawing.Point(52, 3);
            this.combTypeFilter.Name = "combTypeFilter";
            this.combTypeFilter.Size = new System.Drawing.Size(87, 21);
            this.combTypeFilter.TabIndex = 9;
            this.combTypeFilter.ValueMember = "Id";
            this.combTypeFilter.SelectedIndexChanged += new System.EventHandler(this.combTypeFilter_SelectedIndexChanged);
            // 
            // foodTypeBindingSource
            // 
            this.foodTypeBindingSource.DataSource = typeof(Model.Food_Type);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(145, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Size:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(297, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "How many ?";
            // 
            // txtNumberD
            // 
            this.txtNumberD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtNumberD.Location = new System.Drawing.Point(301, 391);
            this.txtNumberD.Name = "txtNumberD";
            this.txtNumberD.Size = new System.Drawing.Size(100, 26);
            this.txtNumberD.TabIndex = 15;
            this.txtNumberD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumberD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberD_KeyPress);
            // 
            // cusOrdersBindingSource
            // 
            this.cusOrdersBindingSource.DataSource = typeof(Model.CusOrders);
            // 
            // dataCusOrder
            // 
            this.dataCusOrder.AllowUserToAddRows = false;
            this.dataCusOrder.AllowUserToDeleteRows = false;
            this.dataCusOrder.AutoGenerateColumns = false;
            this.dataCusOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCusOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateOrderDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.numberDishDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataCusOrder.DataSource = this.cusOrdersBindingSource;
            this.dataCusOrder.Location = new System.Drawing.Point(460, 391);
            this.dataCusOrder.Name = "dataCusOrder";
            this.dataCusOrder.ReadOnly = true;
            this.dataCusOrder.Size = new System.Drawing.Size(510, 150);
            this.dataCusOrder.TabIndex = 16;
            this.dataCusOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCusOrder_CellClick);
            // 
            // dateOrderDataGridViewTextBoxColumn
            // 
            this.dateOrderDataGridViewTextBoxColumn.DataPropertyName = "dateOrder";
            this.dateOrderDataGridViewTextBoxColumn.HeaderText = "Order date";
            this.dateOrderDataGridViewTextBoxColumn.Name = "dateOrderDataGridViewTextBoxColumn";
            this.dateOrderDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOrderDataGridViewTextBoxColumn.Width = 110;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 180;
            // 
            // numberDishDataGridViewTextBoxColumn
            // 
            this.numberDishDataGridViewTextBoxColumn.DataPropertyName = "numberDish";
            this.numberDishDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.numberDishDataGridViewTextBoxColumn.Name = "numberDishDataGridViewTextBoxColumn";
            this.numberDishDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberDishDataGridViewTextBoxColumn.Width = 70;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Lime;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Location = new System.Drawing.Point(301, 423);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(100, 33);
            this.btnOrder.TabIndex = 17;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(456, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Your oder:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(454, 587);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 31);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total:";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCost.Location = new System.Drawing.Point(543, 587);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(44, 31);
            this.labelCost.TabIndex = 20;
            this.labelCost.Text = "0$";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(672, 549);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 33);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChangeQuan
            // 
            this.btnChangeQuan.BackColor = System.Drawing.Color.Blue;
            this.btnChangeQuan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnChangeQuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeQuan.ForeColor = System.Drawing.Color.White;
            this.btnChangeQuan.Location = new System.Drawing.Point(566, 549);
            this.btnChangeQuan.Name = "btnChangeQuan";
            this.btnChangeQuan.Size = new System.Drawing.Size(100, 33);
            this.btnChangeQuan.TabIndex = 22;
            this.btnChangeQuan.Text = "Change quantity";
            this.btnChangeQuan.UseVisualStyleBackColor = false;
            this.btnChangeQuan.Click += new System.EventHandler(this.btnChangeQuan_Click);
            // 
            // txtChangeQuan
            // 
            this.txtChangeQuan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cusOrdersBindingSource, "numberDish", true));
            this.txtChangeQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangeQuan.Location = new System.Drawing.Point(460, 551);
            this.txtChangeQuan.Name = "txtChangeQuan";
            this.txtChangeQuan.Size = new System.Drawing.Size(100, 31);
            this.txtChangeQuan.TabIndex = 24;
            this.txtChangeQuan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChangeQuan_KeyPress);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnDone.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(870, 547);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(100, 33);
            this.btnDone.TabIndex = 26;
            this.btnDone.Text = "Done!";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchName.Location = new System.Drawing.Point(12, 48);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(185, 38);
            this.txtSearchName.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Yellow;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(203, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 38);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCusO_Ref
            // 
            this.btnCusO_Ref.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCusO_Ref.BackgroundImage")));
            this.btnCusO_Ref.FlatAppearance.BorderSize = 0;
            this.btnCusO_Ref.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCusO_Ref.Location = new System.Drawing.Point(426, 391);
            this.btnCusO_Ref.Name = "btnCusO_Ref";
            this.btnCusO_Ref.Size = new System.Drawing.Size(28, 28);
            this.btnCusO_Ref.TabIndex = 7;
            this.btnCusO_Ref.UseVisualStyleBackColor = true;
            this.btnCusO_Ref.Click += new System.EventHandler(this.btnCusO_Ref_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(342, 533);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 28;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1018, 712);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txtChangeQuan);
            this.Controls.Add(this.btnChangeQuan);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.dataCusOrder);
            this.Controls.Add(this.txtNumberD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panFilter);
            this.Controls.Add(this.btnCusO_Ref);
            this.Controls.Add(this.btnDataGridRef);
            this.Controls.Add(this.panView);
            this.Controls.Add(this.dataDishView);
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            ((System.ComponentModel.ISupportInitialize)(this.dataDishView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodDishBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.panView.ResumeLayout(false);
            this.panView.PerformLayout();
            this.panFilter.ResumeLayout(false);
            this.panFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodSizeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCusOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataDishView;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.TextBox txtD_Description;
        private System.Windows.Forms.TextBox txtD_Price;
        private System.Windows.Forms.TextBox txtD_Name;
        private System.Windows.Forms.Panel panView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource foodDishBindingSource;
        private System.Windows.Forms.Button btnDataGridRef;
        private System.Windows.Forms.Panel panFilter;
        private System.Windows.Forms.ComboBox combSizeFilter;
        private System.Windows.Forms.ComboBox combTypeFilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource foodTypeBindingSource;
        private System.Windows.Forms.BindingSource foodSizeBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberD;
        private System.Windows.Forms.DataGridView dataCusOrder;
        private System.Windows.Forms.BindingSource cusOrdersBindingSource;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChangeQuan;
        private System.Windows.Forms.TextBox txtChangeQuan;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCusO_Ref;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}