using kursa4_hotel.common;
using kursa4_Samsonova.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursa4_Samsonova
{
    static class localdb
    {
        public static Dictionary<int, Card> cards = new Dictionary<int, Card>();
        public static Dictionary<int, User> users = new Dictionary<int, User>();

        public static async Task ConvertToLocalAsync()
        {
            string q = "SELECT * FROM [Cards]";
            localdb.cards.Clear();
            SqlDataReader sqlReader = await new SQLConnector().ExecuteQuery(q);

            while (await sqlReader.ReadAsync())
            {
                int id = Convert.ToInt32(sqlReader["Id"]);
                int user_id = Convert.ToInt32(sqlReader["user_id"]);
                string number = Convert.ToString(sqlReader["number"]);
                string money = Convert.ToString(sqlReader["money"]);
                string history = Convert.ToString(sqlReader["history"]);
                localdb.cards.Add(id, new Card(id, number, money, history, user_id));
                Console.WriteLine(Convert.ToString(sqlReader["Id"]) + "   " + Convert.ToString(sqlReader["number"]) + "  " + Convert.ToString(sqlReader["money"]));
            }


            q = "SELECT * FROM [USERS]";
            localdb.users.Clear();
            sqlReader = await new SQLConnector().ExecuteQuery(q);

            while (await sqlReader.ReadAsync())
            {
                int id = Convert.ToInt32(sqlReader["Id"]);
                string family = Convert.ToString(sqlReader["family"]);
                string name = Convert.ToString(sqlReader["name"]);
                string patronic = Convert.ToString(sqlReader["patronic"]);
                localdb.users.Add(id, new User(id, family, name, patronic));
                Console.WriteLine(Convert.ToString(sqlReader["Id"]) + "   " + Convert.ToString(sqlReader["name"]) + "  " + Convert.ToString(sqlReader["family"]) + "   " + Convert.ToString(sqlReader["patronic"]));
             }

        }
        public static async Task WriteAllToDBAsync()
        {
            await ConvertToLocalAsync();
            WriteCardsToDB();
            WriteUsersToDB();
        }
        public async static void WriteCardsToDB()
        {
            ClearDB(Constant.path + Constant.file_cards);
            foreach (var card in cards)
            {
                await Writer.write(card.Value.Id + ";" + card.Value.Number + ";" + card.Value.Money + ";", Constant.file_cards);
            }
        }
        //public async static Task ReadGuestsFromDB()
        //{
        //    List<string> listguest = await Reader.read(Constant.file_Guest);
        //    Dictionary<uint, Guest> TMPguests = new Dictionary<uint, Guest>();
        //    foreach (var g in listguest)
        //    {
        //        string[] guest = g.Split(';');
        //        string[] fio = guest[2].Split(' ');
        //        FIO tempfio = new FIO(fio[0], fio[1], fio[2]);

        //        TMPguests.Add(Convert.ToUInt32(TMPguests.Count() + 1), new Guest(new ID(Convert.ToUInt32(TMPguests.Count() + 1)), new Passport(tempfio, guest[1], guest[3])));

        //    }
        //    guest.Clear();
        //    guest = TMPguests;
        //}
        public async static void WriteUsersToDB()
        {
            ClearDB(Constant.path + Constant.file_users);
            foreach (var user in users)
            {
                string furnitures = "";
                //foreach (var f in user.Value.Furnitures)
                //{
                //    furnitures += f.GetStrFile() + "_";
                //}
                await Writer.write(user.Value.Id + ";" + user.Value.Family + ";" + user.Value.Name + ";" + user.Value.Patronic + ";"+ furnitures, Constant.file_users);
            }
        }
        //public async static Task ReadRoomsFromDB()
        //{
        //    List<string> listrooms = await Reader.read(Constant.file_Rooms);
        //    Dictionary<uint, Room> TMProoms = new Dictionary<uint, Room>();
        //    foreach (var r in listrooms)
        //    {
        //        string[] room = r.Split(';');
        //        string[] furArr = room[4].Split('_');
        //        //      string owner = "Свободно";
        //        Guest owner = null;

        //        if (guest.ContainsKey(Convert.ToUInt32(room[1])))
        //        {
        //            owner = DB.guest[Convert.ToUInt32(room[1])];
        //        }

        //        List<Furniture> fur_list = new List<Furniture>();

        //        foreach (var oneFur in furArr)
        //        {
        //            string[] fur_par = oneFur.Split('+');
        //            if (fur_par[0] != "")
        //                fur_list.Add(new Furniture(fur_par[1], fur_par[0], Convert.ToUInt32(fur_par[2])));
        //        }

        //        //   FIO tempfio = new FIO(fio[0], fio[1], fio[2]);
        //        // public Room(ID id, uint count_rooms, List<Furniture> furnitures, bool isBathroom, Guest owner)
        //        Room tmp = new Room(new ID(Convert.ToUInt32(room[0])), Convert.ToUInt32(room[2]), fur_list, Convert.ToBoolean(room[3]), owner);
        //        TMProoms.Add(tmp.Id.Id, tmp);

        //    }
        //    DB.rooms.Clear();
        //    rooms = TMProoms;
        //}


        public static void ClearDB(string path_to_file)
        {
            FileStream fs = File.Open(path_to_file, FileMode.Open, FileAccess.ReadWrite);
            fs.SetLength(0);
            fs.Close();
        }
        //public void getCard
    }
}
