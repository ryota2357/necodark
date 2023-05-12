using Sccg.Builtin.Writers;
using Sccg.Core;

namespace Necodark.Converter;

public class FilenameConverter : IContentConverter
{
    public string Name => "Filename";
    public int Priority => 0; // Needs to be run before `MultiTextContentSplitter`

    public IEnumerable<IContent> Convert(List<IContent> contents, BuilderQuery query)
    {
        foreach (var content in contents)
        {
            switch (content)
            {
                case SingleTextContent singleTextContent:
                    yield return Path.GetExtension(singleTextContent.Filename) switch
                    {
                        ".lua" => new SingleTextContent(Path.Join("nvim", singleTextContent.Filename), singleTextContent.Text),
                        ".vim" => new SingleTextContent(Path.Join("vim", singleTextContent.Filename), singleTextContent.Text),
                        _ => new SingleTextContent(Path.Join("other", singleTextContent.Filename), singleTextContent.Text)

                    };
                    break;
                case MultiTextContent multiTextContent:
                {
                    var newDirectory = Path.Join("vscode", multiTextContent.Directory);
                    yield return new MultiTextContent(newDirectory)
                    {
                        Filenames = multiTextContent.Filenames,
                        Texts = multiTextContent.Texts
                    };
                    break;
                }
                default:
                    yield return content;
                    break;
            }
        }
    }
}