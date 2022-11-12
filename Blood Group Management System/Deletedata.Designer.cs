namespace Blood_Group_Management_System
{
    partial class Deletedata
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclear = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.bloodgroupcombo = new System.Windows.Forms.ComboBox();
            this.gendercombo = new System.Windows.Forms.ComboBox();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.agetxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.Bloodgroup = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 341);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1197, 297);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.bloodgroupcombo);
            this.panel1.Controls.Add(this.gendercombo);
            this.panel1.Controls.Add(this.addresstxt);
            this.panel1.Controls.Add(this.agetxt);
            this.panel1.Controls.Add(this.nametxt);
            this.panel1.Controls.Add(this.idtxt);
            this.panel1.Controls.Add(this.Bloodgroup);
            this.panel1.Controls.Add(this.Gender);
            this.panel1.Controls.Add(this.Address);
            this.panel1.Controls.Add(this.Age);
            this.panel1.Controls.Add(this.Name);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 323);
            this.panel1.TabIndex = 1;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.SandyBrown;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(741, 260);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(116, 42);
            this.btnclear.TabIndex = 14;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.SandyBrown;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(1038, 260);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(116, 42);
            this.Back.TabIndex = 13;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.SandyBrown;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(892, 260);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(116, 42);
            this.Delete.TabIndex = 12;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // bloodgroupcombo
            // 
            this.bloodgroupcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bloodgroupcombo.FormattingEnabled = true;
            this.bloodgroupcombo.Items.AddRange(new object[] {
            "",
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.bloodgroupcombo.Location = new System.Drawing.Point(767, 113);
            this.bloodgroupcombo.Name = "bloodgroupcombo";
            this.bloodgroupcombo.Size = new System.Drawing.Size(143, 28);
            this.bloodgroupcombo.TabIndex = 11;
            // 
            // gendercombo
            // 
            this.gendercombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gendercombo.FormattingEnabled = true;
            this.gendercombo.Items.AddRange(new object[] {
            "",
            "Male",
            "Female",
            "other"});
            this.gendercombo.Location = new System.Drawing.Point(767, 29);
            this.gendercombo.Name = "gendercombo";
            this.gendercombo.Size = new System.Drawing.Size(143, 28);
            this.gendercombo.TabIndex = 10;
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(225, 258);
            this.addresstxt.Multiline = true;
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(192, 36);
            this.addresstxt.TabIndex = 9;
            // 
            // agetxt
            // 
            this.agetxt.Location = new System.Drawing.Point(225, 176);
            this.agetxt.Multiline = true;
            this.agetxt.Name = "agetxt";
            this.agetxt.Size = new System.Drawing.Size(192, 40);
            this.agetxt.TabIndex = 8;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(225, 103);
            this.nametxt.Multiline = true;
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(192, 38);
            this.nametxt.TabIndex = 7;
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(225, 34);
            this.idtxt.Multiline = true;
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(192, 38);
            this.idtxt.TabIndex = 6;
            // 
            // Bloodgroup
            // 
            this.Bloodgroup.AutoSize = true;
            this.Bloodgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bloodgroup.Location = new System.Drawing.Point(561, 109);
            this.Bloodgroup.Name = "Bloodgroup";
            this.Bloodgroup.Size = new System.Drawing.Size(186, 32);
            this.Bloodgroup.TabIndex = 5;
            this.Bloodgroup.Text = "Blood Group";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(561, 29);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(116, 32);
            this.Gender.TabIndex = 4;
            this.Gender.Text = "Gender";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(21, 251);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(126, 32);
            this.Address.TabIndex = 3;
            this.Address.Text = "Address";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.Location = new System.Drawing.Point(21, 176);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(69, 32);
            this.Age.TabIndex = 2;
            this.Age.Text = "Age";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(21, 97);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(94, 32);
            this.Name.TabIndex = 1;
            this.Name.Text = "Name";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(21, 29);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(44, 32);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            // 
            // Deletedata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
           /* this.Name = "Deletedata";*/
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deletedata";
            this.Load += new System.EventHandler(this.Deletedata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Bloodgroup;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.ComboBox bloodgroupcombo;
        private System.Windows.Forms.ComboBox gendercombo;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.TextBox agetxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button btnclear;
    }
}