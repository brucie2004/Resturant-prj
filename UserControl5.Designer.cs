namespace Restaurant_Project
{
    partial class UserControl5
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
            label2 = new Label();
            label1 = new Label();
            food = new Label();
            label4 = new Label();
            cnt = new Label();
            price = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = Color.Navy;
            label2.Font = new Font("Segoe Print", 11F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 50);
            label2.TabIndex = 2;
            label2.Text = "99";
            // 
            // label1
            // 
            label1.BackColor = Color.Navy;
            label1.Font = new Font("Segoe Print", 11F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(42, 0);
            label1.Name = "label1";
            label1.Size = new Size(20, 50);
            label1.TabIndex = 3;
            label1.Text = ".";
            // 
            // food
            // 
            food.BackColor = Color.Navy;
            food.Font = new Font("Segoe Print", 11F, FontStyle.Bold | FontStyle.Italic);
            food.ForeColor = Color.White;
            food.Location = new Point(55, 0);
            food.Name = "food";
            food.Size = new Size(160, 50);
            food.TabIndex = 4;
            food.Text = "Food Name";
            // 
            // label4
            // 
            label4.BackColor = Color.Navy;
            label4.Font = new Font("Segoe Print", 11F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.White;
            label4.Location = new Point(319, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 50);
            label4.TabIndex = 5;
            label4.Text = "N . ";
            // 
            // cnt
            // 
            cnt.BackColor = Color.Navy;
            cnt.Font = new Font("Segoe Print", 11F, FontStyle.Bold | FontStyle.Italic);
            cnt.ForeColor = Color.White;
            cnt.Location = new Point(370, 0);
            cnt.Name = "cnt";
            cnt.Size = new Size(60, 50);
            cnt.TabIndex = 6;
            cnt.Text = "100 . ";
            // 
            // price
            // 
            price.BackColor = Color.Navy;
            price.Font = new Font("Segoe Print", 8F, FontStyle.Bold | FontStyle.Italic);
            price.ForeColor = Color.White;
            price.Location = new Point(236, 5);
            price.Name = "price";
            price.Size = new Size(77, 45);
            price.TabIndex = 7;
            price.Text = "Food Name";
            // 
            // label5
            // 
            label5.BackColor = Color.Navy;
            label5.Font = new Font("Segoe Print", 8F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.White;
            label5.Location = new Point(212, 0);
            label5.Name = "label5";
            label5.Size = new Size(29, 50);
            label5.TabIndex = 8;
            label5.Text = "P .";
            // 
            // UserControl5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            Controls.Add(label5);
            Controls.Add(price);
            Controls.Add(cnt);
            Controls.Add(label4);
            Controls.Add(food);
            Controls.Add(label1);
            Controls.Add(label2);
            ForeColor = Color.White;
            Name = "UserControl5";
            Size = new Size(433, 50);
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label1;
        private Label food;
        private Label label4;
        private Label cnt;
        private Label price;
        private Label label5;
    }
}
