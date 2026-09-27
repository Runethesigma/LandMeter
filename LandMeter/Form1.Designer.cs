namespace LandMeter
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
            label1 = new Label();
            BerekenButton = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            HoekATextBox = new TextBox();
            HoekCTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(351, 25);
            label1.TabIndex = 0;
            label1.Text = "Afstand tussen twee punten berekenen:";
            // 
            // BerekenButton
            // 
            BerekenButton.Location = new Point(67, 103);
            BerekenButton.Name = "BerekenButton";
            BerekenButton.Size = new Size(100, 23);
            BerekenButton.TabIndex = 1;
            BerekenButton.Text = "Bereken";
            BerekenButton.UseVisualStyleBackColor = true;
            BerekenButton.Click += BerekenButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "Hoek A:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 77);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 3;
            label3.Text = "Hoek C:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(173, 45);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 4;
            label4.Text = "graden";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(173, 77);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 5;
            label5.Text = "graden";
            // 
            // HoekATextBox
            // 
            HoekATextBox.Location = new Point(67, 42);
            HoekATextBox.Name = "HoekATextBox";
            HoekATextBox.Size = new Size(100, 23);
            HoekATextBox.TabIndex = 6;
            // 
            // HoekCTextBox
            // 
            HoekCTextBox.Location = new Point(67, 74);
            HoekCTextBox.Name = "HoekCTextBox";
            HoekCTextBox.Size = new Size(100, 23);
            HoekCTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 149);
            Controls.Add(HoekCTextBox);
            Controls.Add(HoekATextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BerekenButton);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BerekenButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox HoekATextBox;
        private TextBox HoekCTextBox;
    }
}
