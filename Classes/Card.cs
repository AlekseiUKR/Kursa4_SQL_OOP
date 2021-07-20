using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursa4_Samsonova.Classes
{
    class Card
    {
        int id;
        string number;
        string money;
        string history;
        int user_id;

        public Card(int id, string number, string money, string history, int user_id = 0)
        {
            this.Id = id;
            this.Number = number;
            this.Money = money;
            this.History = history;
            this.User_id = user_id;
        }

        public int User_id { get => user_id; set => user_id = value; }
        public int Id { get => id; set => id = value; }
        public string Number { get => number; set => number = value; }
        public string Money { get => money; set => money = value; }
        public string History { get => history; set => history = value; }

        public DataGridViewRow getRowCard()
        {
            DataGridViewRow q = new DataGridViewRow();
            q.Cells[0].Value = id.ToString();
            q.Cells[1].Value = number;
            q.Cells[2].Value = money;
            q.Cells[3].Value = history;
            q.Cells[4].Value = user_id.ToString();
            return q;
        }
    }
}
