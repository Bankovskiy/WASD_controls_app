namespace WASD_controls_app
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
            hero = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)hero).BeginInit();
            SuspendLayout();
            // 
            // hero
            // 
            hero.BackColor = Color.LightGreen;
            hero.Location = new Point(517, 281);
            hero.Name = "hero";
            hero.Size = new Size(100, 100);
            hero.TabIndex = 0;
            hero.TabStop = false;
            hero.Click += hero_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1162, 694);
            Controls.Add(hero);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)hero).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox hero;
    }
}