using static InterfacesAndRainbows.ConfigGroups;

namespace InterfacesAndRainbows.Configuration;

public class Config : IConfig<Config>
{
    public BackgroundGroup Background = new();
    public BarsGroup Bars = new();
    public TextGroup Text = new();
    public MiscellaneousGroup Miscellaneous = new();
    public ColorsGroup Colors = new();
    public GradientsGroup Gradients = new();

    public void GetPreviousConfig(Config previousConfig)
    {
        Background.DialogAlternateBgColor = previousConfig.Background.DialogAlternateBgColor;
        Background.DialogDefaultBgColor = previousConfig.Background.DialogDefaultBgColor;
        Background.DialogLightBgColor = previousConfig.Background.DialogLightBgColor;
        Background.DialogStrongBgColor = previousConfig.Background.DialogStrongBgColor;
        Bars.FoodBarColor = previousConfig.Bars.FoodBarColor;
        Bars.HealthBarColor = previousConfig.Bars.HealthBarColor;
        Bars.OxygenBarColor = previousConfig.Bars.OxygenBarColor;
        Bars.TitleBarColor = previousConfig.Bars.TitleBarColor;
        Bars.XPBarColor = previousConfig.Bars.XPBarColor;
        Colors.ColorParchment = previousConfig.Colors.ColorParchment;
        Colors.ColorRot1 = previousConfig.Colors.ColorRot1;
        Colors.ColorRot2 = previousConfig.Colors.ColorRot2;
        Colors.ColorRot3 = previousConfig.Colors.ColorRot3;
        Colors.ColorRot4 = previousConfig.Colors.ColorRot4;
        Colors.ColorRot5 = previousConfig.Colors.ColorRot5;
        Colors.ColorRust1 = previousConfig.Colors.ColorRust1;
        Colors.ColorRust2 = previousConfig.Colors.ColorRust2;
        Colors.ColorRust3 = previousConfig.Colors.ColorRust3;
        Colors.ColorSchematic = previousConfig.Colors.ColorSchematic;
        Colors.ColorTime1 = previousConfig.Colors.ColorTime1;
        Colors.ColorTime2 = previousConfig.Colors.ColorTime2;
        Colors.ColorWood = previousConfig.Colors.ColorWood;
        Colors.DarkBrownColor = previousConfig.Colors.DarkBrownColor;
        Gradients.DamageColorGradient = previousConfig.Gradients.DamageColorGradient;
        Miscellaneous.ActiveSlotColor = previousConfig.Miscellaneous.ActiveSlotColor;
        Miscellaneous.DialogBorderColor = previousConfig.Miscellaneous.DialogBorderColor;
        Miscellaneous.DialogHighlightColor = previousConfig.Miscellaneous.DialogHighlightColor;
        Miscellaneous.DialogSlotBackColor = previousConfig.Miscellaneous.DialogSlotBackColor;
        Miscellaneous.DialogSlotFrontColor = previousConfig.Miscellaneous.DialogSlotFrontColor;
        Miscellaneous.MacroIconColor = previousConfig.Miscellaneous.MacroIconColor;
        Text.ActiveButtonTextColor = previousConfig.Text.ActiveButtonTextColor;
        Text.ButtonTextColor = previousConfig.Text.ButtonTextColor;
        Text.DialogDefaultTextColor = previousConfig.Text.DialogDefaultTextColor;
        Text.DisabledTextColor = previousConfig.Text.DisabledTextColor;
        Text.DiscoveryTextColor = previousConfig.Text.DiscoveryTextColor;
        Text.ErrorTextColor = previousConfig.Text.ErrorTextColor;
        Text.ErrorTextColorHex = previousConfig.Text.ErrorTextColorHex;
        Text.HotbarNumberTextColor = previousConfig.Text.HotbarNumberTextColor;
        Text.LinkTextColor = previousConfig.Text.LinkTextColor;
        Text.SuccessTextColor = previousConfig.Text.SuccessTextColor;
        Text.SuccessTextColorHex = previousConfig.Text.SuccessTextColorHex;
        Text.WarningTextColor = previousConfig.Text.WarningTextColor;
    }
}
