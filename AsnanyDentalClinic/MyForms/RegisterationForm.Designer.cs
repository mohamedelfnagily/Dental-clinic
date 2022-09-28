namespace AsnanyDentalClinic.MyForms
{
    partial class RegisterationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterationForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.mobileNum = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.confirmPass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.registerationDataSet1 = new AsnanyDentalClinic.registerationDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerationDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = global::AsnanyDentalClinic.Properties.Resources.dentist;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(517, 510);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.userName.ForeColor = System.Drawing.Color.DimGray;
            this.userName.Location = new System.Drawing.Point(558, 55);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(396, 30);
            this.userName.TabIndex = 1;
            this.userName.Text = "User Name...";
            this.userName.Click += new System.EventHandler(this.userName_Click);
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.FirstName.ForeColor = System.Drawing.Color.DimGray;
            this.FirstName.Location = new System.Drawing.Point(558, 111);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(396, 30);
            this.FirstName.TabIndex = 2;
            this.FirstName.Text = "First Name...";
            this.FirstName.Click += new System.EventHandler(this.userName_Click);
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lastName.ForeColor = System.Drawing.Color.DimGray;
            this.lastName.Location = new System.Drawing.Point(558, 166);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(396, 30);
            this.lastName.TabIndex = 3;
            this.lastName.Text = "Last Name...";
            this.lastName.Click += new System.EventHandler(this.userName_Click);
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Email.ForeColor = System.Drawing.Color.DimGray;
            this.Email.Location = new System.Drawing.Point(558, 223);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(396, 30);
            this.Email.TabIndex = 4;
            this.Email.Text = "Email...";
            this.Email.Click += new System.EventHandler(this.userName_Click);
            // 
            // mobileNum
            // 
            this.mobileNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.mobileNum.ForeColor = System.Drawing.Color.DimGray;
            this.mobileNum.Location = new System.Drawing.Point(558, 277);
            this.mobileNum.Name = "mobileNum";
            this.mobileNum.Size = new System.Drawing.Size(396, 30);
            this.mobileNum.TabIndex = 5;
            this.mobileNum.Text = "Mobile Number...";
            this.mobileNum.Click += new System.EventHandler(this.userName_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.password.ForeColor = System.Drawing.Color.DimGray;
            this.password.Location = new System.Drawing.Point(558, 332);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(396, 30);
            this.password.TabIndex = 6;
            this.password.Text = "Password...";
            this.password.Click += new System.EventHandler(this.userName_Click);
            // 
            // confirmPass
            // 
            this.confirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.confirmPass.ForeColor = System.Drawing.Color.DimGray;
            this.confirmPass.Location = new System.Drawing.Point(558, 386);
            this.confirmPass.Name = "confirmPass";
            this.confirmPass.Size = new System.Drawing.Size(396, 30);
            this.confirmPass.TabIndex = 7;
            this.confirmPass.Text = "Confirm Password...";
            this.confirmPass.Click += new System.EventHandler(this.userName_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(663, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::AsnanyDentalClinic.Properties.Resources.close2;
            this.pictureBox2.Location = new System.Drawing.Point(963, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT patientId, firstName, lastName, mobileNumber, email, userName, password\r\nF" +
    "ROM     patient";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=Asnany;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@patientId", System.Data.SqlDbType.Int, 0, "patientId"),
            new System.Data.SqlClient.SqlParameter("@firstName", System.Data.SqlDbType.NVarChar, 0, "firstName"),
            new System.Data.SqlClient.SqlParameter("@lastName", System.Data.SqlDbType.NVarChar, 0, "lastName"),
            new System.Data.SqlClient.SqlParameter("@mobileNumber", System.Data.SqlDbType.BigInt, 0, "mobileNumber"),
            new System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.NVarChar, 0, "email"),
            new System.Data.SqlClient.SqlParameter("@userName", System.Data.SqlDbType.NVarChar, 0, "userName"),
            new System.Data.SqlClient.SqlParameter("@password", System.Data.SqlDbType.NVarChar, 0, "password")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@patientId", System.Data.SqlDbType.Int, 0, "patientId"),
            new System.Data.SqlClient.SqlParameter("@firstName", System.Data.SqlDbType.NVarChar, 0, "firstName"),
            new System.Data.SqlClient.SqlParameter("@lastName", System.Data.SqlDbType.NVarChar, 0, "lastName"),
            new System.Data.SqlClient.SqlParameter("@mobileNumber", System.Data.SqlDbType.BigInt, 0, "mobileNumber"),
            new System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.NVarChar, 0, "email"),
            new System.Data.SqlClient.SqlParameter("@userName", System.Data.SqlDbType.NVarChar, 0, "userName"),
            new System.Data.SqlClient.SqlParameter("@password", System.Data.SqlDbType.NVarChar, 0, "password"),
            new System.Data.SqlClient.SqlParameter("@Original_patientId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "patientId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_firstName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "firstName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_lastName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lastName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_mobileNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "mobileNumber", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_mobileNumber", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "mobileNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_email", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "email", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_userName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "userName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_password", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "password", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_patientId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "patientId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_firstName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "firstName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_lastName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lastName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_mobileNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "mobileNumber", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_mobileNumber", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "mobileNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_email", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "email", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_userName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "userName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_password", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "password", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "patient", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("patientId", "patientId"),
                        new System.Data.Common.DataColumnMapping("firstName", "firstName"),
                        new System.Data.Common.DataColumnMapping("lastName", "lastName"),
                        new System.Data.Common.DataColumnMapping("mobileNumber", "mobileNumber"),
                        new System.Data.Common.DataColumnMapping("email", "email"),
                        new System.Data.Common.DataColumnMapping("userName", "userName"),
                        new System.Data.Common.DataColumnMapping("password", "password")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // registerationDataSet1
            // 
            this.registerationDataSet1.DataSetName = "registerationDataSet";
            this.registerationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RegisterationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1005, 510);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.confirmPass);
            this.Controls.Add(this.password);
            this.Controls.Add(this.mobileNum);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterationForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerationDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox mobileNum;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox confirmPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private registerationDataSet registerationDataSet1;
    }
}