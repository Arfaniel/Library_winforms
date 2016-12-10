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
            this.title_label = new System.Windows.Forms.Label();
            this.auth_label = new System.Windows.Forms.Label();
            this.bookGenres_listbox = new System.Windows.Forms.ListBox();
            this.add_genre_Label1 = new System.Windows.Forms.LinkLabel();
            this.EditAuthorLabel = new System.Windows.Forms.LinkLabel();
            this.EditTitleLabel = new System.Windows.Forms.LinkLabel();
            this.newTitleTextBox1 = new System.Windows.Forms.TextBox();
            this.newAuthortextBox = new System.Windows.Forms.TextBox();
            this.SaveTitle = new System.Windows.Forms.Button();
            this.SaveAuthor = new System.Windows.Forms.Button();
            this.saveGenre = new System.Windows.Forms.Button();
            this.newGenreTextBox = new System.Windows.Forms.TextBox();
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
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Location = new System.Drawing.Point(16, 261);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(55, 13);
            this.title_label.TabIndex = 3;
            this.title_label.Text = "Book Title";
            // 
            // auth_label
            // 
            this.auth_label.AutoSize = true;
            this.auth_label.Location = new System.Drawing.Point(16, 287);
            this.auth_label.Name = "auth_label";
            this.auth_label.Size = new System.Drawing.Size(38, 13);
            this.auth_label.TabIndex = 4;
            this.auth_label.Text = "Author";
            // 
            // bookGenres_listbox
            // 
            this.bookGenres_listbox.FormattingEnabled = true;
            this.bookGenres_listbox.Location = new System.Drawing.Point(19, 313);
            this.bookGenres_listbox.Name = "bookGenres_listbox";
            this.bookGenres_listbox.Size = new System.Drawing.Size(161, 56);
            this.bookGenres_listbox.TabIndex = 5;
            // 
            // add_genre_Label1
            // 
            this.add_genre_Label1.AutoSize = true;
            this.add_genre_Label1.Location = new System.Drawing.Point(187, 355);
            this.add_genre_Label1.Name = "add_genre_Label1";
            this.add_genre_Label1.Size = new System.Drawing.Size(56, 13);
            this.add_genre_Label1.TabIndex = 6;
            this.add_genre_Label1.TabStop = true;
            this.add_genre_Label1.Text = "Add genre";
            this.add_genre_Label1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.add_genre_Label1_LinkClicked);
            // 
            // EditAuthorLabel
            // 
            this.EditAuthorLabel.AutoSize = true;
            this.EditAuthorLabel.Location = new System.Drawing.Point(155, 287);
            this.EditAuthorLabel.Name = "EditAuthorLabel";
            this.EditAuthorLabel.Size = new System.Drawing.Size(25, 13);
            this.EditAuthorLabel.TabIndex = 7;
            this.EditAuthorLabel.TabStop = true;
            this.EditAuthorLabel.Text = "Edit";
            this.EditAuthorLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EditAuthorLabel_LinkClicked);
            // 
            // EditTitleLabel
            // 
            this.EditTitleLabel.AutoSize = true;
            this.EditTitleLabel.Location = new System.Drawing.Point(155, 261);
            this.EditTitleLabel.Name = "EditTitleLabel";
            this.EditTitleLabel.Size = new System.Drawing.Size(25, 13);
            this.EditTitleLabel.TabIndex = 8;
            this.EditTitleLabel.TabStop = true;
            this.EditTitleLabel.Text = "Edit";
            this.EditTitleLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EditTitleLabel_LinkClicked);
            // 
            // newTitleTextBox1
            // 
            this.newTitleTextBox1.Location = new System.Drawing.Point(19, 258);
            this.newTitleTextBox1.Name = "newTitleTextBox1";
            this.newTitleTextBox1.Size = new System.Drawing.Size(180, 20);
            this.newTitleTextBox1.TabIndex = 9;
            this.newTitleTextBox1.Visible = false;
            // 
            // newAuthortextBox
            // 
            this.newAuthortextBox.Location = new System.Drawing.Point(19, 284);
            this.newAuthortextBox.Name = "newAuthortextBox";
            this.newAuthortextBox.Size = new System.Drawing.Size(180, 20);
            this.newAuthortextBox.TabIndex = 10;
            this.newAuthortextBox.Visible = false;
            // 
            // SaveTitle
            // 
            this.SaveTitle.Location = new System.Drawing.Point(205, 256);
            this.SaveTitle.Name = "SaveTitle";
            this.SaveTitle.Size = new System.Drawing.Size(75, 23);
            this.SaveTitle.TabIndex = 11;
            this.SaveTitle.Text = "Save";
            this.SaveTitle.UseVisualStyleBackColor = true;
            this.SaveTitle.Visible = false;
            this.SaveTitle.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaveAuthor
            // 
            this.SaveAuthor.Location = new System.Drawing.Point(205, 281);
            this.SaveAuthor.Name = "SaveAuthor";
            this.SaveAuthor.Size = new System.Drawing.Size(75, 23);
            this.SaveAuthor.TabIndex = 12;
            this.SaveAuthor.Text = "Save";
            this.SaveAuthor.UseVisualStyleBackColor = true;
            this.SaveAuthor.Visible = false;
            this.SaveAuthor.Click += new System.EventHandler(this.SaveAuthor_Click);
            // 
            // saveGenre
            // 
            this.saveGenre.Location = new System.Drawing.Point(372, 345);
            this.saveGenre.Name = "saveGenre";
            this.saveGenre.Size = new System.Drawing.Size(75, 23);
            this.saveGenre.TabIndex = 14;
            this.saveGenre.Text = "Save";
            this.saveGenre.UseVisualStyleBackColor = true;
            this.saveGenre.Visible = false;
            this.saveGenre.Click += new System.EventHandler(this.saveGenre_Click);
            // 
            // newGenreTextBox
            // 
            this.newGenreTextBox.Location = new System.Drawing.Point(186, 348);
            this.newGenreTextBox.Name = "newGenreTextBox";
            this.newGenreTextBox.Size = new System.Drawing.Size(180, 20);
            this.newGenreTextBox.TabIndex = 13;
            this.newGenreTextBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 408);
            this.Controls.Add(this.saveGenre);
            this.Controls.Add(this.newGenreTextBox);
            this.Controls.Add(this.SaveAuthor);
            this.Controls.Add(this.SaveTitle);
            this.Controls.Add(this.newAuthortextBox);
            this.Controls.Add(this.newTitleTextBox1);
            this.Controls.Add(this.EditTitleLabel);
            this.Controls.Add(this.EditAuthorLabel);
            this.Controls.Add(this.add_genre_Label1);
            this.Controls.Add(this.bookGenres_listbox);
            this.Controls.Add(this.auth_label);
            this.Controls.Add(this.title_label);
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
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label auth_label;
        private System.Windows.Forms.ListBox bookGenres_listbox;
        private System.Windows.Forms.LinkLabel add_genre_Label1;
        private System.Windows.Forms.LinkLabel EditAuthorLabel;
        private System.Windows.Forms.LinkLabel EditTitleLabel;
        private System.Windows.Forms.TextBox newTitleTextBox1;
        private System.Windows.Forms.TextBox newAuthortextBox;
        private System.Windows.Forms.Button SaveTitle;
        private System.Windows.Forms.Button SaveAuthor;
        private System.Windows.Forms.Button saveGenre;
        private System.Windows.Forms.TextBox newGenreTextBox;
    }
}

