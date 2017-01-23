namespace Facade
{
    public class HomeTheaterFacade
    {
        private readonly DVDPlayer _dvdPlayer;
        private readonly Lights _lights;
        private readonly MusicPlayer _musicPlayer;
        private readonly Projector _projector;

        public HomeTheaterFacade(DVDPlayer dvdPlayer, Lights lights, MusicPlayer musicPlayer, Projector projector)
        {
            _dvdPlayer = dvdPlayer;
            _lights = lights;
            _musicPlayer = musicPlayer;
            _projector = projector;
        }

        public void WatchMovie(string movie)
        {
            _lights.SetBrightness(20);
            _dvdPlayer.Play(movie);
            _musicPlayer.TurnOn();
            _projector.RollDown();
        }

        public void StopMovie()
        {
            _lights.SetBrightness(0);
            _dvdPlayer.Stop();
            _musicPlayer.TurnOff();
            _projector.RollUp();
        }
    }
}