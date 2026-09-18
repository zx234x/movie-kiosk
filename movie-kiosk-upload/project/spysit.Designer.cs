namespace project
{
    partial class spysit
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
            label1 = new Label();
            btn_pha = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(200, 85);
            label1.Name = "label1";
            label1.Size = new Size(129, 50);
            label1.TabIndex = 0;
            label1.Text = "screen";
            // 
            // btn_pha
            // 
            btn_pha.Location = new Point(214, 413);
            btn_pha.Name = "btn_pha";
            btn_pha.Size = new Size(87, 40);
            btn_pha.TabIndex = 2;
            btn_pha.Text = "예매하기";
            btn_pha.UseVisualStyleBackColor = true;
            btn_pha.Click += btn_pha_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(162, 32);
            label2.Name = "label2";
            label2.Size = new Size(37, 30);
            label2.TabIndex = 0;
            label2.Text = "11";
            // 
            // spysit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OIP__1_;
            ClientSize = new Size(546, 481);
            Controls.Add(btn_pha);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "spysit";
            Text = "spysit";
            Load += spysit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_pha;
        private Label label2;
    }
}