using System.Collections.Generic;
using static Vintagestory.API.MathTools.ColorUtil;

namespace InterfacesAndRainbows;

public static class ColorExtensions
{
    public static string ToHex(this double[] obj) => Int2HexBGR(ColorFromRgba(obj));

    public static string[] Ints2HexList(this int[] ints)
    {
        if (ints == null || ints.Length == 0) return null;

        var colors = new List<string>();

        for (int i = 0; i < ints.Length; i++)
        {
            colors.Add(Int2Hex(ints[i]));
        }

        return colors.ToArray();
    }

    public static int[] HexList2Ints(this string[] colors)
    {
        if (colors == null || colors.Length == 0) return null;

        var ints = new List<int>();

        for (int i = 0; i < colors.Length; i++)
        {
            ints.Add(Hex2Int(colors[i]));
        }

        return ints.ToArray();
    }
}