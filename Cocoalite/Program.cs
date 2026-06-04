//using Cocoalite.Views;

//namespace Cocoalite
//{
//    internal static class Program
//    {
//        /// <summary>
//        ///  The main entry point for the application.
//        /// </summary>
//        [STAThread]
//        static void Main()
//        {
//            // To customize application configuration such as set high DPI settings or default font,
//            // see https://aka.ms/applicationconfiguration.
//            ApplicationConfiguration.Initialize();
//            Application.Run(new FormSuppliers());
//        }
//    }
//}
using Cocoalite.Views;

namespace Cocoalite
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            //Application.Run(new FormReceiving());
            //Application.Run(new FormQualityControl());
            //Application.Run(new FormBatch());
            Application.Run(new FormInventory());
            //Application.Run(new FormShipment());
            //Application.Run(new FormLogin());
        }
    }
}