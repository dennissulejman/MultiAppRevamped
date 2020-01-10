namespace MultiAppRevamped.MiniApplications
{
    internal interface IMiniApplication
    {
        void WriteWelcomeMessage();
        void StartApplication();
        MainMenu ReturnToMainMenu();
    }
}
