namespace StarCut_Forms.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtUser = new TextBox();
            label2 = new Label();
            pnlBorda = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlBorda.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft New Tai Lue", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(28, 47);
            label1.Name = "label1";
            label1.Size = new Size(333, 38);
            label1.TabIndex = 0;
            label1.Text = "Bem-Vindo ao StarCut!";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.StarCut_Logo;
            pictureBox1.Location = new Point(403, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(376, 324);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(46, 35, 90);
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Dock = DockStyle.Fill;
            txtUser.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.ForeColor = SystemColors.ScrollBar;
            txtUser.Location = new Point(1, 1);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(298, 33);
            txtUser.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(28, 128);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 3;
            label2.Text = "Usuário:";
            // 
            // pnlBorda
            // 
            pnlBorda.BackColor = Color.FromArgb(106, 13, 173);
            pnlBorda.Controls.Add(txtUser);
            pnlBorda.Location = new Point(28, 148);
            pnlBorda.Name = "pnlBorda";
            pnlBorda.Padding = new Padding(1);
            pnlBorda.Size = new Size(300, 35);
            pnlBorda.TabIndex = 4;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 10, 61);
            ClientSize = new Size(800, 450);
            Controls.Add(pnlBorda);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StarCut";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlBorda.ResumeLayout(false);
            pnlBorda.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtUser;
        private Label label2;
        private Panel pnlBorda;
    }
}