using Sccg.Builtin.Formatters;
using Sccg.Builtin.Writers;
using Necodark.Converter;
using Necodark.Source;

var builder = new Builder
{
    Metadata = Metadata.Default with
    {
        ThemeName = "necodark",
        Author = "ryota2357"
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

// formatter
builder.Use<VimFormatter>();
builder.Use<NeovimFormatter>();

// converter
builder.Use<FilenameConverter>();

// writer
builder.Use<TextFileWriter>();

builder.Build();