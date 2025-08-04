namespace prjKpopIndexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Groups kpop = new Groups("Ateez", "Male",8, 222, "Lemon Drop");

            kpop[0] = "Ateez";

            Console.WriteLine(kpop[0]);
            Console.WriteLine(kpop[1]);
            Console.WriteLine(kpop[2]);
            Console.WriteLine(kpop[3]);
            Console.WriteLine(kpop[4]);

            Groups kpop2 = new Groups("Stray Kids", "Male", 8, 331, "Thunderous");

            kpop["songs"] = 223;

            Console.WriteLine("name: " + kpop2["name"]);
            Console.WriteLine("gender: " + kpop2["gender"]);
            Console.WriteLine("number of Members: " + kpop2["members"]);
            Console.WriteLine("number of songs: " + kpop2["songs"]);
            Console.WriteLine("popular Song: " + kpop2["popularSong"]);
        }
    }
}
