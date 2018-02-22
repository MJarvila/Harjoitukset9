using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj9Teht2
{
    class CD
    {
        public string CDArtist { get; set; }
        public string CDTitle { get; set; }

        public List<Song> Songs { get; set; }

        public CD(string artist, string title, List<Song> songs)
        {
            CDArtist = artist;
            CDTitle = title;
            Songs = songs;
        }
    }
}
