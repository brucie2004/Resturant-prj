namespace Restaurant_Project
{
    partial class Detailsfrm
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
            label1 = new Label();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            total = new Label();
            delivery = new Label();
            cont = new Label();
            type = new Label();
            accDate = new Label();
            ordeDate = new Label();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabl = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(128, 128, 255);
            label1.Font = new Font("Segoe Print", 22.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(-1, 1);
            label1.Name = "label1";
            label1.Size = new Size(433, 53);
            label1.TabIndex = 0;
            label1.Text = "Order Details";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.CustomizableEdges = customizableEdges1;
            guna2ControlBox1.FillColor = Color.Red;
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(376, 1);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ControlBox1.Size = new Size(56, 36);
            guna2ControlBox1.TabIndex = 7;
            guna2ControlBox1.Click += guna2ControlBox1_Click;
            // 
            // total
            // 
            total.BorderStyle = BorderStyle.Fixed3D;
            total.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            total.Location = new Point(289, 704);
            total.Name = "total";
            total.Size = new Size(116, 35);
            total.TabIndex = 17;
            // 
            // delivery
            // 
            delivery.BorderStyle = BorderStyle.Fixed3D;
            delivery.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delivery.Location = new Point(228, 180);
            delivery.Name = "delivery";
            delivery.Size = new Size(192, 31);
            delivery.TabIndex = 18;
            // 
            // cont
            // 
            cont.BorderStyle = BorderStyle.Fixed3D;
            cont.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cont.Location = new Point(170, 628);
            cont.Name = "cont";
            cont.Size = new Size(250, 36);
            cont.TabIndex = 19;
            // 
            // type
            // 
            type.BorderStyle = BorderStyle.Fixed3D;
            type.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            type.Location = new Point(130, 131);
            type.Name = "type";
            type.Size = new Size(164, 31);
            type.TabIndex = 20;
            // 
            // accDate
            // 
            accDate.BorderStyle = BorderStyle.Fixed3D;
            accDate.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accDate.Location = new Point(130, 94);
            accDate.Name = "accDate";
            accDate.Size = new Size(290, 31);
            accDate.TabIndex = 21;
            // 
            // ordeDate
            // 
            ordeDate.BorderStyle = BorderStyle.Fixed3D;
            ordeDate.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ordeDate.Location = new Point(130, 55);
            ordeDate.Name = "ordeDate";
            ordeDate.Size = new Size(290, 31);
            ordeDate.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Location = new Point(-1, 253);
            panel2.Name = "panel2";
            panel2.Size = new Size(433, 372);
            panel2.TabIndex = 16;
            // 
            // label7
            // 
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Segoe Print", 9F);
            label7.Location = new Point(9, 628);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(155, 36);
            label7.TabIndex = 15;
            label7.Text = "number of items :";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Segoe Print", 9F);
            label6.Location = new Point(159, 704);
            label6.Name = "label6";
            label6.Size = new Size(124, 35);
            label6.TabIndex = 14;
            label6.Text = "Grand Total :";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe Print", 9F);
            label5.Location = new Point(9, 175);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(216, 36);
            label5.TabIndex = 13;
            label5.Text = "delivery employer name :";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe Print", 9F);
            label4.Location = new Point(9, 131);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(109, 33);
            label4.TabIndex = 12;
            label4.Text = "type :";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe Print", 9F);
            label3.Location = new Point(9, 93);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(109, 32);
            label3.TabIndex = 11;
            label3.Text = "access date :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe Print", 9F);
            label2.Location = new Point(9, 54);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(106, 31);
            label2.TabIndex = 10;
            label2.Text = "order date :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabl
            // 
            tabl.BorderStyle = BorderStyle.Fixed3D;
            tabl.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabl.Location = new Point(130, 217);
            tabl.Name = "tabl";
            tabl.Size = new Size(290, 31);
            tabl.TabIndex = 24;
            // 
            // label11
            // 
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Font = new Font("Segoe Print", 9F);
            label11.Location = new Point(9, 217);
            label11.Margin = new Padding(0);
            label11.Name = "label11";
            label11.Size = new Size(109, 33);
            label11.TabIndex = 23;
            label11.Text = "Table :";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Detailsfrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(432, 748);
            Controls.Add(tabl);
            Controls.Add(label11);
            Controls.Add(total);
            Controls.Add(delivery);
            Controls.Add(cont);
            Controls.Add(type);
            Controls.Add(accDate);
            Controls.Add(ordeDate);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(guna2ControlBox1);
            Controls.Add(label1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Detailsfrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detailsfrm";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Label total;
        private Label delivery;
        private Label cont;
        private Label type;
        private Label accDate;
        private Label ordeDate;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label tabl;
        private Label label11;
    }
}