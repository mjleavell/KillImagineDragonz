using KillImagineDragonz.Songs;
using System;
using System.Collections.Generic;

namespace KillImagineDragonz
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Define a List, named `goodSongs`, that will hold instances of `Song`.
            List<Song> GoodSongs = new List<Song>();

            // 3. Define a List, named `allSongs`, that contains 12 instances of `Song`.
            // Make sure that some of the songs are from the band Imagine Dragons.
            List<Song> AllSongs = new List<Song>
            {
                new Song("Adele", "Hello"),
                new Song("Maggie Rogers", "Retrograde"),
                new Song("Renee Elise Goldsberry", "Satisfied"),
                new Song("Ariana Grande", "7 Rings"),
                new Song("Vanessa Carlton", "White Houses"),
                new Song("Imagine Dragons", "Radioactive"),
                new Song("Lauren Daigle", "Look Up Child"),
                new Song("Lauren Daigle", "You Say"),
                new Song("Ben Rector", "Old Friends"),
                new Song("Wild Child", "Back & Forth"),
                new Song("Margaret Glaspy", "You And I"),
                new Song("Lake Street Drive", "You Go Down Smooth"),
                new Song("Imagine Dragons", "Demons"),
            };

            // 4. Once the set is populated with 12 instances of song, use Linq to filter the `allSongs` 
            // list for songs where the artist is **not** Imagine Dragons.Set `goodSongs` equal to the filtered result.

            // 5. Loop to print out all the good songs like: Elton John : Tiny Dancer
        }
    }
}
