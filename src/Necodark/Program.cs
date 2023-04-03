using Sccg.Builtin.Formatters;
using Sccg.Builtin.Writers;
using Necodark.Converter;
using Necodark.Source;

var builder = new Builder
{
    Metadata = Metadata.Default with
    {
        ThemeName = "necodark",
        Author = "ryota2357",
        Version = "0.1.0",
        License = "MIT",
        Repository = "https://github.com/ryota2357/necodark.git",
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