using Sccg;

namespace Necodark;

public static class C
{
    public static Color ErrorRed   => new("#ff3129");
    public static Color WarnYellow => new("#fccd2c");
    public static Color InfoBlue   => new("#14b5ff");
    public static Color HintGreen  => new("#72b847");

                                                      // From GitHub WebSite (Dark Mode)
    public static Color GitAdd    => new("#3db34d");  // #3fb950
    public static Color GitChange => new("#d29922");  // #d29922
    public static Color GitDelete => new("#db403d");  // #da3633
}

public static class S
{
    public static Style NormalText       => new(fg: "#edeef2",  bg: "#1a1b1f",  none: true); // 14.84
    public static Style PopupText        => new(fg: "#edeef2",  bg: "#27292f",  none: true); // 12.54
    public static Style HideText         => new(fg: "#39393f",  bg: Color.None, none: true); // 1.50
    public static Style CursorLine       => new(fg: Color.None, bg: "#101115",  none: true);
    public static Style SelectRangeBlue  => new(fg: Color.None, bg: "#334870",  none: true);
    public static Style SelectRangeWhite => new(fg: Color.None, bg: "#525760",  none: true);

    // Syntax
    public static Style KeywordBlue         => new(fg: "#379df1"); // 5.94
    public static Style StatementIndigo     => new(fg: "#8a99ff"); // 6.62
    public static Style FunctionAmber       => new(fg: "#ffe8a3"); // 14.19
    public static Style TypeGreen           => new(fg: "#4bbe75"); // 7.31
    public static Style VariableLightCyan   => new(fg: "#9fe7ff"); // 12.58
    public static Style BooleanLiteralTeal  => new(fg: "#4dcbbb"); // 8.67
    public static Style StringLiteralOrange => new(fg: "#e88e73"); // 7.00
    public static Style NumberLiteralPink   => new(fg: "#fb749c"); // 6.62
    public static Style OperatorSilver      => new(fg: "#cdd3d6"); // 11.38
    public static Style CommentGray         => new(fg: "#5c6370"); // 2.85
}
