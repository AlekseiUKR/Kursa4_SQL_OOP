using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursa4_Samsonova
{
    public partial class FormCard : Form
    {
        uint id_card;
        public FormCard()
        {
            InitializeComponent();
        }
        public FormCard(uint id)
        {
            id_card = id;
            InitializeComponent();
            LoadData();
        }
        private async void but_save_Click(object sender, EventArgs e)
        {
            if (id_card == 0)
            {
                string q = "INSERT INTO [Cards] (number,money,history,user_id)VALUES(";
                q += '\'' + textBox_number.Text + "\',";
                q += '\'' + textBox_money.Text + "\',";
                q += '\'' + textBox_history.Text.ToString() + "\',";
                if (listBox1.Items.Count > 0)
                    q += '\'' + listBox1.Items[0].ToString() + "\')";
                
                await new SQLConnector().ExecuteQuery(q);
            }
            else
            {
                string q = "UPDATE[Cards] SET number = \'" +
                    Convert.ToString(textBox_number.Text) +
                    "\', user_id = \'" + listBox1.Items[0].ToString() +
                    "\', money = \'" + textBox_money.Text +
                    "\', history = \'" + textBox_history.Text.ToString() +
                    "\' WHERE id = " + id_card;
                await new SQLConnector().ExecuteQuery(q);

            }
            this.Close();
        }

        private async void listBox1_DoubleClick(object sender, EventArgs e)
        {
            DBusers newForm = new DBusers(out uint id);
            newForm.ShowDialog();
            id = newForm.local_tempid;
            listBox1.Text = "";
            string q = "SELECT * FROM [USERS] WHERE [id]=" + id;
            SqlDataReader sqlReader = await new SQLConnector().ExecuteQuery(q);

            while (await sqlReader.ReadAsync())
            {
                listBox1.Items.Add(Convert.ToString(sqlReader["id"]));
                listBox1.Items.Add(Convert.ToString(sqlReader["name"]));
                listBox1.Items.Add(Convert.ToString(sqlReader["family"]));
                listBox1.Items.Add(Convert.ToString(sqlReader["patronic"]));
            }
        }



        private async void LoadData()
        {
            string user_id = "";
            string q = "SELECT * FROM [CARDS] WHERE id=" + id_card.ToString();
            Console.WriteLine("Run Query " + q);
            using (SqlDataReader sqlReader = await new SQLConnector().ExecuteQuery(q))
            {
                while (await sqlReader.ReadAsync())
                {
                    user_id = Convert.ToString(sqlReader["user_id"]);
                    label1.Text = "ID: " + id_card.ToString();
                    textBox_number.Text = Convert.ToString(sqlReader["number"]);
                    textBox_money.Text = Convert.ToString(sqlReader["money"]);
                    textBox_history.Text = Convert.ToString(sqlReader["history"]);
                }
            }
            q = "SELECT * FROM [USERS] WHERE id = " + user_id;
            Console.WriteLine("Run Query " + q);
            using (SqlDataReader sqlReader = await new SQLConnector().ExecuteQuery(q))
            {
                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["id"]));
                    listBox1.Items.Add(Convert.ToString(sqlReader["name"]));
                    listBox1.Items.Add(Convert.ToString(sqlReader["family"]));
                    listBox1.Items.Add(Convert.ToString(sqlReader["patronic"]));
                }
            }
        }
        private void FormCard_Load(object sender, EventArgs e)
        {
            if (id_card > 0)
            {

            }
        }

        private void change_balance_Click(object sender, EventArgs e)
        {
            int money = 0;
            if(Int32.TryParse(textBox_balance_change.Text.ToString(),out money))
            {
                int balance = Convert.ToInt32(textBox_money.Text);
                balance += money;
                if (money > 0)
                    textBox_history.Text += "Пополнено:" + money + "\r\n";
                if (money < 0)
                    textBox_history.Text += "Списано:" + money + "\r\n";
                textBox_history.Text += "Баланс:" + balance + "\r\n";
                textBox_money.Text = balance.ToString();
            }
        }
    }

}
