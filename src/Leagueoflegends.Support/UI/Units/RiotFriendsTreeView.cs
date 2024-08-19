using Jamesnet.Uno;

namespace Leagueoflegends.Support.UI.Units;

public class RiotFriendsTreeViewItem : RecursiveControlItem
{
    public RiotFriendsTreeViewItem()
    {
        DefaultStyleKey = typeof(RiotFriendsTreeViewItem);
    }

    protected override RecursiveControlItem GetContainerForItem()
    {
        return new RiotFriendsUserTreeViewItem();
    }
}

public class RiotFriendsUserTreeViewItem : RecursiveControlItem
{
    public RiotFriendsUserTreeViewItem()
    {
        DefaultStyleKey = typeof(RiotFriendsUserTreeViewItem);
    }
}
