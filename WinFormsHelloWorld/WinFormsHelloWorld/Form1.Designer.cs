namespace WinFormsHelloWorld
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
            maskedTextBoxshowhello = new MaskedTextBox();
            buttonsayhello = new Button();
            SuspendLayout();
            // 
            // maskedTextBoxshowhello
            // 
            maskedTextBoxshowhello.Location = new Point(12, 21);
            maskedTextBoxshowhello.Name = "maskedTextBoxshowhello";
            maskedTextBoxshowhello.Size = new Size(327, 23);
            maskedTextBoxshowhello.TabIndex = 0;
            maskedTextBoxshowhello.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            maskedTextBoxshowhello.Click += maskedTextBoxshowhello_Click;
            // 
            // buttonsayhello
            // 
            buttonsayhello.Location = new Point(12, 50);
            buttonsayhello.Name = "buttonsayhello";
            buttonsayhello.Size = new Size(126, 68);
            buttonsayhello.TabIndex = 1;
            buttonsayhello.Text = "Click ME";
            buttonsayhello.UseVisualStyleBackColor = true;
            buttonsayhello.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 354);
            Controls.Add(buttonsayhello);
            Controls.Add(maskedTextBoxshowhello);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBoxshowhello;
        private Button buttonsayhello;
    }
}
