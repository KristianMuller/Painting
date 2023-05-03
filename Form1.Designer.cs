namespace Painting
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
            btnRed = new Button();
            btnGreen = new Button();
            btnBlue = new Button();
            btnBlack = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // btnRed
            // 
            btnRed.Location = new Point(713, 12);
            btnRed.Name = "btnRed";
            btnRed.Size = new Size(75, 23);
            btnRed.TabIndex = 0;
            btnRed.UseVisualStyleBackColor = true;
            btnRed.Click += btnRed_Click;
            // 
            // btnGreen
            // 
            btnGreen.Location = new Point(713, 41);
            btnGreen.Name = "btnGreen";
            btnGreen.Size = new Size(75, 23);
            btnGreen.TabIndex = 1;
            btnGreen.UseVisualStyleBackColor = true;
            btnGreen.Click += btnGreen_Click;
            // 
            // btnBlue
            // 
            btnBlue.Location = new Point(713, 70);
            btnBlue.Name = "btnBlue";
            btnBlue.Size = new Size(75, 23);
            btnBlue.TabIndex = 2;
            btnBlue.UseVisualStyleBackColor = true;
            btnBlue.Click += btnBlue_Click;
            // 
            // btnBlack
            // 
            btnBlack.Location = new Point(713, 99);
            btnBlack.Name = "btnBlack";
            btnBlack.Size = new Size(75, 23);
            btnBlack.TabIndex = 3;
            btnBlack.UseVisualStyleBackColor = true;
            btnBlack.Click += btnBlack_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(713, 128);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnBlack);
            Controls.Add(btnBlue);
            Controls.Add(btnGreen);
            Controls.Add(btnRed);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRed;
        private Button btnGreen;
        private Button btnBlue;
        private Button btnBlack;
        public Button btnClear;
    }
}