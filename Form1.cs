using SomeLibrary.classLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeLibrary
{
    public partial class Form1 : Form
    {
        List<Book> lib = new List<Book>();
        List<Genre> genre = new List<Genre>();
        public Form1()
        {
            InitializeComponent();
            iniBooks();
        }
        private void iniBooks()
        {
            for (int i = 0; i < 5; i++)
            {
                Genre tempGenre = new Genre("Genre" + i);
                Book tempBook = new Book("Title" + i, "Author" + i, tempGenre);
                genre.Add(tempGenre);
                lib.Add(tempBook);
            }
            Genre temp = new Genre("Genre2");
            lib[0]._genre.Add(temp);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var genreName in genre)
            {
                comboGenre.Items.Add(genreName);
            }
        }
        private void comboGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            booksByGenre.Items.Clear();
            for (int i = 0; i < lib.Count; i++)
            {
                for (int j = 0; j < lib[i]._genre.Count; j++)
                {
                    if (comboGenre.SelectedItem.ToString() == lib[i]._genre[j].ToString())
                    {
                        booksByGenre.Items.Add(lib[i]);
                    }
                }
            }
         }
        private void booksByGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            newTitleTextBox1.Clear();
            newAuthortextBox.Clear();
            for (int i = 0; i < lib.Count; i++)
            {
                if(lib[i]._title == booksByGenre.SelectedItem.ToString())
                {
                    title_label.Text = lib[i]._title;
                    auth_label.Text = lib[i]._autor;
                    bookGenres_listbox.Items.Clear();
                    for (int j = 0; j < lib[i]._genre.Count; j++)
                    {
                        bookGenres_listbox.Items.Add(lib[i]._genre[j]);
                    }
                    break;
                }
            }
             
        }
        private void EditTitleLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (title_label.Text == "Book Title")
            {
                return;
            }
            newTitleTextBox1.Visible = true;
            SaveTitle.Visible = true;
        }
        private void EditAuthorLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (auth_label.Text == "Author")
            {
                return;
            }
            newAuthortextBox.Visible = true;
            SaveAuthor.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (newTitleTextBox1.Text.Length < 2)
            {
                return;
            }
            for (int i = 0; i < lib.Count; i++)
            {
                if (title_label.Text == lib[i]._title)
                {
                    lib[i]._title = newTitleTextBox1.Text;
                    title_label.Text = newTitleTextBox1.Text;
                    break;
                }
                newTitleTextBox1.Visible = false;
                SaveTitle.Visible = false;
                clearTextBox(newTitleTextBox1);
            }
        }

        private void SaveAuthor_Click(object sender, EventArgs e)
        {
            if (newAuthortextBox.Text.Length < 2)
            {
                return;
            }
            for (int i = 0; i < lib.Count; i++)
            {
                if (title_label.Text == lib[i]._title)
                {
                    lib[i]._autor = newAuthortextBox.Text;
                    auth_label.Text = newAuthortextBox.Text;
                    break;
                }
                newAuthortextBox.Visible = false;
                SaveAuthor.Visible = false;
                clearTextBox(newAuthortextBox);
            }
        }

        private void add_genre_Label1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (bookGenres_listbox.Items.Count > 0)
            {
                newGenreTextBox.Visible = true;
                saveGenre.Visible = true;
            }
            
        }

        private void saveGenre_Click(object sender, EventArgs e)
        {
            if (newGenreTextBox.Text.Length < 4)
            {
                return;
            }
            bool isSuchGenre= false;
            for (int i = 0; i < genre.Count; i++)
            {
                if (genre[i].genreName == newTitleTextBox1.Text)
                {
                    isSuchGenre = true;
                }
            }
            Genre temp = new Genre();
            if (isSuchGenre == false)
            {
                temp.genreName = newGenreTextBox.Text;
                genre.Add(temp);
            }
            for (int i = 0; i < lib.Count; i++)
            {
                if (lib[i]._title == title_label.Text)
                {
                    lib[i]._genre.Add(temp);
                    break;
                }
            }
            comboGenre.DataSource = genre;
            newGenreTextBox.Visible = false;
            saveGenre.Visible = false;
            clearTextBox(newGenreTextBox);
        }
        private void clearTextBox(TextBox toClear)
        {
            toClear.Text = "";
        }
    }
}
