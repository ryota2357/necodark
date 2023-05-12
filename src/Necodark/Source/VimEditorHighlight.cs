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

        Style H(NvimGroup group)
        {
            return styleMap.TryGetValue(group, out var style) ? style : Style.Default;
        }

        foreach (var group in Enum.GetValues<Group>())
        {
            Style? style = group switch
            {
                Group.ColorColumn => H(NvimGroup.ColorColumn),
                Group.Conceal => H(NvimGroup.Conceal),
                Group.Cursor => H(NvimGroup.Cursor),
                Group.lCursor => H(NvimGroup.lCursor),
                Group.CursorIM => H(NvimGroup.CursorIM),
                Group.CursorColumn => H(NvimGroup.CursorColumn),
                Group.CursorLine => H(NvimGroup.CursorLine),
                Group.Directory => H(NvimGroup.Directory),
                Group.DiffAdd => H(NvimGroup.DiffAdd),
                Group.DiffChange => H(NvimGroup.DiffChange),
                Group.DiffDelete => H(NvimGroup.DiffDelete),
                Group.DiffText => H(NvimGroup.DiffText),
                Group.EndOfBuffer => H(NvimGroup.EndOfBuffer),
                Group.ErrorMsg => H(NvimGroup.ErrorMsg),
                Group.VertSplit => null,
                Group.Folded => H(NvimGroup.Folded),
                Group.FoldColumn => H(NvimGroup.FoldColumn),
                Group.SignColumn => H(NvimGroup.SignColumn),
                Group.IncSearch => H(NvimGroup.IncSearch),
                Group.LineNr => H(NvimGroup.LineNr),
                Group.LineNrAbove => H(NvimGroup.LineNrAbove),
                Group.LineNrBelow => H(NvimGroup.LineNrBelow),
                Group.CursorLineNr => H(NvimGroup.CursorLineNr),
                Group.CursorLineFold => H(NvimGroup.CursorLineFold),
                Group.CursorLineSign => H(NvimGroup.CursorLineSign),
                Group.MatchParen => H(NvimGroup.MatchParen),
                Group.MessageWindow => null,
                Group.ModeMsg => H(NvimGroup.ModeMsg),
                Group.MoreMsg => H(NvimGroup.MoreMsg),
                Group.NonText => H(NvimGroup.NonText),
                Group.Normal => H(NvimGroup.Normal),
                Group.Pmenu => H(NvimGroup.Pmenu),
                Group.PmenuSel => H(NvimGroup.PmenuSel),
                Group.PmenuSbar => H(NvimGroup.PmenuSbar),
                Group.PmenuThumb => H(NvimGroup.PmenuThumb),
                Group.PopupNotification => null,
                Group.Question => H(NvimGroup.Question),
                Group.QuickFixLine => H(NvimGroup.QuickFixLine),
                Group.Search => H(NvimGroup.Search),
                Group.CurSearch => H(NvimGroup.CurSearch),
                Group.SpecialKey => H(NvimGroup.Whitespace),
                Group.SpellBad => H(NvimGroup.SpellBad) with { Background = Color.None },
                Group.SpellCap => H(NvimGroup.SpellCap) with { Background = Color.None} ,
                Group.SpellLocal => H(NvimGroup.SpellLocal) with { Background = Color.None },
                Group.SpellRare => H(NvimGroup.SpellRare) with { Background = Color.None },
                Group.StatusLine => H(NvimGroup.StatusLine),
                Group.StatusLineNC => H(NvimGroup.StatusLineNC),
                Group.StatusLineTerm => null,
                Group.StatusLineTermNC => null,
                Group.TabLine => H(NvimGroup.TabLine),
                Group.TabLineFill => H(NvimGroup.TabLineFill),
                Group.TabLineSel => H(NvimGroup.TabLineSel),
                Group.Terminal => null,
                Group.Title => H(NvimGroup.Title),
                Group.Visual => H(NvimGroup.Visual),
                Group.VisualNOS => H(NvimGroup.VisualNOS),
                Group.WarningMsg => H(NvimGroup.WarningMsg),
                Group.WildMenu => H(NvimGroup.WildMenu),
                Group.Menu => H(NvimGroup.Menu),
                Group.Scrollbar => H(NvimGroup.Scrollbar),
                Group.Tooltip => H(NvimGroup.Tooltip),
                _ => throw new Exception("not found")
            };

            if (style is null)
            {
                continue;
            }
            Set(group, style.Value);
        }
    }
}