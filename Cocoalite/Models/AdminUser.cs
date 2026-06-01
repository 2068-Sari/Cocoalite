using System;
using System.Collections.Generic;
using System.Text;

namespace Cocoalite.Models
{
    internal class AdminUser : AppUser
    {
        public AdminUser()
        {
            Role = "admin";
        }

        public override string TampilkanHakAkses()
        {
            return "Admin mengelola supplier, receiving, batch, inventory, shipment, dashboard, dan laporan operasional.";
        }
    }
}
