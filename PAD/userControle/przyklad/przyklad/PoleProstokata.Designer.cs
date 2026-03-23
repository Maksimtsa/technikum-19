namespace przyklad
{
    partial class PoleProstokata
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 74);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Pole Prostokąta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 120);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 1;
            label2.Text = "A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 152);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 2;
            label3.Text = "B";
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(105, 112);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(100, 23);
            textBoxA.TabIndex = 3;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(105, 149);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(100, 23);
            textBoxB.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(75, 216);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "oblicz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 278);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 6;
            label4.Text = "Wynik";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(105, 280);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 7;
            // 
            // PoleProstokata
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PoleProstokata";
            Size = new Size(400, 400);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxA;
        private TextBox textBoxB;
        private Button button1;
        private Label label4;
        private Label label5;
    }
}
