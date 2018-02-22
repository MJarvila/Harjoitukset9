using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj9Teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song("Alkoholisti", "Keppana on loppu", 666);
            Song song2 = new Song("Puistokemisti", "Piri pärisee", 999);
            List<Song> Songs = new List<Song>() { song, song2 };
            c
            CD album = new CD("Rappiotyypit", "Lomalla", Songs);

            Console.WriteLine("Levy on seuraava: {0} - {1}", album.CDArtist, album.CDTitle);
            foreach (Song cdsong in album.Songs)
            {
                Console.WriteLine("Artisti: {0} Nimi: {1} Kesto: {2} sekuntia.", cdsong.TrackArtist, cdsong.TrackTitle, cdsong.TrackLength);
            }
        }
    }
}
