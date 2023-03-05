using Sccg.Builtin.Sources;

namespace Necodark.Source;

public class NeovimEditorHighlight : NeovimEditorHighlightSource
{
    protected override void Custom()
    {
        Set(Group.ColorColumn, bg: S.HideText.Foreground);

        Set(Group.Conceal, S.HideText);

        Set(Group.CurSearch, fg: S.NormalText.Background, bg: S.BooleanLiteralTeal.Foreground);
        Link(Group.IncSearch, Group.CurSearch);
        Set(Group.Search, S.SelectRangeBlue);

        Set(Group.Cursor, fg: S.NormalText.Background, bg: S.NormalText.Foreground);
        Link(Group.lCursor, Group.Cursor);
        Link(Group.CursorIM, Group.Cursor);

        Link(Group.CursorColumn, Group.CursorLine);
        Set(Group.CursorLine, S.CursorLine);

        Set(Group.Directory, S.VariableLightCyan);

        Set(Group.DiffAdd, bg: Color.AlphaBlend(C.GitAdd, S.NormalText.Background, 0.2f));
        Set(Group.DiffChange, bg: Color.AlphaBlend(C.GitChange, S.NormalText.Background, 0.2f));
        Set(Group.DiffDelete, bg: Color.AlphaBlend(C.GitDelete, S.NormalText.Background, 0.2f));
        Set(Group.DiffText, bg: Color.AlphaBlend(C.GitChange, S.NormalText.Background, 0.4f));

        Link(Group.EndOfBuffer, Group.NonText);

        // TermCursor
        // TermCursorNC

        Set(Group.ErrorMsg, fg: C.ErrorRed);

        Set(Group.WinSeparator, fg: "000", bg: Color.None);

        Set(Group.Folded, S.CommentGray with { Bold = true });
        Set(Group.FoldColumn, Style.Default);

        Set(Group.SignColumn, fg: S.NormalText.Foreground, bg: Color.None);

        // IncSearch (setting at CurSearch)

        // Substitute

        Set(Group.LineNr, S.CommentGray);
        // LineNrAbove
        // LineNrBelow
        Set(Group.CursorLineNr, S.NormalText);
        // CursorLineFold
        // CursorLineSign

        Set(Group.MatchParen, S.SelectRangeWhite);

        Set(Group.ModeMsg, S.CommentGray with { Italic = true });
        Link(Group.MsgArea, Group.Normal);
        // MsgSeparator
        Set(Group.MoreMsg, S.CommentGray with { Bold = true });

        Set(Group.NonText, S.HideText);

        Set(Group.Normal, S.NormalText);
        Set(Group.NormalFloat, S.PopupText);
        Set(Group.FloatBorder, fg: Color.AlphaBlend(S.NormalText.Foreground, S.NormalText.Background, 0.65f), bg: Color.None);
        Link(Group.NormalNC, Group.Normal);

        Set(Group.Pmenu, S.PopupText);
        Set(Group.PmenuSel, S.SelectRangeWhite);
        // PmenuSbar
        // PmenuThumb

        // Question

        // QuickFixLine

        // Search (setting at CurSearch)

        Set(Group.SpecialKey, S.CommentGray with { Bold = true });

        // SpellBad
        // SpellCap
        // SpellLocal
        // SpellRare

        Set(Group.StatusLine, S.NormalText with { Background = S.SelectRangeWhite.Background });
        Set(Group.StatusLineNC, S.NormalText);

        Set(Group.TabLine, S.CommentGray);
        Set(Group.TabLineFill, Style.Default);
        Set(Group.TabLineSel, S.NormalText);

        Set(Group.Title, S.StringLiteralOrange with { Bold = true });

        Set(Group.Visual, S.SelectRangeBlue);
        Link(Group.VisualNOS, Group.Visual);

        Set(Group.WarningMsg, new Style(fg: C.WarnYellow, bg: Color.None, none: true));

        Set(Group.Whitespace, S.HideText);

        // WildMenu

        // WinBar
        // WinBarNC

        // Menu

        // Scrollbar

        // Tooltip
    }
}