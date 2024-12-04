namespace Restaurant_Project
{
    partial class orderfrm
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
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1056, 605);
            panel1.TabIndex = 0;
            panel1.TabStop = true;
            panel1.Paint += panel1_Paint;
            // 
            // guna2Button2
            // 
            guna2Button2.AutoRoundedCorners = true;
            guna2Button2.BorderRadius = 27;
            guna2Button2.CustomizableEdges = customizableEdges1;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.Navy;
            guna2Button2.Font = new Font("Segoe UI", 9F);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(417, 611);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button2.Size = new Size(225, 56);
            guna2Button2.TabIndex = 1;
            guna2Button2.Text = "Add Orders";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // orderfrm
            // 
            AutoScaleDimensions = new SizeF(13F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1056, 679);
            Controls.Add(guna2Button2);
            Controls.Add(panel1);
            Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "orderfrm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += tables_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}