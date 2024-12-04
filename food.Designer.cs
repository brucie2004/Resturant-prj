namespace Restaurant_Project
{
    partial class food
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1059, 599);
            panel1.TabIndex = 0;
            panel1.TabStop = true;
            // 
            // guna2Button1
            // 
            guna2Button1.AutoRoundedCorners = true;
            guna2Button1.BorderRadius = 27;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.BlueViolet;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(418, 605);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(225, 56);
            guna2Button1.TabIndex = 1;
            guna2Button1.Text = "Manage Food";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // food
            // 
            AutoScaleDimensions = new SizeF(13F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1056, 679);
            Controls.Add(guna2Button1);
            Controls.Add(panel1);
            Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "food";
            StartPosition = FormStartPosition.CenterScreen;
            Load += emp_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}