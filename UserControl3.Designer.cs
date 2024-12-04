namespace Restaurant_Project
{
    partial class UserControl3
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
            label2 = new Label();
            minbutton = new Guna.UI2.WinForms.Guna2ImageButton();
            plusbutton = new Guna.UI2.WinForms.Guna2ImageButton();
            Count = new Label();
            label1 = new Label();
            CatName = new Label();
            FName = new Label();
            money = new Label();
            Fprice = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(guna2PictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(201, 118);
            panel1.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackgroundImage = Properties.Resources.pngwing1;
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.Image = Properties.Resources.pngwing2;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(-3, 0);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(198, 122);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox1.TabIndex = 0;
            guna2PictureBox1.TabStop = false;
            guna2PictureBox1.Click += guna2PictureBox1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe Print", 9.6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 151);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 1;
            label2.Text = "Name :";
            label2.Click += catname_Click;
            // 
            // minbutton
            // 
            minbutton.CheckedState.ImageSize = new Size(64, 64);
            minbutton.HoverState.ImageSize = new Size(64, 64);
            minbutton.Image = Properties.Resources.pngwing_com__4_;
            minbutton.ImageOffset = new Point(0, 0);
            minbutton.ImageRotate = 0F;
            minbutton.ImageSize = new Size(35, 35);
            minbutton.Location = new Point(22, 179);
            minbutton.Name = "minbutton";
            minbutton.PressedState.ImageSize = new Size(64, 64);
            minbutton.ShadowDecoration.CustomizableEdges = customizableEdges3;
            minbutton.Size = new Size(30, 30);
            minbutton.TabIndex = 4;
            minbutton.Click += minbutton_Click;
            // 
            // plusbutton
            // 
            plusbutton.CheckedState.ImageSize = new Size(64, 64);
            plusbutton.HoverState.ImageSize = new Size(64, 64);
            plusbutton.Image = Properties.Resources.pngwing_com__2_;
            plusbutton.ImageOffset = new Point(0, 0);
            plusbutton.ImageRotate = 0F;
            plusbutton.ImageSize = new Size(30, 30);
            plusbutton.Location = new Point(132, 179);
            plusbutton.Name = "plusbutton";
            plusbutton.PressedState.ImageSize = new Size(64, 64);
            plusbutton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            plusbutton.Size = new Size(30, 30);
            plusbutton.TabIndex = 5;
            plusbutton.Click += plusbutton_Click;
            // 
            // Count
            // 
            Count.BorderStyle = BorderStyle.Fixed3D;
            Count.Location = new Point(58, 179);
            Count.Name = "Count";
            Count.Size = new Size(68, 30);
            Count.TabIndex = 6;
            Count.Text = "0";
            Count.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe Print", 6.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 125);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 7;
            label1.Text = "Category :";
            // 
            // CatName
            // 
            CatName.Font = new Font("Segoe Print", 7.5F);
            CatName.Location = new Point(71, 125);
            CatName.Name = "CatName";
            CatName.Size = new Size(118, 25);
            CatName.TabIndex = 8;
            // 
            // FName
            // 
            FName.Font = new Font("Segoe Print", 7.5F);
            FName.Location = new Point(71, 151);
            FName.Name = "FName";
            FName.Size = new Size(128, 25);
            FName.TabIndex = 9;
            // 
            // money
            // 
            money.Font = new Font("Segoe UI Symbol", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            money.ForeColor = Color.DarkGreen;
            money.Location = new Point(116, 211);
            money.Name = "money";
            money.Size = new Size(73, 57);
            money.TabIndex = 10;
            money.Text = "$";
            money.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Fprice
            // 
            Fprice.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Fprice.Location = new Point(44, 218);
            Fprice.Name = "Fprice";
            Fprice.Size = new Size(91, 44);
            Fprice.TabIndex = 11;
            Fprice.Text = "123";
            Fprice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserControl3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(Fprice);
            Controls.Add(money);
            Controls.Add(FName);
            Controls.Add(CatName);
            Controls.Add(label1);
            Controls.Add(Count);
            Controls.Add(plusbutton);
            Controls.Add(minbutton);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "UserControl3";
            Size = new Size(192, 269);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton minbutton;
        private Guna.UI2.WinForms.Guna2ImageButton plusbutton;
        private Label Count;
        private Label label1;
        private Label CatName;
        private Label FName;
        private Label money;
        private Label Fprice;
    }
}
