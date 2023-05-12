using Sccg.Builtin.Sources;

namespace Necodark.Source;

using TS = NeovimTreesitterHighlightSource.Group;

public class TextMateHighlight : TextMateElementSource
{
    public override int Priority => 30;  // after NeovimTreesitterHighlight

    protected override void Custom(BuilderQuery query)
    {
        var hi = new Dictionary<TS, Style>();
        foreach (var tsh in query.GetSourceItems<NeovimTreesitterHighlightSource.Item>())
        {
            if (tsh.Style is null || tsh.Group.filetype is not null)
            {
                continue;
            }
            hi[tsh.Group.name] = tsh.Style.Value;
        }

        Set(Group.Comment, hi[TS.Comment]);
        Link(Group.CommentLine, Group.Comment);
        Link(Group.CommentLineDouble_slash, Group.Comment);
        Link(Group.CommentLineDouble_dash, Group.Comment);
        Link(Group.CommentLineNumber_sign, Group.Comment);
        Link(Group.CommentLinePercentage, Group.Comment);
        Link(Group.CommentLineCharacter, Group.Comment);
        Link(Group.CommentBlock, Group.Comment);
        // Group.CommentBlockDocumentation => expr,

        Set(Group.Constant, hi[TS.Constant]);
        Set(Group.ConstantNumeric, hi[TS.Number]);
        Set(Group.ConstantCharacter, hi[TS.Character]);
        Set(Group.ConstantCharacterEscape, hi[TS.Character]);
        Set(Group.ConstantLanguage, hi[TS.Constant]);
        Set(Group.ConstantOther, hi[TS.Constant]);

        Set(Group.Entity, S.NormalText);
        Set(Group.EntityName, S.NormalText);
        Set(Group.EntityNameFunction, hi[TS.Function]);
        Set(Group.EntityNameType, hi[TS.Type]);
        Set(Group.EntityNameTag, hi[TS.Tag]);
        Set(Group.EntityNameSection, hi[TS.Label]);
        // Group.EntityOther => expr,
        // Group.EntityOtherInherited_class => expr,
        Set(Group.EntityOtherAttribute_name, hi[TS.Attribute]);

        // Group.Invalid => expr,
        // Group.InvalidIllegal => expr,
        // Group.InvalidDeprecated => expr,

        Set(Group.Keyword, hi[TS.Keyword]);
        Set(Group.KeywordControl, hi[TS.Conditional]);
        Set(Group.KeywordOperator, hi[TS.Operator]);
        Link(Group.KeywordOther, Group.Keyword);

        // Group.Markup => expr,
        // Group.MarkupUnderline => expr,
        // Group.MarkupUnderlineLink => expr,
        // Group.MarkupBold => expr,
        // Group.MarkupHeading => expr,
        // Group.MarkupItalic => expr,
        // Group.MarkupList => expr,
        // Group.MarkupListNumbered => expr,
        // Group.MarkupListUnnumbered => expr,
        // Group.MarkupQuote => expr,
        // Group.MarkupRaw => expr,
        // Group.MarkupOther => expr,

        // Group.Meta => expr,
        Set(Group.Meta, S.NormalText);

        Set(Group.Storage, S.KeywordBlue);
        Link(Group.StorageType, Group.Storage);
        Link(Group.StorageModifier, Group.Storage);

        Set(Group.String, hi[TS.String]);
        Link(Group.StringQuoted, Group.String);
        Link(Group.StringQuotedSingle, Group.String);
        Link(Group.StringQuotedDouble, Group.String);
        Link(Group.StringQuotedTriple, Group.String);
        Link(Group.StringQuotedOther, Group.String);

        // Group.StringUnquoted => expr,
        // Group.StringInterpolated => expr,
        // Group.StringRegexp => expr,
        // Group.StringOther => expr,

        Set(Group.Support, S.NormalText);
        Set(Group.SupportFunction, hi[TS.FunctionBuiltin]);
        Set(Group.SupportClass, hi[TS.TypeBuiltin]);
        Set(Group.SupportType, hi[TS.TypeBuiltin]);
        Set(Group.SupportConstant, hi[TS.ConstantBuiltin]);
        Set(Group.SupportVariable, hi[TS.VariableBuiltin]);
        // Group.SupportOther => expr,

        Set(Group.Variable, hi[TS.Variable]);
        Link(Group.VariableParameter, Group.Variable);
        // Group.VariableLanguage => expr,
        // Group.VariableOther => expr,
    }
}