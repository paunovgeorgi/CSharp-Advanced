string[] songsInput = Console.ReadLine().Split(", ");
Queue<string> songs = new(songsInput);
string input;
while (songs.Any())
{
    string tokens = Console.ReadLine();
    switch (tokens)
    {
        case "Play":
            songs.Dequeue();
            break;
        case "Show":
            Console.WriteLine(string.Join(", ", songs));
            break;
        default:
            string song = tokens.Remove(0, 4);
            if (!songs.Contains(song))
            {
                songs.Enqueue(song);
            }
            else
            {
                Console.WriteLine($"{song} is already contained!");
            }
            break;
    }
}
Console.WriteLine("No more songs!");