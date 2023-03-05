using Sccg.Builtin.Sources;

namespace Necodark.Source;

public class VimFiletypeHighlight : VimCustomGroupSource
{
    public override string Name => "VimFiletypeHighlight";

    protected override void Custom()
    {
        Set("diffAdded", fg: C.GitAdd, none: true);
        Set("diffRemoved", fg: C.GitDelete, none: true);
        Set("diffChanged", fg: C.GitChange, none: true);
        Set("diffOldFile", fg: C.WarnYellow, none: true);
        Set("diffNewFile", fg: C.HintGreen, none: true);
        Set("diffFile", fg: C.InfoBlue, none: true);
    }
}