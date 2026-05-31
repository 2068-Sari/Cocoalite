using System;
using System.Collections.Generic;

namespace ManajemenInventaris
{
    public interface IDapatDilaporkan
    {
        string GetRingkasan();
        Dictionary<string, object> GetDetailLog();
    }
}
