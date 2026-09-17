
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
            label6 = new Label();
            button1 = new Button();
            agree = new Button();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            sitInfo = new Label();
            domainUpDown1 = new DomainUpDown();
            button2 = new Button();
            btResult = new Button();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.ForeColor = Color.Brown;
            button1.Location = new Point(41, 122);
            button1.Name = "button1";
            button1.Size = new Size(95, 49);
            button1.TabIndex = 21;
            button1.Text = "인원 추가";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // agree
            // 
            agree.ForeColor = Color.Brown;
            agree.Location = new Point(331, 381);
            agree.Name = "agree";
            agree.Size = new Size(84, 34);
            agree.TabIndex = 30;
            agree.Text = "동의하기";
            agree.UseVisualStyleBackColor = true;
            agree.Click += agree_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(460, 220);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 19;
            label4.Text = "10000";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(316, 148);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(460, 155);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 20;
            label3.Text = "16000";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(32, 338);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(271, 100);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "예매 취소 및 환불 동의";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.ForeColor = Color.Brown;
            radioButton1.Location = new Point(18, 51);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(169, 19);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "위 내용에 확인 하였습니다";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(457, 122);
            label1.Name = "label1";
            label1.Size = new Size(42, 21);
            label1.TabIndex = 16;
            label1.Text = "성인";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(457, 187);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 17;
            label2.Text = "어린이";
            // 
            // sitInfo
            // 
            sitInfo.AutoSize = true;
            sitInfo.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sitInfo.Location = new Point(186, 89);
            sitInfo.Name = "sitInfo";
            sitInfo.Size = new Size(0, 21);
            sitInfo.TabIndex = 18;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Items.Add("성인");
            domainUpDown1.Items.Add("어린이");
            domainUpDown1.Location = new Point(157, 148);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(120, 23);
            domainUpDown1.TabIndex = 22;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCoral;
            button2.ForeColor = Color.Brown;
            button2.Location = new Point(480, 489);
            button2.Name = "button2";
            button2.Size = new Size(82, 47);
            button2.TabIndex = 28;
            button2.Text = "결제하기";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // btResult
            // 
            btResult.BackColor = Color.LightCoral;
            btResult.ForeColor = Color.Brown;
            btResult.Location = new Point(41, 229);
            btResult.Name = "btResult";
            btResult.Size = new Size(95, 49);
            btResult.TabIndex = 23;
            btResult.Text = "결과";
            btResult.UseVisualStyleBackColor = false;
            btResult.Click += btResult_Click_1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(274, 489);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(162, 64);
            listBox1.TabIndex = 27;
            
            // 
            // textBox1
            // 
            textBox1.Location = new Point(157, 243);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 23);
            textBox1.TabIndex = 24;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "신용카드", "무통장입금", "포인트" });
            comboBox1.Location = new Point(125, 489);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 26;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(32, 492);
            label5.Name = "label5";
            label5.Size = new Size(74, 21);
            label5.TabIndex = 25;
            label5.Text = "결제방법";
            // 
            // mocal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OIP__1_;
            ClientSize = new Size(594, 643);
            Controls.Add(button1);
            Controls.Add(agree);
            Controls.Add(label4);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(sitInfo);
            Controls.Add(domainUpDown1);
            Controls.Add(button2);
            Controls.Add(btResult);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            Name = "mocal";
            Load += mocal_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private Label label6;
        private Button button1;
        private Button agree;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private Label label1;
        private Label label2;
        private Label sitInfo;
        private DomainUpDown domainUpDown1;
        private Button button2;
        private Button btResult;
        private ListBox listBox1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label5;
    }
}