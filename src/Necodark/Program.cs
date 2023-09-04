using Sccg.Builtin.Formatters;
using Sccg.Builtin.Writers;
using Necodark.Converter;
using Necodark.Source;
using Sccg.Builtin.Converters;

var builder = new Builder
{
    Metadata = Metadata.Default with
    {
        ThemeName = "necodark",
        Author = "ryota2357",
        Version = "0.1.3",
        License = "MIT",
        Repository = "https://github.com/ryota2357/necodark.git",
        Context = new MetadataContext
        {
            {"vscode.displayName", "necodark for VS Code"},
        }
    },
    // LogLevel = LogLevel.Debug
};

// source
builder.Use<Ansi16>();
builder.Use<VimSyntaxHighlight>();
builder.Use<VimEditorHighlight>();
builder.Use<VimFiletypeHighlight>();
builder.Use<NeovimEditorHighlight>();
builder.Use<NeovimTreesitterHighlight>();
builder.Use<NeovimLspDiagnosticHighlight>();
builder.Use<NeovimPluginHighlight>();
builder.Use<VSCodeEditorHightlight>();
builder.Use<TextMateHighlight>();
builder.Use<LspSemanticTokensHighlight>();

// formatter
builder.Use<VimFormatter>();
builder.Use<NeovimFormatter>();
builder.Use<VSCodeFormatter>();

// converter
builder.Use<FilenameConverter>();
builder.Use<MultiTextContentSplitter>();

// writer
builder.Use<TextFileWriter>();

builder.Build();
