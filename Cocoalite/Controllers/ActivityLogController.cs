using System.Collections.Generic;
using Cocoalite.Models.Context;
using Cocoalite.Models.Entity;

namespace Cocoalite.Controllers
{
    internal class ActivityLogController
    {
        private readonly ActivityLogContext context =
            new ActivityLogContext();

        public List<ActivityLog> GetAllActivityLogs()
        {
            return context.GetAll();
        }
    }
}