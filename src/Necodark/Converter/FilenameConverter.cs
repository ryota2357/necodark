using Sccg;
using Sccg.Builtin.Writers;
using Sccg.Core;

namespace Necodark.Converter;

public class FilenameConverter : IContentConverter
{
    public string Name => "Filename";
    public int Priority => 10;

    public IEnumerable<IContent> Convert(List<IContent> contents, BuilderQuery query)
    {
        foreach (var content in contents)
        {
            if (content is SingleTextContent singleTextContent)
            {
                yield return Path.GetExtension(singleTextContent.Filename) switch
                {
                    ".lua" => new SingleTextContent(Path.Join("nvim", singleTextContent.Filename), singleTextContent.Text),
                    ".vim" => new SingleTextContent(Path.Join("vim", singleTextContent.Filename), singleTextContent.Text),
                    _ => new SingleTextContent(Path.Join("other", singleTextContent.Filename), singleTextContent.Text)

                };
            }
            else
            {
                yield return content;
            }
        }
    }
}