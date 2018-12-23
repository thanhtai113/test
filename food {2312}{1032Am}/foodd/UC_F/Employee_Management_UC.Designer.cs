namespace foodd.UC_F
{
    partial class Employee_Management_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Management_UC));
            this.picBox = new System.Windows.Forms.PictureBox();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtF_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtL_Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelPos = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.panSave = new System.Windows.Forms.Panel();
            this.comboPosRe = new System.Windows.Forms.ComboBox();
            this.positionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panCRUD = new System.Windows.Forms.Panel();
            this.btnLock_Unlock = new System.Windows.Forms.Button();
            this.btnAccRef = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comboPosFilter = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRef = new System.Windows.Forms.Button();
            this.panSearch = new System.Windows.Forms.Panel();
            this.txtSearchLast = new System.Windows.Forms.TextBox();
            this.txtSearchFirst = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSearchLast = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSearchFirst = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.isLockedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            this.panSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).BeginInit();
            this.panCRUD.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.accountsBindingSource, "imageURL", true));
            this.picBox.Location = new System.Drawing.Point(32, 9);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(221, 294);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 1;
            this.picBox.TabStop = false;
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataSource = typeof(Model.Accounts);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // txtUserName
            // 
            this.txtUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsBindingSource, "username", true));
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtUserName.Location = new System.Drawing.Point(443, 12);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(258, 26);
            this.txtUserName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(344, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // txtPass
            // 
            this.txtPass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsBindingSource, "password", true));
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtPass.Location = new System.Drawing.Point(443, 62);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(258, 26);
            this.txtPass.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(290, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm password";
            // 
            // txtConPass
            // 
            this.txtConPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtConPass.Location = new System.Drawing.Point(443, 112);
            this.txtConPass.Name = "txtConPass";
            this.txtConPass.Size = new System.Drawing.Size(258, 26);
            this.txtConPass.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(338, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "First name:";
            // 
            // txtF_Name
            // 
            this.txtF_Name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsBindingSource, "firstname", true));
            this.txtF_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtF_Name.Location = new System.Drawing.Point(443, 162);
            this.txtF_Name.Name = "txtF_Name";
            this.txtF_Name.Size = new System.Drawing.Size(258, 26);
            this.txtF_Name.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(338, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Last name:";
            // 
            // txtL_Name
            // 
            this.txtL_Name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsBindingSource, "lastname", true));
            this.txtL_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtL_Name.Location = new System.Drawing.Point(443, 212);
            this.txtL_Name.Name = "txtL_Name";
            this.txtL_Name.Size = new System.Drawing.Size(258, 26);
            this.txtL_Name.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(374, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsBindingSource, "email", true));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtEmail.Location = new System.Drawing.Point(443, 262);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(258, 26);
            this.txtEmail.TabIndex = 4;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Location = new System.Drawing.Point(116, 321);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(66, 30);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(367, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Phone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(354, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Address:";
            // 
            // labelPos
            // 
            this.labelPos.AutoSize = true;
            this.labelPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPos.Location = new System.Drawing.Point(357, 500);
            this.labelPos.Name = "labelPos";
            this.labelPos.Size = new System.Drawing.Size(69, 20);
            this.labelPos.TabIndex = 2;
            this.labelPos.Text = "Position:";
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsBindingSource, "phone", true));
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtPhone.Location = new System.Drawing.Point(443, 312);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(258, 26);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsBindingSource, "address", true));
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtAddress.Location = new System.Drawing.Point(443, 362);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(258, 123);
            this.txtAddress.TabIndex = 4;
            // 
            // panSave
            // 
            this.panSave.Controls.Add(this.comboPosRe);
            this.panSave.Controls.Add(this.picBox);
            this.panSave.Controls.Add(this.btnCancel);
            this.panSave.Controls.Add(this.btnSave);
            this.panSave.Controls.Add(this.btnBrowse);
            this.panSave.Controls.Add(this.txtUserName);
            this.panSave.Controls.Add(this.txtEmail);
            this.panSave.Controls.Add(this.label1);
            this.panSave.Controls.Add(this.txtAddress);
            this.panSave.Controls.Add(this.label2);
            this.panSave.Controls.Add(this.txtL_Name);
            this.panSave.Controls.Add(this.label3);
            this.panSave.Controls.Add(this.txtPhone);
            this.panSave.Controls.Add(this.label4);
            this.panSave.Controls.Add(this.txtF_Name);
            this.panSave.Controls.Add(this.label5);
            this.panSave.Controls.Add(this.txtConPass);
            this.panSave.Controls.Add(this.label7);
            this.panSave.Controls.Add(this.txtPass);
            this.panSave.Controls.Add(this.label8);
            this.panSave.Controls.Add(this.label6);
            this.panSave.Controls.Add(this.labelPos);
            this.panSave.Location = new System.Drawing.Point(427, 57);
            this.panSave.Name = "panSave";
            this.panSave.Size = new System.Drawing.Size(734, 585);
            this.panSave.TabIndex = 6;
            // 
            // comboPosRe
            // 
            this.comboPosRe.DataSource = this.positionsBindingSource;
            this.comboPosRe.DisplayMember = "positionName";
            this.comboPosRe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPosRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboPosRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboPosRe.FormattingEnabled = true;
            this.comboPosRe.Location = new System.Drawing.Point(443, 497);
            this.comboPosRe.Name = "comboPosRe";
            this.comboPosRe.Size = new System.Drawing.Size(121, 28);
            this.comboPosRe.TabIndex = 6;
            this.comboPosRe.ValueMember = "positionName";
            // 
            // positionsBindingSource
            // 
            this.positionsBindingSource.DataSource = typeof(Model.Positions);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(635, 552);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(66, 30);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(563, 552);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panCRUD
            // 
            this.panCRUD.Controls.Add(this.btnLock_Unlock);
            this.panCRUD.Controls.Add(this.btnAccRef);
            this.panCRUD.Controls.Add(this.btnDelete);
            this.panCRUD.Controls.Add(this.btnAdd);
            this.panCRUD.Controls.Add(this.btnEdit);
            this.panCRUD.Location = new System.Drawing.Point(313, 45);
            this.panCRUD.Name = "panCRUD";
            this.panCRUD.Size = new System.Drawing.Size(108, 230);
            this.panCRUD.TabIndex = 7;
            // 
            // btnLock_Unlock
            // 
            this.btnLock_Unlock.BackColor = System.Drawing.Color.Red;
            this.btnLock_Unlock.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLock_Unlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLock_Unlock.ForeColor = System.Drawing.Color.White;
            this.btnLock_Unlock.Location = new System.Drawing.Point(11, 157);
            this.btnLock_Unlock.Name = "btnLock_Unlock";
            this.btnLock_Unlock.Size = new System.Drawing.Size(82, 30);
            this.btnLock_Unlock.TabIndex = 9;
            this.btnLock_Unlock.Text = "Lock/Unlock";
            this.btnLock_Unlock.UseVisualStyleBackColor = false;
            this.btnLock_Unlock.Click += new System.EventHandler(this.btnLock_Unlock_Click);
            // 
            // btnAccRef
            // 
            this.btnAccRef.BackColor = System.Drawing.Color.White;
            this.btnAccRef.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAccRef.BackgroundImage")));
            this.btnAccRef.FlatAppearance.BorderSize = 0;
            this.btnAccRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccRef.Location = new System.Drawing.Point(11, 15);
            this.btnAccRef.Name = "btnAccRef";
            this.btnAccRef.Size = new System.Drawing.Size(28, 28);
            this.btnAccRef.TabIndex = 6;
            this.btnAccRef.UseVisualStyleBackColor = false;
            this.btnAccRef.Click += new System.EventHandler(this.btnAccRef_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(11, 121);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 30);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Blue;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(11, 49);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 30);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Tomato;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(11, 85);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(82, 30);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(3, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Position:";
            // 
            // comboPosFilter
            // 
            this.comboPosFilter.DataSource = this.positionsBindingSource;
            this.comboPosFilter.DisplayMember = "positionName";
            this.comboPosFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPosFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboPosFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboPosFilter.FormattingEnabled = true;
            this.comboPosFilter.Location = new System.Drawing.Point(78, 6);
            this.comboPosFilter.Name = "comboPosFilter";
            this.comboPosFilter.Size = new System.Drawing.Size(121, 28);
            this.comboPosFilter.TabIndex = 6;
            this.comboPosFilter.ValueMember = "positionName";
            this.comboPosFilter.SelectedIndexChanged += new System.EventHandler(this.comboPosFilter_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboPosFilter);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnRef);
            this.panel1.Location = new System.Drawing.Point(14, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 44);
            this.panel1.TabIndex = 7;
            // 
            // btnRef
            // 
            this.btnRef.BackColor = System.Drawing.Color.White;
            this.btnRef.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRef.BackgroundImage")));
            this.btnRef.FlatAppearance.BorderSize = 0;
            this.btnRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRef.Location = new System.Drawing.Point(205, 8);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(28, 28);
            this.btnRef.TabIndex = 6;
            this.btnRef.UseVisualStyleBackColor = false;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // panSearch
            // 
            this.panSearch.Controls.Add(this.txtSearchLast);
            this.panSearch.Controls.Add(this.txtSearchFirst);
            this.panSearch.Controls.Add(this.label12);
            this.panSearch.Controls.Add(this.btnSearchLast);
            this.panSearch.Controls.Add(this.label13);
            this.panSearch.Controls.Add(this.btnSearchFirst);
            this.panSearch.Location = new System.Drawing.Point(427, 7);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(734, 44);
            this.panSearch.TabIndex = 7;
            // 
            // txtSearchLast
            // 
            this.txtSearchLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtSearchLast.Location = new System.Drawing.Point(514, 8);
            this.txtSearchLast.Name = "txtSearchLast";
            this.txtSearchLast.Size = new System.Drawing.Size(125, 26);
            this.txtSearchLast.TabIndex = 7;
            // 
            // txtSearchFirst
            // 
            this.txtSearchFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtSearchFirst.Location = new System.Drawing.Point(128, 8);
            this.txtSearchFirst.Name = "txtSearchFirst";
            this.txtSearchFirst.Size = new System.Drawing.Size(125, 26);
            this.txtSearchFirst.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(418, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Last Name:";
            // 
            // btnSearchLast
            // 
            this.btnSearchLast.BackColor = System.Drawing.Color.Yellow;
            this.btnSearchLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchLast.Location = new System.Drawing.Point(645, 7);
            this.btnSearchLast.Name = "btnSearchLast";
            this.btnSearchLast.Size = new System.Drawing.Size(56, 30);
            this.btnSearchLast.TabIndex = 5;
            this.btnSearchLast.Text = "Search";
            this.btnSearchLast.UseVisualStyleBackColor = false;
            this.btnSearchLast.Click += new System.EventHandler(this.btnSearchLast_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(32, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "First Name:";
            // 
            // btnSearchFirst
            // 
            this.btnSearchFirst.BackColor = System.Drawing.Color.Yellow;
            this.btnSearchFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFirst.Location = new System.Drawing.Point(259, 6);
            this.btnSearchFirst.Name = "btnSearchFirst";
            this.btnSearchFirst.Size = new System.Drawing.Size(56, 30);
            this.btnSearchFirst.TabIndex = 5;
            this.btnSearchFirst.Text = "Search";
            this.btnSearchFirst.UseVisualStyleBackColor = false;
            this.btnSearchFirst.Click += new System.EventHandler(this.btnSearchFirst_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isLockedDataGridViewCheckBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.position});
            this.dataGridView.DataSource = this.accountsBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(14, 58);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(293, 535);
            this.dataGridView.TabIndex = 8;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // isLockedDataGridViewCheckBoxColumn
            // 
            this.isLockedDataGridViewCheckBoxColumn.DataPropertyName = "isLocked";
            this.isLockedDataGridViewCheckBoxColumn.HeaderText = "Locked";
            this.isLockedDataGridViewCheckBoxColumn.Name = "isLockedDataGridViewCheckBoxColumn";
            this.isLockedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isLockedDataGridViewCheckBoxColumn.Width = 45;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstnameDataGridViewTextBoxColumn.Width = 70;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastnameDataGridViewTextBoxColumn.Width = 70;
            // 
            // position
            // 
            this.position.DataPropertyName = "position";
            this.position.HeaderText = "position";
            this.position.Name = "position";
            this.position.ReadOnly = true;
            // 
            // Employee_Management_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panCRUD);
            this.Controls.Add(this.panSave);
            this.Name = "Employee_Management_UC";
            this.Size = new System.Drawing.Size(1164, 648);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            this.panSave.ResumeLayout(false);
            this.panSave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).EndInit();
            this.panCRUD.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panSearch.ResumeLayout(false);
            this.panSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtF_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtL_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelPos;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Panel panSave;
        private System.Windows.Forms.Panel panCRUD;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboPosRe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboPosFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panSearch;
        private System.Windows.Forms.TextBox txtSearchFirst;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSearchFirst;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtSearchLast;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSearchLast;
        private System.Windows.Forms.BindingSource positionsBindingSource;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private System.Windows.Forms.Button btnAccRef;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button btnLock_Unlock;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isLockedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
    }
}
