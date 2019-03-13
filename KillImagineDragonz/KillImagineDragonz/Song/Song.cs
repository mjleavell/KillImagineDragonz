using System;
using System.Collections.Generic;
using System.Text;

namespace KillImagineDragonz.Song
{
    class Song
    {
        // Define a class called `Song` that has a string property `Artist` and a string property `Name`. 
        // Both properties should be required(invariant) in order to construct an instance of `Song`

        public string Artist { get; }
        public string Name { get; }

        public Song(string artistName, string songName)
        {
            Artist = artistName;
            Name = songName;
        }

    }
}
