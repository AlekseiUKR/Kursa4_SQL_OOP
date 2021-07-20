using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursa4_Samsonova
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            but_usr.Click += But_usr_Click;
            but_cards.Click += But_cards_Click;
        }

        private void But_cards_Click(object sender, EventArgs e)
        {

            DBcards newForm = new DBcards();
            //    this.Hide();
            newForm.Show();
            // throw new NotImplementedException();
        }

        private void But_usr_Click(object sender, EventArgs e)
        {
            DBusers newForm = new DBusers();
            //    this.Hide();
            newForm.Show();
            //  throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localdb.WriteAllToDBAsync();
        }
    }
}
