using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca1
{
    
    class Song
    {
        enum Genre
        {
            Rock,
            Pop,
            Dance,
            Other
        }
       public string title { get; set; }
       public string artist { get; set; }
       public double duration { get; set; }
        //Genre genre { get;}
        public  Song(string title, string artist, double duration)
        {
            this.title = title;
            this.artist = artist;
            this.duration = duration;
        }
        public override string ToString()
        {
            return string.Format("{0,-10} {1,-10} {2,-10} ", artist, title, duration);
        }
       
    }
}
