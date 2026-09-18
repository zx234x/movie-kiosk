namespace project
{
    partial class mocal
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
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            domainUpDown1 = new DomainUpDown();
            btResult = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            button2 = new Button();
            label6 = new Label();
            sitInfo = new Label();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            agree = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(305, 157);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(494, 219);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 1;
            label2.Text = "어린이";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(494, 154);
            label1.Name = "label1";
            label1.Size = new Size(42, 21);
            label1.TabIndex = 1;
            label1.Text = "성인";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(497, 187);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "16000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(497, 252);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 2;
            label4.Text = "10000";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Location = new Point(30, 131);
            button1.Name = "button1";
            button1.Size = new Size(95, 49);
            button1.TabIndex = 3;
            button1.Text = "인원 추가";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Items.Add("성인");
            domainUpDown1.Items.Add("어린이");
            domainUpDown1.Location = new Point(146, 157);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(120, 23);
            domainUpDown1.TabIndex = 4;
            // 
            // btResult
            // 
            btResult.BackColor = Color.LightCoral;
            btResult.Location = new Point(30, 238);
            btResult.Name = "btResult";
            btResult.Size = new Size(95, 49);
            btResult.TabIndex = 5;
            btResult.Text = "결과";
            btResult.UseVisualStyleBackColor = false;
            btResult.Click += btResult_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 252);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 23);
            textBox1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(24, 499);
            label5.Name = "label5";
            label5.Size = new Size(74, 21);
            label5.TabIndex = 7;
            label5.Text = "결제방법";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "신용카드", "무통장입금", "포인트" });
            comboBox1.Location = new Point(117, 496);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(266, 496);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(162, 64);
            listBox1.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCoral;
            button2.Location = new Point(472, 496);
            button2.Name = "button2";
            button2.Size = new Size(82, 47);
            button2.TabIndex = 10;
            button2.Text = "결제하기";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("맑은 고딕", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(146, 21);
            label6.Name = "label6";
            label6.Size = new Size(301, 47);
            label6.TabIndex = 11;
            label6.Text = "결제 및 예매 확인";
            // 
            // sitInfo
            // 
            sitInfo.AutoSize = true;
            sitInfo.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sitInfo.Location = new Point(175, 98);
            sitInfo.Name = "sitInfo";
            sitInfo.Size = new Size(0, 21);
            sitInfo.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(30, 348);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(271, 100);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "예매 취소 및 환불 동의";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(18, 51);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(169, 19);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "위 내용에 확인 하였습니다";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // agree
            // 
            agree.Location = new Point(329, 391);
            agree.Name = "agree";
            agree.Size = new Size(84, 34);
            agree.TabIndex = 14;
            agree.Text = "동의하기";
            agree.UseVisualStyleBackColor = true;
            agree.Click += agree_Click;
            // 
            // mocal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OIP__1_;
            ClientSize = new Size(594, 643);
            Controls.Add(agree);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(btResult);
            Controls.Add(domainUpDown1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(sitInfo);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Name = "mocal";
            Load += mocal_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button button1;
        private DomainUpDown domainUpDown1;
        private Button btResult;
        private TextBox textBox1;
        private Label label5;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private Button button2;
        private Label label6;
        private Label sitInfo;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private Button agree;
    }
}