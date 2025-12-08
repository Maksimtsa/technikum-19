namespace Matematyka
{
    partial class Geometria
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
            label2 = new Label();
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            button = new Button();
            label3 = new Label();
            textBoxResult = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 48);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "bok a";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 95);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "bok  b";
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(91, 45);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(100, 23);
            textBoxA.TabIndex = 2;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(91, 92);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(100, 23);
            textBoxB.TabIndex = 3;
            // 
            // button
            // 
            button.Location = new Point(91, 167);
            button.Name = "button";
            button.Size = new Size(75, 23);
            button.TabIndex = 4;
            button.Text = "Oblicz";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 222);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 5;
            label3.Text = "pole";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(91, 222);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(100, 23);
            textBoxResult.TabIndex = 6;
            // 
            // Geometria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxResult);
            Controls.Add(label3);
            Controls.Add(button);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Geometria";
            Text = "Geometria";
            FormClosed += Geometria_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxA;
        private TextBox textBoxB;
        private Button button;
        private Label label3;
        private TextBox textBoxResult;
    }
}