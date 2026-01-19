using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pismeni_na_satu
{
    public static class Admin
    {
        public static void SaveBook(string zapis)
        {
            StreamWriter sw = new StreamWriter("knjige.txt");
            sw.WriteLine(zapis);
            sw.Close();

        }
        public static List<string>SearchByTitleOrAuthor(string kriterij)
        {
            List<string> knjige = new List<string>();
            if (File.Exists("knjige.txt"))
            {
                StreamReader sr = new StreamReader("knjige.txt");
                string line;
                while((line=sr.ReadLine())!=null)
                {
                    string[] dijelovi = line.Split(',');
                    if (dijelovi[0]==(kriterij) || dijelovi[1]==(kriterij))
                        knjige.Add(line);
                }
                sr.Close();
            }
            return knjige;
            
        }
        public static List<string> GetAllAsStrings()
        {
            List<string> knjige = new List<string>();
            if (File.Exists("knjige.txt"))
            {
                StreamReader sr = new StreamReader("knjige.txt");
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    knjige.Add(line);
                }
                sr.Close();
            }
            return knjige;
        }
    }

}
