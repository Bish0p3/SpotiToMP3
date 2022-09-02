namespace ViewModels.SpotiToMP3
{
    public class WelcomeWindow_VM
    {
        // Constructor
        public WelcomeWindow_VM()
        {

        }

        // Private fields
        private string instructions = "1. Log into your Spotify account \n2. Select playlist you want to download\n3. Program downloads your selected playlist songs \n4. Enjoy your music! :)";

        public string Instructions
        {
            get
            {
                return instructions;
            }
            set
            {
                instructions = value;
            }
        }
    }

}