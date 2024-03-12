namespace NotebookAppEFCoreWF
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            BottomToolStripPanel = new ToolStripPanel();
            TopToolStripPanel = new ToolStripPanel();
            RightToolStripPanel = new ToolStripPanel();
            LeftToolStripPanel = new ToolStripPanel();
            ContentPanel = new ToolStripContentPanel();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            lblExit = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            BottomToolStripPanel.Location = new Point(0, 0);
            BottomToolStripPanel.Name = "BottomToolStripPanel";
            BottomToolStripPanel.Orientation = Orientation.Horizontal;
            BottomToolStripPanel.RowMargin = new Padding(4, 0, 0, 0);
            BottomToolStripPanel.Size = new Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            TopToolStripPanel.Location = new Point(0, 0);
            TopToolStripPanel.Name = "TopToolStripPanel";
            TopToolStripPanel.Orientation = Orientation.Horizontal;
            TopToolStripPanel.RowMargin = new Padding(4, 0, 0, 0);
            TopToolStripPanel.Size = new Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            RightToolStripPanel.Location = new Point(0, 0);
            RightToolStripPanel.Name = "RightToolStripPanel";
            RightToolStripPanel.Orientation = Orientation.Horizontal;
            RightToolStripPanel.RowMargin = new Padding(4, 0, 0, 0);
            RightToolStripPanel.Size = new Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            LeftToolStripPanel.Location = new Point(0, 0);
            LeftToolStripPanel.Name = "LeftToolStripPanel";
            LeftToolStripPanel.Orientation = Orientation.Horizontal;
            LeftToolStripPanel.RowMargin = new Padding(4, 0, 0, 0);
            LeftToolStripPanel.Size = new Size(0, 0);
            // 
            // ContentPanel
            // 
            ContentPanel.Size = new Size(188, 106);
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Silver;
            txtUsername.ImeMode = ImeMode.NoControl;
            txtUsername.Location = new Point(122, 258);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(402, 27);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Silver;
            txtPassword.ImeMode = ImeMode.NoControl;
            txtPassword.Location = new Point(122, 304);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(402, 27);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ControlLight;
            btnLogin.BackgroundImage = (Image)resources.GetObject("btnLogin.BackgroundImage");
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(64, 64, 64);
            btnLogin.Location = new Point(122, 362);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(402, 42);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(64, 64, 64);
            button1.Location = new Point(360, 425);
            button1.Name = "button1";
            button1.Size = new Size(164, 42);
            button1.TabIndex = 4;
            button1.Text = "SIGN UP";
            button1.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = SystemColors.GrayText;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.FromArgb(192, 255, 192);
            linkLabel1.Location = new Point(122, 439);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(198, 28);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "I forgot my password";
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.BackColor = Color.Silver;
            lblExit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExit.Location = new Point(647, 9);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(24, 28);
            lblExit.TabIndex = 6;
            lblExit.Text = "X";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(96, 146);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(8, 8);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(683, 553);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lblExit);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripPanel BottomToolStripPanel;
        private ToolStripPanel TopToolStripPanel;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private ToolStripContentPanel ContentPanel;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label lblExit;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
