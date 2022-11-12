namespace Blood_Group_Management_System
{
    partial class AddRecord
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
            this.name = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.gendercombo = new System.Windows.Forms.ComboBox();
            this.bloodgrpcombo = new System.Windows.Forms.ComboBox();
            this.gender = new System.Windows.Forms.Label();
            this.bloodgroup = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.agetxt = new System.Windows.Forms.TextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.name.Location = new System.Drawing.Point(34, 77);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(85, 28);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.age.Location = new System.Drawing.Point(34, 138);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(61, 28);
            this.age.TabIndex = 1;
            this.age.Text = "Age";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.address.Location = new System.Drawing.Point(34, 205);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(116, 28);
            this.address.TabIndex = 2;
            this.address.Text = "Address";
            // 
            // gendercombo
            // 
            this.gendercombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gendercombo.FormattingEnabled = true;
            this.gendercombo.Items.AddRange(new object[] {
            "",
            "Male",
            "Female",
            "Others"});
            this.gendercombo.Location = new System.Drawing.Point(657, 51);
            this.gendercombo.Name = "gendercombo";
            this.gendercombo.Size = new System.Drawing.Size(181, 28);
            this.gendercombo.TabIndex = 7;
            // 
            // bloodgrpcombo
            // 
            this.bloodgrpcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bloodgrpcombo.FormattingEnabled = true;
            this.bloodgrpcombo.Items.AddRange(new object[] {
            "",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.bloodgrpcombo.Location = new System.Drawing.Point(657, 137);
            this.bloodgrpcombo.Name = "bloodgrpcombo";
            this.bloodgrpcombo.Size = new System.Drawing.Size(181, 28);
            this.bloodgrpcombo.TabIndex = 8;
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.gender.Location = new System.Drawing.Point(444, 51);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(104, 28);
            this.gender.TabIndex = 5;
            this.gender.Text = "Gender";
            // 
            // bloodgroup
            // 
            this.bloodgroup.AutoSize = true;
            this.bloodgroup.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.bloodgroup.Location = new System.Drawing.Point(444, 137);
            this.bloodgroup.Name = "bloodgroup";
            this.bloodgroup.Size = new System.Drawing.Size(172, 28);
            this.bloodgroup.TabIndex = 6;
            this.bloodgroup.Text = "Blood Group";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(213, 77);
            this.nametxt.Multiline = true;
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(181, 38);
            this.nametxt.TabIndex = 4;
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(213, 205);
            this.addresstxt.Multiline = true;
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(181, 38);
            this.addresstxt.TabIndex = 6;
            // 
            // agetxt
            // 
            this.agetxt.Location = new System.Drawing.Point(213, 138);
            this.agetxt.Multiline = true;
            this.agetxt.Name = "agetxt";
            this.agetxt.Size = new System.Drawing.Size(181, 38);
            this.agetxt.TabIndex = 5;
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.SandyBrown;
            this.savebtn.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.Location = new System.Drawing.Point(818, 241);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(111, 48);
            this.savebtn.TabIndex = 9;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(34, 18);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(44, 28);
            this.Id.TabIndex = 11;
            this.Id.Text = "ID";
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(213, 18);
            this.idtxt.Multiline = true;
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(181, 38);
            this.idtxt.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 338);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1184, 320);
            this.dataGridView1.TabIndex = 13;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.backbtn.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(975, 241);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(111, 48);
            this.backbtn.TabIndex = 14;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.bloodgrpcombo);
            this.panel1.Controls.Add(this.backbtn);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.age);
            this.panel1.Controls.Add(this.savebtn);
            this.panel1.Controls.Add(this.idtxt);
            this.panel1.Controls.Add(this.address);
            this.panel1.Controls.Add(this.Id);
            this.panel1.Controls.Add(this.gendercombo);
            this.panel1.Controls.Add(this.gender);
            this.panel1.Controls.Add(this.agetxt);
            this.panel1.Controls.Add(this.bloodgroup);
            this.panel1.Controls.Add(this.addresstxt);
            this.panel1.Controls.Add(this.nametxt);
            this.panel1.Location = new System.Drawing.Point(18, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 303);
            this.panel1.TabIndex = 15;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.SandyBrown;
            this.btnclear.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(666, 241);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(111, 48);
            this.btnclear.TabIndex = 15;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // AddRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 722);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRecord";
            this.Load += new System.EventHandler(this.AddRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.ComboBox gendercombo;
        private System.Windows.Forms.ComboBox bloodgrpcombo;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label bloodgroup;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.TextBox agetxt;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnclear;
    }
}