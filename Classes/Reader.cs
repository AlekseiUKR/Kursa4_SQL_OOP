using kursa4_Samsonova.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursa4_hotel.common
{
    public static class Reader { 
        public async static Task<List<string>> read(string filename)
        {
            List<string> guest = new List<string>();
            // асинхронное чтение
            using (StreamReader sr = new StreamReader(Constant.path + filename, System.Text.Encoding.Default))
            {
                string line;
                while ((line = await sr.ReadLineAsync()) != null)
                {
                    Console.WriteLine(line);
                    guest.Add(line);
                }
            }
            return guest;
        }
    }
}
