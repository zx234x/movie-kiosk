namespace project
{
    partial class spyticket
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
            pictureBox5 = new PictureBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources._12;
            pictureBox5.Location = new Point(68, 60);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(37, 37);
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(114, 67);
            label2.Name = "label2";
            label2.Size = new Size(265, 30);
            label2.TabIndex = 6;
            label2.Text = "스파이더맨 브랜드 뉴 데이";
            // 
            // button1
            // 
            button1.Location = new Point(68, 159);
            button1.Name = "button1";
            button1.Size = new Size(98, 45);
            button1.TabIndex = 8;
            button1.Text = "16:30";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(183, 159);
            button2.Name = "button2";
            button2.Size = new Size(98, 45);
            button2.TabIndex = 8;
            button2.Text = "18:00";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(297, 159);
            button3.Name = "button3";
            button3.Size = new Size(98, 45);
            button3.TabIndex = 8;
            button3.Text = "19:30";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            // 
            // button6
            // 
            button6.Location = new Point(297, 227);
            button6.Name = "button6";
            button6.Size = new Size(98, 45);
            button6.TabIndex = 8;
            button6.Text = "23:00";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button1_Click;
            // 
            // button7
            // 
            button7.Location = new Point(183, 227);
            button7.Name = "button7";
            button7.Size = new Size(98, 45);
            button7.TabIndex = 8;
            button7.Text = "22:30";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button1_Click;
            // 
            // button8
            // 
            button8.Location = new Point(68, 227);
            button8.Name = "button8";
            button8.Size = new Size(98, 45);
            button8.TabIndex = 8;
            button8.Text = "21:30";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "08/01", "08/02", "08/03", "08/04", "08/05" });
            comboBox1.Location = new Point(137, 118);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // spyticket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OIP__1_;
            ClientSize = new Size(481, 324);
            Controls.Add(comboBox1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox5);
            Controls.Add(label2);
            Name = "spyticket";
            Text = "spyticket";
            
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox5;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button6;
        private Button button7;
        private Button button8;
        private ComboBox comboBox1;
    }
}