namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            DVDPlayer dvdPlayer = new DVDPlayer();
            Lights lights = new Lights();
            MusicPlayer musicPlayer = new MusicPlayer();
            Projector projector = new Projector();

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(dvdPlayer, lights, musicPlayer, projector);

            homeTheater.WatchMovie("Bad grandpa");
            System.Threading.Thread.Sleep(2000);
            dvdPlayer.Pause();
            dvdPlayer.Continue();
            homeTheater.StopMovie();
        }
    }
}
