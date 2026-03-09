namespace _3
{
    partial class DaneKontaktowe
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBoxUlica = new TextBox();
            textBoxNumer = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            textBoxMsc = new TextBox();
            textBoxTel = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Ulica";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 34);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Numer domu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 60);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 2;
            label3.Text = "Kod pocztowy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 84);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 3;
            label4.Text = "Miejscowość";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 112);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 4;
            label5.Text = "Numer tel.";
            // 
            // button1
            // 
            button1.Location = new Point(12, 152);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Wstecz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(110, 152);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Dalej";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxUlica
            // 
            textBoxUlica.Location = new Point(110, 1);
            textBoxUlica.Name = "textBoxUlica";
            textBoxUlica.Size = new Size(100, 23);
            textBoxUlica.TabIndex = 7;
            // 
            // textBoxNumer
            // 
            textBoxNumer.Location = new Point(110, 28);
            textBoxNumer.Name = "textBoxNumer";
            textBoxNumer.Size = new Size(100, 23);
            textBoxNumer.TabIndex = 8;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(110, 57);
            maskedTextBox1.Mask = "00-000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 9;
            // 
            // textBoxMsc
            // 
            textBoxMsc.Location = new Point(110, 86);
            textBoxMsc.Name = "textBoxMsc";
            textBoxMsc.Size = new Size(100, 23);
            textBoxMsc.TabIndex = 10;
            // 
            // textBoxTel
            // 
            textBoxTel.Location = new Point(110, 112);
            textBoxTel.Name = "textBoxTel";
            textBoxTel.Size = new Size(100, 23);
            textBoxTel.TabIndex = 11;
            // 
            // DaneKontaktowe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxTel);
            Controls.Add(textBoxMsc);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBoxNumer);
            Controls.Add(textBoxUlica);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DaneKontaktowe";
            Text = "DaneKontaktowe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private TextBox textBoxUlica;
        private TextBox textBoxNumer;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBoxMsc;
        private TextBox textBoxTel;
    }
}