using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TeamExplorerSectionViewModelBase = AutoMerge.Base.TeamExplorerSectionViewModelBase;

namespace AutoMerge.RecentChangesets.Team
{
    public class RecentChangesetsTeamViewModel : TeamExplorerSectionViewModelBase
    {
        public RecentChangesetsTeamViewModel(ILogger logger)
            : base(logger)
        {
        }
    }
}
