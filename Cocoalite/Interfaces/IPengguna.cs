using System;
using System.Collections.Generic;
using System.Text;

namespace Cocoalite.Interfaces
{
    internal interface IPengguna
    {
        string Username { get; set; }
        string Role { get; }

        string TampilkanInfoUser();
        string TampilkanHakAkses();
    }
}
