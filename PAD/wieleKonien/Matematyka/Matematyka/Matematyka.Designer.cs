namespace Matematyka
{
    partial class Matematyka
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
            buttonKalkulator = new Button();
            Geometria = new Button();
            SuspendLayout();
            // 
            // buttonKalkulator
            // 
            buttonKalkulator.Location = new Point(150, 133);
            buttonKalkulator.Name = "buttonKalkulator";
            buttonKalkulator.Size = new Size(75, 23);
            buttonKalkulator.TabIndex = 0;
            buttonKalkulator.Text = "Kalkulator";
            buttonKalkulator.UseVisualStyleBackColor = true;
            buttonKalkulator.Click += buttonKalkulator_Click;
            // 
            // Geometria
            // 
            Geometria.Location = new Point(291, 135);
            Geometria.Name = "Geometria";
            Geometria.Size = new Size(75, 23);
            Geometria.TabIndex = 1;
            Geometria.Text = "Geometria";
            Geometria.UseVisualStyleBackColor = true;
            Geometria.Click += Geometria_Click;
            // 
            // Matematyka
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Geometria);
            Controls.Add(buttonKalkulator);
            Name = "Matematyka";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonKalkulator;
        private Button Geometria;
    }
}
