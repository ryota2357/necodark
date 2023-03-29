using Sccg.Builtin.Sources;

namespace Necodark.Source;

public class NeovimPluginHighlight : VimCustomGroupSource
{
    public override string Name => "VimPluginHighlight";

    protected override void Custom()
    {
        // lewis6991/gitsigns.nvim
        Set("GitSignsAdd", fg: C.GitAdd, none: true);
        Set("GitSignsChange", fg: C.GitChange, none: true);
        Set("GitSignsDelete", fg: C.GitDelete, none: true);

        // rcarriga/nvim-notify
        Set("NotifyERRORBorder", fg: Color.AlphaBlend(C.ErrorRed, S.NormalText.Background, 0.5f), none: true);
        Set("NotifyWARNBorder", fg: Color.AlphaBlend(C.WarnYellow, S.NormalText.Background, 0.45f), none: true);
        Set("NotifyINFOBorder", fg: Color.AlphaBlend(C.InfoBlue, S.NormalText.Background, 0.5f), none: true);
        Set("NotifyDEBUGBorder", fg: Color.AlphaBlend(S.CommentGray.Foreground, S.NormalText.Background, 0.9f), none: true);
        Set("NotifyTRACEBorder", fg: Color.AlphaBlend(S.StatementIndigo.Foreground, S.NormalText.Background, 0.5f), none: true);
        Set("NotifyERRORIcon", fg: C.ErrorRed, none: true);
        Set("NotifyWARNIcon", fg: C.WarnYellow, none: true);
        Set("NotifyINFOIcon", fg: C.InfoBlue, none: true);
        Set("NotifyDEBUGIcon", fg: S.CommentGray.Foreground, none: true);
        Set("NotifyTRACEIcon", fg: S.StatementIndigo.Foreground, none: true);
        Set("NotifyERRORTitle", fg: C.ErrorRed);
        Set("NotifyWARNTitle", fg: C.WarnYellow);
        Set("NotifyINFOTitle", fg: C.InfoBlue);
        Set("NotifyDEBUGTitle", fg: S.CommentGray.Foreground);
        Set("NotifyTRACETitle", fg: S.StatementIndigo.Foreground);

        // RRethy/vim-illuminate
        var illuminated = new Style(fg: Color.None, bg: Color.AlphaBlend(S.SelectRangeWhite.Background, S.NormalText.Background, 0.55f));
        Set("IlluminatedWordText", illuminated);
        Set("IlluminatedWordRead", illuminated);
        Set("IlluminatedWordWrite", illuminated);

        // j-hui/fidget.nvim
        Set("FidgetTitle", fg: Color.AlphaBlend(C.InfoBlue, S.NormalText.Background, 0.9f), bg: Color.None, bold: true);
        Set("FidgetTask", fg: S.CommentGray.Foreground, bg: Color.None, none: true);
    }
}