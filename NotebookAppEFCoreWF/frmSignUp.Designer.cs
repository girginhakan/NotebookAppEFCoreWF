namespace NotebookAppEFCoreWF
{
    partial class frmSUSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSUSignUp));
            txtSUName = new TextBox();
            txtSUSurname = new TextBox();
            txtSUUsername = new TextBox();
            txtSUPassword = new TextBox();
            txtSecretAnswer = new TextBox();
            dtpSUBirthdate = new DateTimePicker();
            label1 = new Label();
            btnSUAddUser = new Button();
            btnHome = new Button();
            SuspendLayout();
            // 
            // txtSUName
            // 
            txtSUName.BackColor = Color.Silver;
            txtSUName.ImeMode = ImeMode.NoControl;
            txtSUName.Location = new Point(46, 84);
            txtSUName.Name = "txtSUName";
            txtSUName.PlaceholderText = "Name";
            txtSUName.Size = new Size(253, 27);
            txtSUName.TabIndex = 1;
            // 
            // txtSUSurname
            // 
            txtSUSurname.BackColor = Color.Silver;
            txtSUSurname.ImeMode = ImeMode.NoControl;
            txtSUSurname.Location = new Point(46, 126);
            txtSUSurname.Name = "txtSUSurname";
            txtSUSurname.PlaceholderText = "Surname";
            txtSUSurname.Size = new Size(253, 27);
            txtSUSurname.TabIndex = 2;
            // 
            // txtSUUsername
            // 
            txtSUUsername.BackColor = Color.Silver;
            txtSUUsername.ImeMode = ImeMode.NoControl;
            txtSUUsername.Location = new Point(46, 211);
            txtSUUsername.Name = "txtSUUsername";
            txtSUUsername.PlaceholderText = "Username";
            txtSUUsername.Size = new Size(253, 27);
            txtSUUsername.TabIndex = 3;
            // 
            // txtSUPassword
            // 
            txtSUPassword.BackColor = Color.Silver;
            txtSUPassword.ImeMode = ImeMode.NoControl;
            txtSUPassword.Location = new Point(46, 256);
            txtSUPassword.Name = "txtSUPassword";
            txtSUPassword.PlaceholderText = "Password";
            txtSUPassword.Size = new Size(253, 27);
            txtSUPassword.TabIndex = 4;
            // 
            // txtSecretAnswer
            // 
            txtSecretAnswer.BackColor = Color.Silver;
            txtSecretAnswer.ImeMode = ImeMode.NoControl;
            txtSecretAnswer.Location = new Point(46, 303);
            txtSecretAnswer.Name = "txtSecretAnswer";
            txtSecretAnswer.PlaceholderText = "Secret Answer";
            txtSecretAnswer.Size = new Size(253, 27);
            txtSecretAnswer.TabIndex = 5;
            // 
            // dtpSUBirthdate
            // 
            dtpSUBirthdate.Location = new Point(46, 168);
            dtpSUBirthdate.Name = "dtpSUBirthdate";
            dtpSUBirthdate.Size = new Size(253, 27);
            dtpSUBirthdate.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(136, 39);
            label1.TabIndex = 7;
            label1.Text = "SIGN UP";
            // 
            // btnSUAddUser
            // 
            btnSUAddUser.BackColor = SystemColors.ControlLight;
            btnSUAddUser.BackgroundImage = (Image)resources.GetObject("btnSUAddUser.BackgroundImage");
            btnSUAddUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSUAddUser.ForeColor = Color.FromArgb(64, 64, 64);
            btnSUAddUser.Location = new Point(46, 352);
            btnSUAddUser.Name = "btnSUAddUser";
            btnSUAddUser.Size = new Size(253, 42);
            btnSUAddUser.TabIndex = 8;
            btnSUAddUser.Text = "LOGIN";
            btnSUAddUser.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.ControlLight;
            btnHome.BackgroundImage = (Image)resources.GetObject("btnHome.BackgroundImage");
            btnHome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.FromArgb(64, 64, 64);
            btnHome.Location = new Point(46, 411);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(253, 42);
            btnHome.TabIndex = 9;
            btnHome.Text = "HOME";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // frmSUSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(380, 486);
            Controls.Add(btnHome);
            Controls.Add(btnSUAddUser);
            Controls.Add(label1);
            Controls.Add(dtpSUBirthdate);
            Controls.Add(txtSecretAnswer);
            Controls.Add(txtSUPassword);
            Controls.Add(txtSUUsername);
            Controls.Add(txtSUSurname);
            Controls.Add(txtSUName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSUSignUp";
            Text = "frmSignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSUName;
        private TextBox txtSUSurname;
        private TextBox txtSUUsername;
        private TextBox txtSUPassword;
        private TextBox txtSecretAnswer;
        private DateTimePicker dtpSUBirthdate;
        private Label label1;
        private Button btnSUAddUser;
        private Button btnHome;
    }
}