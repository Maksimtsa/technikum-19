namespace zad2
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
            textBox = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            buttonChange = new Button();
            textBoxResult = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Location = new Point(64, 38);
            textBox.Name = "textBox";
            textBox.Size = new Size(100, 23);
            textBox.TabIndex = 0;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(17, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(81, 19);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Fahrenheit";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(18, 63);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(57, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Kelvin";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(64, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(207, 109);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Wybór";
            // 
            // buttonChange
            // 
            buttonChange.Location = new Point(384, 132);
            buttonChange.Name = "buttonChange";
            buttonChange.Size = new Size(75, 23);
            buttonChange.TabIndex = 4;
            buttonChange.Text = "Zamień";
            buttonChange.UseVisualStyleBackColor = true;
            buttonChange.Click += buttonChange_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(74, 250);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(100, 23);
            textBoxResult.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxResult);
            Controls.Add(buttonChange);
            Controls.Add(groupBox1);
            Controls.Add(textBox);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private Button buttonChange;
        private TextBox textBoxResult;
    }
}
