namespace SomeLibrary
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
            this.comboGenre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.booksByGenre = new System.Windows.Forms.ListBox();
            this.bookTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboGenre
            // 
            this.comboGenre.FormattingEnabled = true;
            this.comboGenre.Location = new System.Drawing.Point(13, 31);
            this.comboGenre.Name = "comboGenre";
            this.comboGenre.Size = new System.Drawing.Size(158, 21);
            this.comboGenre.TabIndex = 0;
            this.comboGenre.SelectedIndexChanged += new System.EventHandler(this.comboGenre_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Genre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // booksByGenre
            // 
            this.booksByGenre.FormattingEnabled = true;
            this.booksByGenre.Location = new System.Drawing.Point(216, 31);
            this.booksByGenre.Name = "booksByGenre";
            this.booksByGenre.Size = new System.Drawing.Size(199, 134);
            this.booksByGenre.TabIndex = 2;
            this.booksByGenre.SelectedIndexChanged += new System.EventHandler(this.booksByGenre_SelectedIndexChanged);
            // 
            // bookTitle
            // 
            this.bookTitle.AutoSize = true;
            this.bookTitle.Location = new System.Drawing.Point(16, 261);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(55, 13);
            this.bookTitle.TabIndex = 3;
            this.bookTitle.Text = "Book Title";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 408);
            this.Controls.Add(this.bookTitle);
            this.Controls.Add(this.booksByGenre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboGenre);
            this.Name = "Form1";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox booksByGenre;
        private System.Windows.Forms.Label bookTitle;
    }
}

