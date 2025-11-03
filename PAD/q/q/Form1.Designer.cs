namespace q
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxName = new TextBox();
            textBoxNazwisko = new TextBox();
            maskedTextBoxHaslo = new MaskedTextBox();
            maskedTextBoxKod = new MaskedTextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            richTextBox = new RichTextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 28);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Imię:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 54);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Nazwisko:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 80);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Haslo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 137);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 3;
            label4.Text = "Kod pocztowy:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 171);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 4;
            label5.Text = "Data urodzenia:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(137, 20);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 5;
            // 
            // textBoxNazwisko
            // 
            textBoxNazwisko.Location = new Point(137, 46);
            textBoxNazwisko.Name = "textBoxNazwisko";
            textBoxNazwisko.Size = new Size(100, 23);
            textBoxNazwisko.TabIndex = 6;
            // 
            // maskedTextBoxHaslo
            // 
            maskedTextBoxHaslo.Location = new Point(137, 75);
            maskedTextBoxHaslo.Name = "maskedTextBoxHaslo";
            maskedTextBoxHaslo.PasswordChar = '*';
            maskedTextBoxHaslo.Size = new Size(100, 23);
            maskedTextBoxHaslo.TabIndex = 7;
            // 
            // maskedTextBoxKod
            // 
            maskedTextBoxKod.Location = new Point(137, 129);
            maskedTextBoxKod.Mask = "00-000";
            maskedTextBoxKod.Name = "maskedTextBoxKod";
            maskedTextBoxKod.Size = new Size(100, 23);
            maskedTextBoxKod.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(137, 163);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(100, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(31, 219);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Zapisz";
            button1.UseVisualStyleBackColor = true;
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(322, 20);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(285, 145);
            richTextBox.TabIndex = 11;
            richTextBox.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 110);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 12;
            label6.Text = "Powtórz hasło:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(richTextBox);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(maskedTextBoxKod);
            Controls.Add(maskedTextBoxHaslo);
            Controls.Add(textBoxNazwisko);
            Controls.Add(textBoxName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxName;
        private TextBox textBoxNazwisko;
        private MaskedTextBox maskedTextBoxHaslo;
        private MaskedTextBox maskedTextBoxKod;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private RichTextBox richTextBox;
        private Label label6;
    }
}
