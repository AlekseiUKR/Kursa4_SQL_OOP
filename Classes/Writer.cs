using kursa4_Samsonova.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursa4_hotel.common
{
    public static class Writer
    {
        public static async Task write(string str,string filename)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(Constant.path + filename, true, System.Text.Encoding.Default))
                {
                    await sw.WriteAsync(str + '\n');
                }
                Console.WriteLine("Запись выполнена");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
