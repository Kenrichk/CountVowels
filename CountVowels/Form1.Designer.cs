namespace CountVowels
{
    partial class Form1
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
            this.lblDirections = new System.Windows.Forms.Label();
            this.txtPhrase = new System.Windows.Forms.TextBox();
            this.lblVowels = new System.Windows.Forms.Label();
            this.txtVowelCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Location = new System.Drawing.Point(12, 9);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(267, 13);
            this.lblDirections.TabIndex = 0;
            this.lblDirections.Text = "Enter a phrase in the textbox below to count its vowels.";
            // 
            // txtPhrase
            // 
            this.txtPhrase.Location = new System.Drawing.Point(15, 25);
            this.txtPhrase.Multiline = true;
            this.txtPhrase.Name = "txtPhrase";
            this.txtPhrase.Size = new System.Drawing.Size(307, 146);
            this.txtPhrase.TabIndex = 1;
            this.txtPhrase.TextChanged += new System.EventHandler(this.txtPhrase_TextChanged);
            // 
            // lblVowels
            // 
            this.lblVowels.AutoSize = true;
            this.lblVowels.Location = new System.Drawing.Point(12, 180);
            this.lblVowels.Name = "lblVowels";
            this.lblVowels.Size = new System.Drawing.Size(96, 13);
            this.lblVowels.TabIndex = 3;
            this.lblVowels.Text = "Number of Vowels:";
            // 
            // txtVowelCount
            // 
            this.txtVowelCount.Location = new System.Drawing.Point(180, 177);
            this.txtVowelCount.Name = "txtVowelCount";
            this.txtVowelCount.ReadOnly = true;
            this.txtVowelCount.Size = new System.Drawing.Size(142, 20);
            this.txtVowelCount.TabIndex = 4;
            this.txtVowelCount.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.txtVowelCount);
            this.Controls.Add(this.lblVowels);
            this.Controls.Add(this.txtPhrase);
            this.Controls.Add(this.lblDirections);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.TextBox txtPhrase;
        private System.Windows.Forms.Label lblVowels;
        private System.Windows.Forms.TextBox txtVowelCount;
    }
}

