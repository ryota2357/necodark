using Sccg.Builtin.Sources;

namespace Necodark.Source;

public class NeovimLspDiagnosticHighlight : NeovimLspDiagnosticHighlightSource
{
    protected override void Custom()
    {
        Set(Group.DiagnosticError, fg: C.ErrorRed);
        Set(Group.DiagnosticWarn, fg: C.WarnYellow);
        Set(Group.DiagnosticInfo, fg: C.InfoBlue);
        Set(Group.DiagnosticHint, fg: C.HintGreen);

        Set(Group.DiagnosticVirtualTextError, fg: C.ErrorRed, bg: Darken(C.ErrorRed), italic: true);
        Set(Group.DiagnosticVirtualTextWarn, fg: C.WarnYellow, bg: Darken(C.WarnYellow), italic: true);
        Set(Group.DiagnosticVirtualTextInfo, fg: C.InfoBlue, bg: Darken(C.InfoBlue), italic: true);
        Set(Group.DiagnosticVirtualTextHint, fg: C.HintGreen, bg: Darken(C.HintGreen), italic: true);

        Set(Group.DiagnosticUnderlineError, sp: C.ErrorRed, underlineWaved: true);
        Set(Group.DiagnosticUnderlineWarn, sp: C.WarnYellow, underlineWaved: true);
        Set(Group.DiagnosticUnderlineInfo, sp: C.InfoBlue, underlineWaved: true);
        Set(Group.DiagnosticUnderlineHint, sp: C.HintGreen, underlineWaved: true);
    }

    private static Color Darken(Color color)
    {
        return Color.AlphaBlend(color, S.NormalText.Background, 0.15f);
    }
}