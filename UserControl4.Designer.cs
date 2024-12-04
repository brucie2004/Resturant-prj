namespace Restaurant_Project
{
    partial class UserControl4
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
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            orderId = new Label();
            datetime = new Label();
            label2 = new Label();
            label1 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 113);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon_order_1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 114);
            panel2.Name = "panel2";
            panel2.Size = new Size(205, 110);
            panel2.TabIndex = 1;
            // 
            // orderId
            // 
            orderId.BorderStyle = BorderStyle.Fixed3D;
            orderId.Font = new Font("Segoe Print", 6.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderId.Location = new Point(80, 116);
            orderId.Name = "orderId";
            orderId.Size = new Size(118, 25);
            orderId.TabIndex = 10;
            orderId.Click += CatName_Click;
            // 
            // datetime
            // 
            datetime.BorderStyle = BorderStyle.Fixed3D;
            datetime.Font = new Font("Segoe Print", 6.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datetime.Location = new Point(81, 150);
            datetime.Name = "datetime";
            datetime.Size = new Size(118, 25);
            datetime.TabIndex = 11;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe Print", 9.6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 116);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 12;
            label2.Text = "Order :";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe Print", 9.6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 150);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 13;
            label1.Text = "Date :";
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Navy;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(0, 189);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(101, 35);
            guna2Button1.TabIndex = 14;
            guna2Button1.Text = "Details";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.CustomizableEdges = customizableEdges3;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.Navy;
            guna2Button2.Font = new Font("Segoe UI", 9F);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(101, 189);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button2.Size = new Size(101, 35);
            guna2Button2.TabIndex = 15;
            guna2Button2.Text = "Done";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // UserControl4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(datetime);
            Controls.Add(orderId);
            Controls.Add(panel1);
            Name = "UserControl4";
            Size = new Size(202, 224);
            Load += UserControl4_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label orderId;
        private Label datetime;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private PictureBox pictureBox1;
    }
}
