using System;
using System.Collections.Generic;

class Song
{
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        int numberOfSongs = int.Parse(Console.ReadLine());
        List<Song> songs = new List<Song>();

        for (int i = 0; i < numberOfSongs; i++)
        {
            string[] songInput = Console.ReadLine().Split("_");

            string typeList = songInput[0], name = songInput[1], time = songInput[2];

            Song song = new Song();

            song.TypeList = typeList;
            song.Name = name;
            song.Time = time;

            songs.Add(song);
        }

        string type = Console.ReadLine();

        if (type == "all")
        {
            foreach (var song in songs)
            {
                Console.WriteLine(song.Name);
            }
        }
        else
        {
            foreach (var song in songs)
            {
                if (song.TypeList == type)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
}