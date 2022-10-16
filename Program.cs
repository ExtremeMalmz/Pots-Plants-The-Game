namespace Pot_Plant_the_Game
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            /// <summary>
            ///  Main method for the application. Creation of the Form1 (windows form) class is created here along with the initialization
            /// </summary>
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}