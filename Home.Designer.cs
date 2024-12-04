namespace Restaurant_Project
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Font = new Font("Segoe Print", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(2, 9);
            label1.Name = "label1";
            label1.Size = new Size(545, 154);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Visible = false;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe Print", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(454, 156);
            label2.Name = "label2";
            label2.Size = new Size(102, 84);
            label2.TabIndex = 0;
            label2.Text = "To";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Visible = false;
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe Print", 45F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(196, 219);
            label3.Name = "label3";
            label3.Size = new Size(843, 175);
            label3.TabIndex = 0;
            label3.Text = "Our Table Services";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Visible = false;
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe Print", 35F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(183, 378);
            label4.Name = "label4";
            label4.Size = new Size(843, 121);
            label4.TabIndex = 0;
            label4.Text = "( Food and Drinks )";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Visible = false;
            label4.Click += label1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 350;
            timer1.Tick += timer1_Tick;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1038, 632);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}