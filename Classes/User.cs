using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursa4_Samsonova.Classes
{
    class User
    {
        int id;
        string family;
        string name;
        string patronic;
        List<Card> cards = new List<Card>();

        public User(int id, string family, string name, string patronic)
        {
            this.id = id;
            this.family = family;
            this.name = name;
            this.patronic = patronic;
        }

        public User(int id, string family, string name, string patronic, List<Card> cards)
        {
            this.id = id;
            this.family = family;
            this.name = name;
            this.patronic = patronic;
            this.cards = cards;
        }

        public int Id { get => id; set => id = value; }
        public string Family { get => family; set => family = value; }
        public string Name { get => name; set => name = value; }
        public string Patronic { get => patronic; set => patronic = value; }
        internal List<Card> Cards { get => cards; set => cards = value; }
    }
}
