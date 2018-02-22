using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj9Teht2
{
    class Song
    {
        public string TrackArtist { get; set; }
        public string TrackTitle { get; set; }
        public int TrackLength { get; set; }

        public Song(string artist, string title, int length)
        {
            TrackArtist = artist;
            TrackTitle = title;
            TrackLength = length;
        }
    }
}
