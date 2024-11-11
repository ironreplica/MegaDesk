using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnViewQuotes_Click(object sender, EventArgs e)
        {
            ViewQuotes viewQuote = new ViewQuotes();
            viewQuote.Tag = this;
            viewQuote.Show(this);
            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNewQuote_Click(object sender, EventArgs e)
        {
            AddNewQuote addQuote = new AddNewQuote();
            addQuote.Tag = this;   
            addQuote.Show(this);
            Hide();
        }
    }
}
