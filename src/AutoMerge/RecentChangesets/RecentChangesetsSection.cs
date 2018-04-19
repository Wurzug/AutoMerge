using AutoMerge.Base;
using AutoMerge.RecentChangesets.Team;
using Microsoft.TeamFoundation.Controls;

namespace AutoMerge
{
	[TeamExplorerSection(GuidList.RecentChangesetsSectionId, GuidList.AutoMergePageId, 10)]
	public class RecentChangesetsSection : TeamExplorerSectionBase
	{
		protected override ITeamExplorerSection CreateViewModel(SectionInitializeEventArgs e)
		{
			var viewModel = base.CreateViewModel(e) ?? new RecentChangesetsViewModel(new VsLogger(ServiceProvider));

			return viewModel;
		}

		protected override object CreateView(SectionInitializeEventArgs e)
		{
            return new RecentChangesetsView();
		}
	}

    [TeamExplorerSection(GuidList.RecentChangesetsTeamSectionId, GuidList.AutoMergeTeamPageId, 11)]
    public class RecentChangesetsTeamSection : TeamExplorerSectionBase
    {
        protected override ITeamExplorerSection CreateViewModel(SectionInitializeEventArgs e)
        {
            return base.CreateViewModel(e) ?? new RecentChangesetsTeamViewModel(new VsLogger(ServiceProvider));
        }

        protected override object CreateView(SectionInitializeEventArgs e)
        {
            return new RecentChangesetsTeamView();
        }
    }
}
