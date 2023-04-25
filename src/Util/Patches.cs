using static Vintagestory.API.Client.GuiStyle;
using static Vintagestory.API.MathTools.ColorUtil;
using InterfacesAndRainbows.Configuration;
using Vintagestory.API.Client;

namespace InterfacesAndRainbows;

public static class Patches
{
    public static void PatchGuiStyle(Config config)
    {
        if (config?.Background?.DialogAlternateBgColor != null) DialogAlternateBgColor = Hex2Doubles(config.Background.DialogAlternateBgColor);
        if (config?.Background?.DialogDefaultBgColor != null) DialogDefaultBgColor = Hex2Doubles(config.Background.DialogDefaultBgColor);
        if (config?.Background?.DialogLightBgColor != null) DialogLightBgColor = Hex2Doubles(config.Background.DialogLightBgColor);
        if (config?.Background?.DialogStrongBgColor != null) DialogStrongBgColor = Hex2Doubles(config.Background.DialogStrongBgColor);
        if (config?.Bars?.FoodBarColor != null) FoodBarColor = Hex2Doubles(config.Bars.FoodBarColor);
        if (config?.Bars?.HealthBarColor != null) HealthBarColor = Hex2Doubles(config.Bars.HealthBarColor);
        if (config?.Bars?.OxygenBarColor != null) OxygenBarColor = Hex2Doubles(config.Bars.OxygenBarColor);
        if (config?.Bars?.TitleBarColor != null) TitleBarColor = Hex2Doubles(config.Bars.TitleBarColor);
        if (config?.Bars?.XPBarColor != null) XPBarColor = Hex2Doubles(config.Bars.XPBarColor);
        if (config?.Colors?.ColorParchment != null) ColorParchment = Hex2Doubles(config.Colors.ColorParchment);
        if (config?.Colors?.ColorRot1 != null) ColorRot1 = Hex2Doubles(config.Colors.ColorRot1);
        if (config?.Colors?.ColorRot2 != null) ColorRot2 = Hex2Doubles(config.Colors.ColorRot2);
        if (config?.Colors?.ColorRot3 != null) ColorRot3 = Hex2Doubles(config.Colors.ColorRot3);
        if (config?.Colors?.ColorRot4 != null) ColorRot4 = Hex2Doubles(config.Colors.ColorRot4);
        if (config?.Colors?.ColorRot5 != null) ColorRot5 = Hex2Doubles(config.Colors.ColorRot5);
        if (config?.Colors?.ColorRust1 != null) ColorRust1 = Hex2Doubles(config.Colors.ColorRust1);
        if (config?.Colors?.ColorRust2 != null) ColorRust2 = Hex2Doubles(config.Colors.ColorRust2);
        if (config?.Colors?.ColorRust3 != null) ColorRust3 = Hex2Doubles(config.Colors.ColorRust3);
        if (config?.Colors?.ColorSchematic != null) ColorSchematic = Hex2Doubles(config.Colors.ColorSchematic);
        if (config?.Colors?.ColorTime1 != null) ColorTime1 = Hex2Doubles(config.Colors.ColorTime1);
        if (config?.Colors?.ColorTime2 != null) ColorTime2 = Hex2Doubles(config.Colors.ColorTime2);
        if (config?.Colors?.ColorWood != null) ColorWood = Hex2Doubles(config.Colors.ColorWood);
        if (config?.Colors?.DarkBrownColor != null) DarkBrownColor = Hex2Doubles(config.Colors.DarkBrownColor);
        if (config?.Miscellaneous?.ActiveSlotColor != null) ActiveSlotColor = Hex2Doubles(config.Miscellaneous.ActiveSlotColor);
        if (config?.Miscellaneous?.DialogBorderColor != null) DialogBorderColor = Hex2Doubles(config.Miscellaneous.DialogBorderColor);
        if (config?.Miscellaneous?.DialogHighlightColor != null) DialogHighlightColor = Hex2Doubles(config.Miscellaneous.DialogHighlightColor);
        if (config?.Miscellaneous?.DialogSlotBackColor != null) DialogSlotBackColor = Hex2Doubles(config.Miscellaneous.DialogSlotBackColor);
        if (config?.Miscellaneous?.DialogSlotFrontColor != null) DialogSlotFrontColor = Hex2Doubles(config.Miscellaneous.DialogSlotFrontColor);
        if (config?.Miscellaneous?.MacroIconColor != null) MacroIconColor = Hex2Doubles(config.Miscellaneous.MacroIconColor);
        if (config?.Text?.ActiveButtonTextColor != null) ActiveButtonTextColor = Hex2Doubles(config.Text.ActiveButtonTextColor);
        if (config?.Text?.ButtonTextColor != null) ButtonTextColor = Hex2Doubles(config.Text.ButtonTextColor);
        if (config?.Text?.DialogDefaultTextColor != null) DialogDefaultTextColor = Hex2Doubles(config.Text.DialogDefaultTextColor);
        if (config?.Text?.DisabledTextColor != null) DisabledTextColor = Hex2Doubles(config.Text.DisabledTextColor);
        if (config?.Text?.DiscoveryTextColor != null) DiscoveryTextColor = Hex2Doubles(config.Text.DiscoveryTextColor);
        if (config?.Text?.ErrorTextColor != null) ErrorTextColor = Hex2Doubles(config.Text.ErrorTextColor);
        if (config?.Text?.ErrorTextColorHex != null) ErrorTextColorHex = config.Text.ErrorTextColorHex;
        if (config?.Text?.HotbarNumberTextColor != null) HotbarNumberTextColor = Hex2Doubles(config.Text.HotbarNumberTextColor);
        if (config?.Text?.LinkTextColor != null) LinkTextColor = Hex2Doubles(config.Text.LinkTextColor);
        if (config?.Text?.SuccessTextColor != null) SuccessTextColor = Hex2Doubles(config.Text.SuccessTextColor);
        if (config?.Text?.SuccessTextColorHex != null) SuccessTextColorHex = config.Text.SuccessTextColorHex;
        if (config?.Text?.WarningTextColor != null) WarningTextColor = Hex2Doubles(config.Text.WarningTextColor);

        if (config?.Gradients?.DamageColorGradient != null && config?.Gradients?.DamageColorGradient?.Length != 0)
        {
            DamageColorGradient = GetDamageGradient(config.Gradients.DamageColorGradient);
        }
    }

    static int[] GetDamageGradient(string[] hexList)
    {
        int[] colors = hexList.HexList2Ints();
        var ints = new int[100];
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                ints[(10 * i) + j] = ColorOverlay(colors[i], colors[i + 1], (float)j / 10f);
            }
        }
        return ints;
    }

    public static void PatchWithHarmony(ICoreClientAPI api, Config config)
    {
        if (config?.Text?.DebugInfoText != null) api.World.Config.SetString("InterfacesAndRainbows.DebugInfoText", config.Text.DebugInfoText);
        if (config?.Text?.ButterflyNameText != null) api.World.Config.SetString("InterfacesAndRainbows.ButterflyNameText", config.Text.ButterflyNameText);
        if (config?.Text?.HighDamageTierResistantText != null) api.World.Config.SetString("InterfacesAndRainbows.HighDamageTierResistantText", config.Text.HighDamageTierResistantText);
    }
}