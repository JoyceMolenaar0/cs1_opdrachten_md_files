using System;
using System.Buffers;

namespace VariableOpdracht2
{
    internal class Program
    {
        //class variables & gebruik
        static void Main(string[] args)
        {

            //ga naar de file TwitchStream.cs in je solution explorer in visual studio

            //geef nu de stream de volgende waardes:




            //name, waarde: je favoriete streamer
            //lastStreamName, waarde: de streamname van de laatste keer
            //streamGame, waarde een nieuwe instance van Game (new Game("naam van de game hier"})
            //followers, waarde: hoeveel followers
            //automod, waarde: staat automod aan?



            TwitchStream twitchStream = new TwitchStream();
            twitchStream.streamGame = new Game("Dart Souls");
            twitchStream.name = "Daz_Black";
            twitchStream.LastStreamName = "Chatting And Playing Games!";
            twitchStream.followers = 8321976;
            twitchStream.automod = true;




            Console.WriteLine(twitchStream.LastStreamName);
            Console.WriteLine(twitchStream.streamGame);
            Console.WriteLine(twitchStream.name);
            Console.WriteLine(twitchStream.LastStreamName);
            Console.WriteLine(twitchStream.followers);
            Console.WriteLine(twitchStream.automod);
        }
    }
}