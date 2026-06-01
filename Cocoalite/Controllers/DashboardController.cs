using Cocoalite.Models.Context;
using Cocoalite.Models.Entity;

namespace Cocoalite.Controllers
{
    internal class DashboardController
    {
        private readonly DashboardContext context =
            new DashboardContext();

        public DashboardSummary GetDashboardSummary()
        {
            return context.GetSummary();
        }
    }
}