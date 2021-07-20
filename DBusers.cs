using kursa4_Samsonova.Classes;
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
using static kursa4_Samsonova.DBcards;
using static kursa4_Samsonova.FormUser;

namespace kursa4_Samsonova
{
    public partial class DBusers : Form
    {
        bool ISchoice = false; 
        public DBusers()
        {
            InitializeComponent();
        }
        public uint local_tempid=0;
        public DBusers(out uint tempid)
        {
           tempid=  local_tempid;
            ISchoice = true;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void usergrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (ISchoice)
            {
                local_tempid = Convert.ToUInt32(usergrid[0, e.RowIndex].Value);
                this.Close();
                
            }
            else
            {
                FormUser newForm = new FormUser(Convert.ToUInt32(usergrid[0, e.RowIndex].Value));
                // this.Hide();
                newForm.Show();
            }
        }

        private void DBusers_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private async void LoadData()
        {
            usergrid.Rows.Clear();
            string q = "SELECT * FROM [USERS]";
            SqlDataReader sqlReader = await new SQLConnector().ExecuteQuery(q);

            localdb.users.Clear();
            while (await sqlReader.ReadAsync())
            {
                int id = Convert.ToInt32(sqlReader["Id"]);
                string family = Convert.ToString(sqlReader["family"]);
                string name = Convert.ToString(sqlReader["name"]);
                string patronic = Convert.ToString(sqlReader["patronic"]);
                //string user = 
                localdb.users.Add(id, new User(id, family, name, patronic));

                Console.WriteLine(Convert.ToString(sqlReader["Id"]) + "   " + Convert.ToString(sqlReader["name"]) + "  " + Convert.ToString(sqlReader["family"]) + "   " + Convert.ToString(sqlReader["patronic"]));
                usergrid.Rows.Add(Convert.ToString(sqlReader["Id"]), Convert.ToString(sqlReader["name"]), Convert.ToString(sqlReader["family"]), Convert.ToString(sqlReader["patronic"]));
                //userList.Add(new User(Convert.ToUInt32(sqlReader["Id"]), Convert.ToString(sqlReader["name"]), Convert.ToString(sqlReader["family"]), Convert.ToString(sqlReader["patronic"])));
            }
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            FormUser newForm = new FormUser();
            //    this.Hide();
            newForm.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void usergrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
