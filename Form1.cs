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
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var genreName in genre)
            {
                comboGenre.Items.Add(genreName);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void comboGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            booksByGenre.Items.Clear();
            int count = 0;
            for (int i = 0; i < lib.Count; i++)
            {
                for (int j = 0; j < lib[i]._genre.Count; j++)
                {
                    if (comboGenre.SelectedItem == lib[i]._genre[j])
                    {
                        count++;
                        booksByGenre.Items.Add(count +" "+ lib[i]);
                    }
                }
            }
         }

        private void booksByGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            bookTitle.Text = booksByGenre.SelectedValue.ToString();
        }
    }
}
