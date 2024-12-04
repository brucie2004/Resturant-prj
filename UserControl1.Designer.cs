namespace Restaurant_Project
{
    partial class UserControl1
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            label1 = new Label();
            label2 = new Label();
            Tlabel3 = new Label();
            Flabel4 = new Label();
            label5 = new Label();
            Slabel6 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(guna2PictureBox1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(201, 139);
            panel1.TabIndex = 1;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackColor = Color.FromArgb(128, 128, 255);
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.Image = Properties.Resources.pngegg__3_;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(3, 0);
            guna2PictureBox1.Margin = new Padding(0);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(198, 131);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox1.TabIndex = 0;
            guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe Print", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 142);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(74, 36);
            label1.TabIndex = 2;
            label1.Text = "Table : ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(192, 192, 255);
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe Print", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(98, 143);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(77, 36);
            label2.TabIndex = 2;
            label2.Text = "Floor : ";
            label2.Click += label1_Click;
            // 
            // Tlabel3
            // 
            Tlabel3.BorderStyle = BorderStyle.Fixed3D;
            Tlabel3.Font = new Font("Segoe UI", 8F);
            Tlabel3.Location = new Point(77, 149);
            Tlabel3.Name = "Tlabel3";
            Tlabel3.Size = new Size(18, 25);
            Tlabel3.TabIndex = 3;
            // 
            // Flabel4
            // 
            Flabel4.BorderStyle = BorderStyle.Fixed3D;
            Flabel4.Font = new Font("Segoe UI", 8F);
            Flabel4.Location = new Point(178, 149);
            Flabel4.Name = "Flabel4";
            Flabel4.Size = new Size(18, 25);
            Flabel4.TabIndex = 3;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(192, 192, 255);
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe Print", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(0, 184);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(74, 36);
            label5.TabIndex = 2;
            label5.Text = "state : ";
            label5.Click += label1_Click;
            // 
            // Slabel6
            // 
            Slabel6.BorderStyle = BorderStyle.Fixed3D;
            Slabel6.Font = new Font("Segoe Print", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Slabel6.Location = new Point(77, 189);
            Slabel6.Name = "Slabel6";
            Slabel6.Size = new Size(80, 25);
            Slabel6.TabIndex = 3;
            Slabel6.Text = "available";
            Slabel6.TextAlign = ContentAlignment.MiddleCenter;
            Slabel6.Click += label6_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(156, 182);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(44, 37);
            guna2Button1.TabIndex = 4;
            guna2Button1.Click += guna2Button1_Click_1;
            guna2Button1.DoubleClick += guna2Button1_DoubleClick;
            guna2Button1.MouseDoubleClick += guna2Button1_MouseDoubleClick;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            Controls.Add(guna2Button1);
            Controls.Add(Flabel4);
            Controls.Add(Slabel6);
            Controls.Add(Tlabel3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "UserControl1";
            Size = new Size(200, 222);
            Load += UserControl1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Label label1;
        private Label label2;
        private Label Tlabel3;
        private Label Flabel4;
        private Label label5;
        private Label Slabel6;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
