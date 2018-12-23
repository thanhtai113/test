namespace foodd.Forms_F
{
    partial class Management
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
            this.panMainSide = new System.Windows.Forms.Panel();
            this.btnOrderMain = new System.Windows.Forms.Button();
            this.linkLogout = new System.Windows.Forms.LinkLabel();
            this.linkChangePass = new System.Windows.Forms.LinkLabel();
            this.laName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccMain = new System.Windows.Forms.Button();
            this.btnPositionMain = new System.Windows.Forms.Button();
            this.btnDishMain = new System.Windows.Forms.Button();
            this.btnSizeMain = new System.Windows.Forms.Button();
            this.panSide = new System.Windows.Forms.Panel();
            this.btnTypeMain = new System.Windows.Forms.Button();
            this.dish_UC1 = new foodd.UC_F.Dish_UC();
            this.panMainSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMainSide
            // 
            this.panMainSide.BackColor = System.Drawing.Color.Silver;
            this.panMainSide.Controls.Add(this.btnOrderMain);
            this.panMainSide.Controls.Add(this.linkLogout);
            this.panMainSide.Controls.Add(this.linkChangePass);
            this.panMainSide.Controls.Add(this.laName);
            this.panMainSide.Controls.Add(this.label1);
            this.panMainSide.Controls.Add(this.btnAccMain);
            this.panMainSide.Controls.Add(this.btnPositionMain);
            this.panMainSide.Controls.Add(this.btnDishMain);
            this.panMainSide.Controls.Add(this.btnSizeMain);
            this.panMainSide.Controls.Add(this.panSide);
            this.panMainSide.Controls.Add(this.btnTypeMain);
            this.panMainSide.Location = new System.Drawing.Point(0, 0);
            this.panMainSide.Name = "panMainSide";
            this.panMainSide.Size = new System.Drawing.Size(98, 681);
            this.panMainSide.TabIndex = 0;
            // 
            // btnOrderMain
            // 
            this.btnOrderMain.BackColor = System.Drawing.Color.White;
            this.btnOrderMain.FlatAppearance.BorderSize = 0;
            this.btnOrderMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderMain.Location = new System.Drawing.Point(33, 328);
            this.btnOrderMain.Name = "btnOrderMain";
            this.btnOrderMain.Size = new System.Drawing.Size(65, 83);
            this.btnOrderMain.TabIndex = 7;
            this.btnOrderMain.Text = "Orders";
            this.btnOrderMain.UseVisualStyleBackColor = false;
            this.btnOrderMain.Click += new System.EventHandler(this.btnOrderMain_Click);
            // 
            // linkLogout
            // 
            this.linkLogout.AutoSize = true;
            this.linkLogout.Location = new System.Drawing.Point(3, 39);
            this.linkLogout.Name = "linkLogout";
            this.linkLogout.Size = new System.Drawing.Size(40, 13);
            this.linkLogout.TabIndex = 6;
            this.linkLogout.TabStop = true;
            this.linkLogout.Text = "Logout";
            this.linkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogout_LinkClicked);
            // 
            // linkChangePass
            // 
            this.linkChangePass.AutoSize = true;
            this.linkChangePass.Location = new System.Drawing.Point(3, 26);
            this.linkChangePass.Name = "linkChangePass";
            this.linkChangePass.Size = new System.Drawing.Size(92, 13);
            this.linkChangePass.TabIndex = 6;
            this.linkChangePass.TabStop = true;
            this.linkChangePass.Text = "Change password";
            this.linkChangePass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkChangePass_LinkClicked);
            // 
            // laName
            // 
            this.laName.AutoSize = true;
            this.laName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laName.ForeColor = System.Drawing.Color.Black;
            this.laName.Location = new System.Drawing.Point(30, 9);
            this.laName.Name = "laName";
            this.laName.Size = new System.Drawing.Size(32, 17);
            this.laName.TabIndex = 1;
            this.laName.Text = "xxxx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hi";
            // 
            // btnAccMain
            // 
            this.btnAccMain.BackColor = System.Drawing.Color.White;
            this.btnAccMain.FlatAppearance.BorderSize = 0;
            this.btnAccMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccMain.Location = new System.Drawing.Point(33, 417);
            this.btnAccMain.Name = "btnAccMain";
            this.btnAccMain.Size = new System.Drawing.Size(65, 83);
            this.btnAccMain.TabIndex = 1;
            this.btnAccMain.Text = "Account";
            this.btnAccMain.UseVisualStyleBackColor = false;
            this.btnAccMain.Click += new System.EventHandler(this.btnAcc_Click);
            // 
            // btnPositionMain
            // 
            this.btnPositionMain.BackColor = System.Drawing.Color.White;
            this.btnPositionMain.FlatAppearance.BorderSize = 0;
            this.btnPositionMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPositionMain.ForeColor = System.Drawing.Color.Black;
            this.btnPositionMain.Location = new System.Drawing.Point(33, 506);
            this.btnPositionMain.Name = "btnPositionMain";
            this.btnPositionMain.Size = new System.Drawing.Size(65, 83);
            this.btnPositionMain.TabIndex = 5;
            this.btnPositionMain.Text = "Position";
            this.btnPositionMain.UseVisualStyleBackColor = false;
            this.btnPositionMain.Click += new System.EventHandler(this.btnPositionMain_Click);
            // 
            // btnDishMain
            // 
            this.btnDishMain.BackColor = System.Drawing.Color.White;
            this.btnDishMain.FlatAppearance.BorderSize = 0;
            this.btnDishMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDishMain.Location = new System.Drawing.Point(33, 239);
            this.btnDishMain.Name = "btnDishMain";
            this.btnDishMain.Size = new System.Drawing.Size(65, 83);
            this.btnDishMain.TabIndex = 1;
            this.btnDishMain.Text = "Dish";
            this.btnDishMain.UseVisualStyleBackColor = false;
            this.btnDishMain.Click += new System.EventHandler(this.btnDishMain_Click);
            // 
            // btnSizeMain
            // 
            this.btnSizeMain.BackColor = System.Drawing.Color.White;
            this.btnSizeMain.FlatAppearance.BorderSize = 0;
            this.btnSizeMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSizeMain.Location = new System.Drawing.Point(33, 150);
            this.btnSizeMain.Name = "btnSizeMain";
            this.btnSizeMain.Size = new System.Drawing.Size(65, 83);
            this.btnSizeMain.TabIndex = 1;
            this.btnSizeMain.Text = "Size";
            this.btnSizeMain.UseVisualStyleBackColor = false;
            this.btnSizeMain.Click += new System.EventHandler(this.btnSizeMain_Click);
            // 
            // panSide
            // 
            this.panSide.BackColor = System.Drawing.Color.Red;
            this.panSide.Location = new System.Drawing.Point(6, 61);
            this.panSide.Name = "panSide";
            this.panSide.Size = new System.Drawing.Size(26, 83);
            this.panSide.TabIndex = 2;
            // 
            // btnTypeMain
            // 
            this.btnTypeMain.BackColor = System.Drawing.Color.White;
            this.btnTypeMain.FlatAppearance.BorderSize = 0;
            this.btnTypeMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeMain.Location = new System.Drawing.Point(33, 61);
            this.btnTypeMain.Name = "btnTypeMain";
            this.btnTypeMain.Size = new System.Drawing.Size(65, 83);
            this.btnTypeMain.TabIndex = 0;
            this.btnTypeMain.Text = "Type";
            this.btnTypeMain.UseVisualStyleBackColor = false;
            this.btnTypeMain.Click += new System.EventHandler(this.btnTypeMain_Click);
            // 
            // dish_UC1
            // 
            this.dish_UC1.BackColor = System.Drawing.Color.White;
            this.dish_UC1.Location = new System.Drawing.Point(108, 0);
            this.dish_UC1.Name = "dish_UC1";
            this.dish_UC1.Size = new System.Drawing.Size(1164, 648);
            this.dish_UC1.TabIndex = 1;
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 682);
            this.Controls.Add(this.dish_UC1);
            this.Controls.Add(this.panMainSide);
            this.Name = "Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management";
            this.Load += new System.EventHandler(this.Management_Load);
            this.panMainSide.ResumeLayout(false);
            this.panMainSide.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMainSide;
        private System.Windows.Forms.Panel panSide;
        private System.Windows.Forms.Button btnTypeMain;
        private System.Windows.Forms.Button btnSizeMain;
        private System.Windows.Forms.Button btnDishMain;
        private System.Windows.Forms.Button btnPositionMain;
        private System.Windows.Forms.Button btnAccMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label laName;
        private System.Windows.Forms.LinkLabel linkChangePass;
        private System.Windows.Forms.LinkLabel linkLogout;
        private System.Windows.Forms.Button btnOrderMain;
        private UC_F.Dish_UC dish_UC1;
    }
}