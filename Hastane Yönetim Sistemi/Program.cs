namespace Hastane_Yönetim_Sistemi
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new AnaMenu());
        }
    }
}