namespace ML.NET_Spam_Mail
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            InputBox = new TextBox();
            ResultLabel = new Label();
            SuspendLayout();
            // 
            // InputBox
            // 
            InputBox.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            InputBox.Location = new Point(12, 51);
            InputBox.Name = "InputBox";
            InputBox.Size = new Size(400, 39);
            InputBox.TabIndex = 0;
            InputBox.KeyDown += InputBox_KeyDown;
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Font = new Font("맑은 고딕", 16F);
            ResultLabel.Location = new Point(12, 257);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(107, 45);
            ResultLabel.TabIndex = 1;
            ResultLabel.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 450);
            Controls.Add(ResultLabel);
            Controls.Add(InputBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputBox;
        private Label ResultLabel;
    }
}
