using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicProject
{
    internal class Song
    {
        public string Title;
        public string Artist;
        public int duration;

        public static int songcount;

        public Song(params string[] values) { 
        Title = values[2];
        
        
        }
        public Song(string aTitle , string aArtist , int aduration) { 
        
            Title = aTitle;
            Artist = aArtist;
            duration = aduration;
            songcount++;
        }

        public int getsongcount() { 
        return songcount;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
        }

    }
}
