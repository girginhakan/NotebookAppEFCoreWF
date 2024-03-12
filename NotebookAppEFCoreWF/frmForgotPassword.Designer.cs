namespace NotebookAppEFCoreWF
{
    partial class frmForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForgotPassword));
            txtFPUsername = new TextBox();
            txtFPSecretAnswer = new TextBox();
            btnLogin = new Button();
            btnHome = new Button();
            SuspendLayout();
            // 
            // txtFPUsername
            // 
            txtFPUsername.BackColor = Color.Silver;
            txtFPUsername.ImeMode = ImeMode.NoControl;
            txtFPUsername.Location = new Point(61, 70);
            txtFPUsername.Name = "txtFPUsername";
            txtFPUsername.PlaceholderText = "Username";
            txtFPUsername.Size = new Size(253, 27);
            txtFPUsername.TabIndex = 2;
            // 
            // txtFPSecretAnswer
            // 
            txtFPSecretAnswer.BackColor = Color.Silver;
            txtFPSecretAnswer.ImeMode = ImeMode.NoControl;
            txtFPSecretAnswer.Location = new Point(61, 118);
            txtFPSecretAnswer.Name = "txtFPSecretAnswer";
            txtFPSecretAnswer.PlaceholderText = "Secret Answer";
            txtFPSecretAnswer.Size = new Size(253, 27);
            txtFPSecretAnswer.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ControlLight;
            btnLogin.BackgroundImage = (Image)resources.GetObject("btnLogin.BackgroundImage");
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(64, 64, 64);
            btnLogin.Location = new Point(61, 168);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(253, 42);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "NEW PASSWORD";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.ControlLight;
            btnHome.BackgroundImage = (Image)resources.GetObject("btnHome.BackgroundImage");
            btnHome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.FromArgb(64, 64, 64);
            btnHome.Location = new Point(61, 232);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(253, 42);
            btnHome.TabIndex = 5;
            btnHome.Text = "HOME";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // frmForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(394, 354);
            Controls.Add(btnHome);
            Controls.Add(btnLogin);
            Controls.Add(txtFPSecretAnswer);
            Controls.Add(txtFPUsername);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmForgotPassword";
            Text = "frmForgotPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFPUsername;
        private TextBox txtFPSecretAnswer;
        private Button btnLogin;
        private Button btnHome;
    }
}