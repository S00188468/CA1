using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca1
{
    class Program
    {

        static void Main(string[] args)
        {
            Song song1 = new Song("ED SHEERAN", "BLYATFUL PEOPLE", 3.15);
            Song song2 = new Song("REGARD", "RIDE IT", 3.37);
            Song song3 = new Song("TONES & I", "DANCE MONKEY", 4.20);
            Song song4 = new Song("POST MALONE", "CIRCLES", 3.25);
            Song song5 = new Song("TYLER THE CREATOR", "SHE", 4.13);

            List<Song> Playlist = new List<Song>();
            Playlist.Add(song1);
            Playlist.Add(song2);
            Playlist.Add(song3);
            Playlist.Add(song4);
            Playlist.Add(song5);


        }
        static void DisplayPlaylist(List<Song> Playlist)
        {
            for (int i = 0; i < Playlist.Count; i++)
            {
                Console.WriteLine("{0-15}{1-15}{2-15}{3,-15}", Playlist[i].artist, Playlist[i].title, Playlist[i].duration);
            }

        }


    }
    }
