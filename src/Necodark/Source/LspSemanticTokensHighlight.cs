using Sccg.Builtin.Sources;

namespace Necodark.Source;

public class LspSemanticTokensHighlight : LspSemanticTokensSource
{
    public override int Priority => 30; // after NeovimTreesitterHighlight

    protected override void Custom(BuilderQuery query)
    {
        Set(Type.Class, S.TypeGreen);
        Set(Type.Type, S.TypeGreen);
        Set(Type.Struct, S.TypeGreen);
        Set(Type.Enum, S.TypeGreen);

        Set(Type.Namespace, query
                            .GetSourceItems<NeovimTreesitterHighlightSource.Item>()
                            .FirstOrDefault(x => x.Group.name == NeovimTreesitterHighlightSource.Group.Namespace)!
                            .Style!.Value
        );
    }
}