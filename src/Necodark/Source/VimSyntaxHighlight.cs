using Sccg.Builtin.Sources;

namespace Necodark.Source;

public class VimSyntaxHighlight : VimSyntaxGroupSource
{
    protected override void Custom()
    {
        foreach (var group in Enum.GetValues<Group>())
        {
            var style = group switch
            {
                Group.Comment => S.CommentGray,
                Group.Constant => S.NormalText,
                Group.String => S.StringLiteralOrange,
                Group.Character => S.StringLiteralOrange,
                Group.Number => S.NumberLiteralPink,
                Group.Boolean => S.BooleanLiteralTeal,
                Group.Float => S.BooleanLiteralTeal,
                Group.Identifier => S.VariableLightCyan,
                Group.Function => S.FunctionAmber,
                Group.Statement => S.StatementIndigo,
                Group.Conditional => S.StatementIndigo,
                Group.Repeat => S.StatementIndigo,
                Group.Label => S.StatementIndigo,
                Group.Operator => S.OperatorSilver,
                Group.Keyword => S.KeywordBlue,
                Group.Exception => S.StatementIndigo,
                Group.PreProc => S.KeywordBlue,
                Group.Include => S.KeywordBlue,
                Group.Define => S.KeywordBlue,
                Group.Macro => S.KeywordBlue,
                Group.PreCondit => S.KeywordBlue,
                Group.Type => S.KeywordBlue,
                Group.StorageClass => S.KeywordBlue,
                Group.Structure => S.KeywordBlue,
                Group.Typedef => S.KeywordBlue,
                Group.Special => S.KeywordBlue,
                Group.SpecialChar => S.StringLiteralOrange,
                Group.Tag => S.NormalText,
                Group.Delimiter => S.NormalText,
                Group.SpecialComment => S.CommentGray,
                Group.Debug => S.NormalText,
                Group.Underlined => S.NormalText with { Underline = true },
                Group.Error => new Style(fg: C.ErrorRed, bg: Color.None, none: true),
                Group.Todo => new Style(fg: C.WarnYellow, bg: Color.None, none: true),
                _ => throw new ArgumentOutOfRangeException()
            };
            Set(group, style);
        }
    }
}