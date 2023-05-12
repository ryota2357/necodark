using Sccg.Builtin.Sources;

namespace Necodark.Source;

using VimSyntax = VimSyntaxGroupSource.Group;

public class NeovimTreesitterHighlight : NeovimTreesitterHighlightSource
{
    public override int Priority => 20;

    protected override void Custom(BuilderQuery query)
    {
        // Misc
        Link(Group.Comment, VimSyntax.Comment);
        // @comment.documentation ; comments documenting code
        Link(Group.Error, VimSyntax.Error);
        Set(Group.None, fg: Color.None, bg: Color.None, sp: Color.None, none: true);
        Link(Group.Preproc, VimSyntax.PreProc);
        Link(Group.Define, VimSyntax.Define);
        Link(Group.Operator, VimSyntax.Operator);

        // Punctuation
        Set(Group.PunctuationDelimiter, S.NormalText);
        Set(Group.PunctuationBracket, S.NormalText);
        Set(Group.PunctuationSpecial, S.OperatorSilver);

        // Literals
        Set(Group.String, S.StringLiteralOrange);
        // @string.documentation ; string documenting code (e.g. Python docstrings)
        // @string.regex         ; regular expressions
        // @string.escape        ; escape sequences
        // @string.special       ; other special strings (e.g. dates)
        Set(Group.Character, S.StringLiteralOrange);
        // @character.special    ; special characters (e.g. wildcards)
        Link(Group.Boolean, VimSyntax.Boolean);
        Link(Group.Number, VimSyntax.Number);
        Link(Group.Float, VimSyntax.Float);

        // Functions
        Link(Group.Function, VimSyntax.Function);
        Link(Group.FunctionBuiltin, Group.Function);
        Link(Group.FunctionCall, Group.Function);
        Link(Group.FunctionMacro, Group.Function);
        Link(Group.Method, VimSyntax.Function);
        Link(Group.MethodCall, Group.Method);
        Set(Group.Constructor, S.TypeGreen);
        Filetype("lua", () => Link(Group.Constructor, Group.PunctuationBracket));
        Set(Group.Parameter, S.VariableLightCyan);

        // Keywords
        Link(Group.Keyword, VimSyntax.Keyword);
        Link(Group.KeywordCoroutine, Group.Keyword);
        Link(Group.KeywordFunction, Group.Keyword);
        Set(Group.KeywordOperator, S.StatementIndigo);
        Link(Group.KeywordReturn, Group.Keyword);
        Link(Group.Conditional, VimSyntax.Conditional);
        Set(Group.ConditionalTernary, S.StatementIndigo);
        Link(Group.Repeat, VimSyntax.Repeat);
        Link(Group.Debug, VimSyntax.Debug);
        Link(Group.Label, VimSyntax.Label);
        Link(Group.Include, VimSyntax.Include);
        Link(Group.Exception, VimSyntax.Exception);

        // Types
        Set(Group.Type, S.TypeGreen);
        Set(Group.TypeBuiltin, S.KeywordBlue);
        Link(Group.TypeQualifier, Group.TypeBuiltin);
        Link(Group.Storageclass, Group.TypeBuiltin);
        // @attribute       ; attribute annotations (e.g. Python decorators)
        Set(Group.Field, S.VariableLightCyan);
        Set(Group.Property, S.VariableLightCyan);

        // Identifiers
        Set(Group.Variable, S.VariableLightCyan);
        Set(Group.VariableBuiltin, S.KeywordBlue);
        Set(Group.Constant, S.NormalText);
        Set(Group.ConstantBuiltin, S.KeywordBlue);
        Set(Group.ConstantMacro, S.FunctionAmber);
        Set(Group.Namespace, S.NormalText);
        // @symbol           ; symbols or atoms

        // Text
        Set(Group.Text, S.NormalText);
        Set(Group.TextStrong, S.NormalText with { Bold = true });
        Set(Group.TextEmphasis, S.NormalText with { Italic = true });
        Link(Group.TextUnderline, VimSyntax.Underlined);
        Set(Group.TextStrike, S.NormalText with { Strikethrough = true });
        Set(Group.TextTitle, query.GetSourceItems<NeovimEditorHighlightSource.Item>()
                                  .First(x => x.Group == NeovimEditorHighlightSource.Group.Title)
                                  .Style!.Value);
        // @text.literal          ; literal or verbatim text (e.g., inline code)
        // @text.quote            ; text quotations
        // @text.uri              ; URIs (e.g. hyperlinks)
        // @text.math             ; math environments (e.g. `$ ... $` in LaTeX)
        // @text.environment      ; text environments of markup languages
        // @text.environment.name ; text indicating the type of an environment
        // @text.reference        ; text references, footnotes, citations, etc.
        Set(Group.TextTodo, fg: S.NormalText.Background, bg: C.HintGreen);
        Set(Group.TextNote, fg: S.NormalText.Background, bg: C.InfoBlue);
        Set(Group.TextWarning, fg: S.NormalText.Background, bg: C.WarnYellow);
        Set(Group.TextDanger, fg: S.NormalText.Background, bg: C.ErrorRed);
        var diffStyle = query.GetSourceItems<VimCustomGroupSource.Item>()
                             .Where(x => x.Group.StartsWith("diff"))
                             .ToDictionary(x => x.Group, x => x.Style);
        Set(Group.TextDiffAdd, diffStyle["diffAdded"]!.Value);
        Set(Group.TextDiffDelete, diffStyle["diffRemoved"]!.Value);

        // Tags
        Set(Group.Tag, S.KeywordBlue);
        // @tag.attribute ; XML tag attributes
        Set(Group.TagDelimiter, S.CommentGray);

        // Conceal
        // @conceal ; for captures that are only used for concealing

        // Spell
        // @spell   ; for defining regions to be spellchecked
        // @nospell ; for defining regions that should NOT be spellchecked
    }
}