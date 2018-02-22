using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MiniASIO
{
    class NamesToFile
    {
        static void Test()
        {
            try
            {
                string line;
                string myfile = @"C:\Users\Akallath\Desktop\Koululaput\Olio-ohjelmointi\Harjoitukset9\Harj9Teht1\testi.txt";
                //luodaan tiedosto
                using (StreamWriter sw = new StreamWriter(myfile))
                {
                    //kysytään käyttäjältä nimet ja kirjoitetaan tiedostoon
                    do
                    {
                        Console.WriteLine("Anna henkilön nimi, sukunimi, AsioID ja Ryhmä (tyhjä lopettaa)");
                        line = Console.ReadLine();
                        if (line.Length > 0) ;
                        {
                            sw.WriteLine(line);
                        }
                    } while (line.Length > 0);
                    // sw.Close();
                }
                //avataan tiedosto lukua varten
                if (File.Exists(myfile))
                {
                    //näytetään nimet
                    string txt = File.ReadAllText(myfile);
                    Console.WriteLine("Tiedostossa {0} on nimet: \n{1}", myfile, txt);

                }
                else
                {
                    Console.WriteLine("Tiedostoa {0} ei löydy", myfile);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                //Dictionary<string, Opiskelija> opiskelijat = new Dictionary<string, Opiskelija>();

                List<Opiskelija> opiskelijat = new List<Opiskelija>();
                opiskelijat.Add(new Opiskelija { Etunimi = "Testi", Sukunimi = "Testinen", AsioID = "T0001", Ryhmä = "TTV00S01" });
                opiskelijat.Add(new Opiskelija { Etunimi = "Kakke", Sukunimi = "Kakkonen", AsioID = "T0002", Ryhmä = "TTV00S02" });
                opiskelijat.Add(new Opiskelija { Etunimi = "Kokko", Sukunimi = "Kolehmainen", AsioID = "T0003", Ryhmä = "TTV00S03" });
                opiskelijat.Add(new Opiskelija { Etunimi = "Neuvosto", Sukunimi = "Liittolainen", AsioID = "T6666", Ryhmä = "TTV66S66" });

                Console.WriteLine("Anna opiskelijan tiedot (Etunimi, Sukunimi, AsioID ja Ryhmä)");
                opiskelijat.Add(new Opiskelija
                {
                    Etunimi = Console.ReadLine(),
                    Sukunimi = Console.ReadLine(),
                    AsioID = Console.ReadLine(),
                    Ryhmä = Console.ReadLine()
                });

                opiskelijat.Sort((x, y) => x.Sukunimi.CompareTo(y.Sukunimi));

                foreach (Opiskelija opiskelija in opiskelijat)
                {
                    Console.WriteLine(opiskelija.ToString());
                }
                
                //Test();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
