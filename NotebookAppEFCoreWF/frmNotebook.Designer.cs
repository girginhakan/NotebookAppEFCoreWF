namespace NotebookAppEFCoreWF
{
    partial class frmNotebook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotebook));
            lblHosgeldinKisi = new Label();
            cmbCategories = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            btnYeniNotEkle = new Button();
            btnSeciliNotuSil = new Button();
            btnSeciliNotuDuzenle = new Button();
            SuspendLayout();
            // 
            // lblHosgeldinKisi
            // 
            lblHosgeldinKisi.BackColor = Color.Transparent;
            lblHosgeldinKisi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHosgeldinKisi.ForeColor = Color.FromArgb(64, 64, 64);
            lblHosgeldinKisi.Location = new Point(12, 9);
            lblHosgeldinKisi.Name = "lblHosgeldinKisi";
            lblHosgeldinKisi.Size = new Size(163, 60);
            lblHosgeldinKisi.TabIndex = 7;
            lblHosgeldinKisi.Text = "X";
            lblHosgeldinKisi.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbCategories
            // 
            cmbCategories.BackColor = Color.Gainsboro;
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(12, 125);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(223, 28);
            cmbCategories.TabIndex = 8;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(336, 9);
            label1.Name = "label1";
            label1.Size = new Size(393, 60);
            label1.TabIndex = 9;
            label1.Text = "NOTLARIM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(118, 29);
            label2.TabIndex = 10;
            label2.Text = "Kategoriler";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(336, 72);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(393, 341);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // btnYeniNotEkle
            // 
            btnYeniNotEkle.BackColor = SystemColors.ControlLight;
            btnYeniNotEkle.BackgroundImage = (Image)resources.GetObject("btnYeniNotEkle.BackgroundImage");
            btnYeniNotEkle.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnYeniNotEkle.ForeColor = Color.Green;
            btnYeniNotEkle.Location = new Point(12, 189);
            btnYeniNotEkle.Name = "btnYeniNotEkle";
            btnYeniNotEkle.Size = new Size(223, 42);
            btnYeniNotEkle.TabIndex = 12;
            btnYeniNotEkle.Text = "Yeni not ekle";
            btnYeniNotEkle.UseVisualStyleBackColor = false;
            // 
            // btnSeciliNotuSil
            // 
            btnSeciliNotuSil.BackColor = SystemColors.ControlLight;
            btnSeciliNotuSil.BackgroundImage = (Image)resources.GetObject("btnSeciliNotuSil.BackgroundImage");
            btnSeciliNotuSil.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeciliNotuSil.ForeColor = Color.FromArgb(192, 0, 0);
            btnSeciliNotuSil.Location = new Point(12, 250);
            btnSeciliNotuSil.Name = "btnSeciliNotuSil";
            btnSeciliNotuSil.Size = new Size(223, 42);
            btnSeciliNotuSil.TabIndex = 13;
            btnSeciliNotuSil.Text = "Seçili notu sil";
            btnSeciliNotuSil.UseVisualStyleBackColor = false;
            // 
            // btnSeciliNotuDuzenle
            // 
            btnSeciliNotuDuzenle.BackColor = SystemColors.ControlLight;
            btnSeciliNotuDuzenle.BackgroundImage = (Image)resources.GetObject("btnSeciliNotuDuzenle.BackgroundImage");
            btnSeciliNotuDuzenle.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeciliNotuDuzenle.ForeColor = Color.FromArgb(0, 0, 192);
            btnSeciliNotuDuzenle.Location = new Point(12, 311);
            btnSeciliNotuDuzenle.Name = "btnSeciliNotuDuzenle";
            btnSeciliNotuDuzenle.Size = new Size(223, 42);
            btnSeciliNotuDuzenle.TabIndex = 14;
            btnSeciliNotuDuzenle.Text = "Seçili notu düzenle";
            btnSeciliNotuDuzenle.UseVisualStyleBackColor = false;
            // 
            // frmNotebook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btnSeciliNotuDuzenle);
            Controls.Add(btnSeciliNotuSil);
            Controls.Add(btnYeniNotEkle);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbCategories);
            Controls.Add(lblHosgeldinKisi);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmNotebook";
            Text = "frmNotebook";
            ResumeLayout(false);
        }

        #endregion

        private Label lblHosgeldinKisi;
        private ComboBox cmbCategories;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBox1;
        private Button btnYeniNotEkle;
        private Button btnSeciliNotuSil;
        private Button btnSeciliNotuDuzenle;
    }
}