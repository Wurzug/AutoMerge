
using AutoMerge.Base;
using Microsoft.TeamFoundation.Controls;

namespace AutoMerge
{
	[TeamExplorerPage(GuidList.AutoMergePageId)]
	public class AutoMergePage : TeamExplorerPageBase
	{

		/// <summary>
		/// Constructor.
		/// </summary>
		public AutoMergePage()
		{
			Title = Resources.AutoMergePageName;
		}
	}

    [TeamExplorerPage(GuidList.AutoMergeTeamPageId)]
    public class AutoMergeTeamPage : TeamExplorerPageBase
    {
        public AutoMergeTeamPage()
        {
            Title = Resources.AutoMergePageName;
        }
    }
}
