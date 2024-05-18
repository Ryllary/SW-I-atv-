namespace exe07
{
    class Program
    {
        static void Main(string[] args)
        {
            Playlist minhaPlaylist = new Playlist("Eu");

            minhaPlaylist.AdicionarMusica(new Musica("Shape of You", "Ed Sheeran", "Atlantic Records"));
            minhaPlaylist.AdicionarMusica(new Musica("Havana", "Camila Cabello", "Epic Records"));

            minhaPlaylist.TocarMusicaAleatoria();
            minhaPlaylist.TocarMusicaAleatoria();
            minhaPlaylist.TocarMusicaAleatoria();
        }
    }
}