namespace DesignPatterns.AdapterFacade
{
    public class HomeTheaterFacade
    {
        Screen screen;
        Lights lights;
        Stereo stereo;

        public HomeTheaterFacade(Screen screen, Lights lights, Stereo stereo)
        {
            this.screen = screen;
            this.lights = lights;
            this.stereo = stereo;
        }

        public void WatchMovie()
        {
            screen.On();
            lights.On();
            stereo.On();
            lights.Dim();
        }
    }
}
