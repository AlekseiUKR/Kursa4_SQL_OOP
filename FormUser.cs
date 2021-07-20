using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static kursa4_Samsonova.DBusers;
using static kursa4_Samsonova.FormUser;
using static kursa4_Samsonova.DBcards;
using System.Data.SqlClient;

namespace kursa4_Samsonova
{
    public partial class FormUser : Form
    {
        uint id_user;
        public FormUser(uint id)
        {
            id_user = id;
            InitializeComponent();
            LoadData();
            btn_save.Text = "Изменить";


        }
        public FormUser()
        {
            InitializeComponent();
            btn_save.Text = "Добавить";
        }


        private async void LoadData()
        {
            string q = "SELECT * FROM [USERS] WHERE id=" + id_user.ToString();
            Console.WriteLine("Run Query " + q);
            using (SqlDataReader sqlReader = await new SQLConnector().ExecuteQuery(q))
            {
                while (await sqlReader.ReadAsync())
                {
                    label_id.Text = "ID: " + id_user.ToString();
                    Console.WriteLine(Convert.ToString(sqlReader["name"]));
                    textBox_name.Text = Convert.ToString(sqlReader["name"]);
                    textBox_family.Text = Convert.ToString(sqlReader["family"]);
                    textBox_patronymic.Text = Convert.ToString(sqlReader["patronic"]);
                    btn_del.Visible = true;
                }
            }
            q = "SELECT * FROM [CARDS] WHERE user_id = " + id_user.ToString();
            Console.WriteLine("Run Query " + q);
            using (SqlDataReader sqlReader = await new SQLConnector().ExecuteQuery(q))
            {
                while (await sqlReader.ReadAsync())
                {
                    cardgrid.Rows.Add(Convert.ToString(sqlReader["id"]), Convert.ToString(sqlReader["number"]), Convert.ToString(sqlReader["money"]));
                }
            }
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {

            if (id_user == 0)
            {
                string q = "INSERT INTO [USERS] (name,family,patronic)VALUES(";

                q += '\'' + textBox_name.Text + "\',";
                q += '\'' + textBox_family.Text + "\',";
                q += '\'' + textBox_patronymic.Text + "\')";
                await new SQLConnector().ExecuteQuery(q);
            }
            else
            {
                string q = "UPDATE[USERS] SET name = \'" +
                    Convert.ToString(textBox_name.Text) +
                    "\', family = \'" + Convert.ToString(textBox_family.Text) +
                    "\', patronic = \'" + Convert.ToString(textBox_patronymic.Text) +
                    "\' WHERE id = " + id_user;
                await new SQLConnector().ExecuteQuery(q);

            }
        }

        private async void btn_del_Click(object sender, EventArgs e)
        {
            string q = "DELETE FROM [CARDS] WHERE [user_id]=";
            q += id_user;
            Console.WriteLine(q);
            await new SQLConnector().ExecuteQuery(q);
            q = "DELETE FROM [USERS] WHERE [Id]=";
            q += id_user;
            Console.WriteLine(q);
            await new SQLConnector().ExecuteQuery(q);
            this.Close();
        }

        private void label_id_Click(object sender, EventArgs e)
        {

        }

        private void cardgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormCard newForm = new FormCard(Convert.ToUInt32(cardgrid[0, e.RowIndex].Value));
            // this.Hide();
            newForm.Show();
        }
    }
}
