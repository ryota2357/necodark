using Sccg.Builtin.Sources;

namespace Necodark.Source;

public class VSCodeEditorHightlight : VSCodeEditorThemeColorSource
{
    protected override void Custom(BuilderQuery query)
    {
        // Base colors
        Set(Group.Foreground, S.NormalText.Foreground);

        // Side Bar
        Set(Group.SideBarBackground, "#000");

        // Status Bar colors
        Set(Group.StatusBarBackground, S.SelectRangeWhite.Background);
    }
}