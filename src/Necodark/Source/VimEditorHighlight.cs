using Sccg.Builtin.Sources;

namespace Necodark.Source;

using NvimGroup = NeovimEditorHighlightSource.Group;

public class VimEditorHighlight : VimEditorHighlightSource
{
    public override int Priority => 20; // must after NeovimEditorHighlight

    protected override void Custom(BuilderQuery query)
    {
        var neovimItems = query.GetSourceItems<NeovimEditorHighlightSource.Item>();
        var styleMap = new Dictionary<NvimGroup, Style>();
        foreach (var item in neovimItems)
        {
            if (item.Style is not null)
            {
                styleMap[item.Group] = item.Style.Value;
            }
        }

        foreach (var group in Enum.GetValues<Group>())
        {
            NvimGroup? nvimGroup = group switch
            {
                Group.ColorColumn => NvimGroup.ColorColumn,
                Group.Conceal => NvimGroup.Conceal,
                Group.Cursor => NvimGroup.Cursor,
                Group.lCursor => NvimGroup.lCursor,
                Group.CursorIM => NvimGroup.CursorIM,
                Group.CursorColumn => NvimGroup.CursorColumn,
                Group.CursorLine => NvimGroup.CursorLine,
                Group.Directory => NvimGroup.Directory,
                Group.DiffAdd => NvimGroup.DiffAdd,
                Group.DiffChange => NvimGroup.DiffChange,
                Group.DiffDelete => NvimGroup.DiffDelete,
                Group.DiffText => NvimGroup.DiffText,
                Group.EndOfBuffer => NvimGroup.EndOfBuffer,
                Group.ErrorMsg => NvimGroup.ErrorMsg,
                Group.VertSplit => null,
                Group.Folded => NvimGroup.Folded,
                Group.FoldColumn => NvimGroup.FoldColumn,
                Group.SignColumn => NvimGroup.SignColumn,
                Group.IncSearch => NvimGroup.IncSearch,
                Group.LineNr => NvimGroup.LineNr,
                Group.LineNrAbove => NvimGroup.LineNrAbove,
                Group.LineNrBelow => NvimGroup.LineNrBelow,
                Group.CursorLineNr => NvimGroup.CursorLineNr,
                Group.CursorLineFold => NvimGroup.CursorLineFold,
                Group.CursorLineSign => NvimGroup.CursorLineSign,
                Group.MatchParen => NvimGroup.MatchParen,
                Group.MessageWindow => null,
                Group.ModeMsg => NvimGroup.ModeMsg,
                Group.MoreMsg => NvimGroup.MoreMsg,
                Group.NonText => NvimGroup.NonText,
                Group.Normal => NvimGroup.Normal,
                Group.Pmenu => NvimGroup.Pmenu,
                Group.PmenuSel => NvimGroup.PmenuSel,
                Group.PmenuSbar => NvimGroup.PmenuSbar,
                Group.PmenuThumb => NvimGroup.PmenuThumb,
                Group.PopupNotification => null,
                Group.Question => NvimGroup.Question,
                Group.QuickFixLine => NvimGroup.QuickFixLine,
                Group.Search => NvimGroup.Search,
                Group.CurSearch => NvimGroup.CurSearch,
                Group.SpecialKey => NvimGroup.Whitespace,
                Group.SpellBad => NvimGroup.SpellBad,
                Group.SpellCap => NvimGroup.SpellCap,
                Group.SpellLocal => NvimGroup.SpellLocal,
                Group.SpellRare => NvimGroup.SpellRare,
                Group.StatusLine => NvimGroup.StatusLine,
                Group.StatusLineNC => NvimGroup.StatusLineNC,
                Group.StatusLineTerm => null,
                Group.StatusLineTermNC => null,
                Group.TabLine => NvimGroup.TabLine,
                Group.TabLineFill => NvimGroup.TabLineFill,
                Group.TabLineSel => NvimGroup.TabLineSel,
                Group.Terminal => null,
                Group.Title => NvimGroup.Title,
                Group.Visual => NvimGroup.Visual,
                Group.VisualNOS => NvimGroup.VisualNOS,
                Group.WarningMsg => NvimGroup.WarningMsg,
                Group.WildMenu => NvimGroup.WildMenu,
                Group.Menu => NvimGroup.Menu,
                Group.Scrollbar => NvimGroup.Scrollbar,
                Group.Tooltip => NvimGroup.Tooltip,
                _ => throw new Exception("not found")
            };

            if (nvimGroup is null)
            {
                continue;
            }

            if (styleMap.TryGetValue(nvimGroup.Value, out var style))
            {
                Set(group, style);
            }
        }
    }
}