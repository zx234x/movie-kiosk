namespace project
{
    partial class hotic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hotic));
            comboBox1 = new ComboBox();
            pictureBox6 = new PictureBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "08/01", "08/02", "08/03", "08/04", "08/05" });
            comboBox1.Location = new Point(220, 81);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(74, 64);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(37, 37);
            pictureBox6.TabIndex = 7;
            pictureBox6.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(127, 76);
            label3.Name = "label3";
            label3.Size = new Size(50, 25);
            label3.TabIndex = 6;
            label3.Text = "호프";
            // 
            // button1
            // 
            button1.Location = new Point(69, 126);
            button1.Name = "button1";
            button1.Size = new Size(98, 45);
            button1.TabIndex = 8;
            button1.Text = "16:30";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(190, 126);
            button2.Name = "button2";
            button2.Size = new Size(98, 45);
            button2.TabIndex = 8;
            button2.Text = "18:30";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(312, 126);
            button3.Name = "button3";
            button3.Size = new Size(98, 45);
            button3.TabIndex = 8;
            button3.Text = "19:40";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(69, 186);
            button5.Name = "button5";
            button5.Size = new Size(98, 45);
            button5.TabIndex = 8;
            button5.Text = "21:20";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(190, 186);
            button6.Name = "button6";
            button6.Size = new Size(98, 45);
            button6.TabIndex = 8;
            button6.Text = "22:40";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.Location = new Point(312, 186);
            button4.Name = "button4";
            button4.Size = new Size(98, 45);
            button4.TabIndex = 8;
            button4.Text = "23:20";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // hotic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OIP__1_;
            ClientSize = new Size(481, 324);
            Controls.Add(button4);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox6);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Name = "hotic";
            Text = "hotic";
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private PictureBox pictureBox6;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button6;
        private Button button4;
    }
}