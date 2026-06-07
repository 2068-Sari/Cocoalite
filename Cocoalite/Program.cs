
using Cocoalite.Views;
using QuestPDF.Infrastructure;

namespace Cocoalite
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            QuestPDF.Settings.License = LicenseType.Community;
            ApplicationConfiguration.Initialize();
            //Application.Run(new FormReceiving());
            //Application.Run(new FormQualityControl());

            //Application.Run(new FormBatch());
            //Application.Run(new FormInventory());

            //Application.Run(new FormBatch());
            //Application.Run(new FormInventory());

            //Application.Run(new FormShipment());
            //Application.Run(new FormLogin());
            Application.Run(new FormLogin());
        }
    }
}