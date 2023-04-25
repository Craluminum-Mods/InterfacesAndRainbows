using Vintagestory.API.Client;

namespace InterfacesAndRainbows;

public static class ConfigGroups
{
    public class TextGroup
    {
        public string ActiveButtonTextColor;
        public string ButtonTextColor;
        public string DialogDefaultTextColor;
        public string DisabledTextColor;
        public string DiscoveryTextColor;
        public string ErrorTextColor;
        public string ErrorTextColorHex;
        public string HotbarNumberTextColor;
        public string LinkTextColor;
        public string SuccessTextColor;
        public string SuccessTextColorHex;
        public string WarningTextColor;

        public string DebugInfoText; // CollectibleObject.GetHeldItemInfo
        public string ButterflyNameText; // ItemDeadButterfly.GetHeldItemInfo
        public string HighDamageTierResistantText; // ItemWearable.GetHeldItemInfo

        public TextGroup(bool isDefault = false)
        {
            if (!isDefault) return;
            ActiveButtonTextColor = GuiStyle.ActiveButtonTextColor.ToHex();
            ButtonTextColor = GuiStyle.ButtonTextColor.ToHex();
            DialogDefaultTextColor = GuiStyle.DialogDefaultTextColor.ToHex();
            DisabledTextColor = GuiStyle.DisabledTextColor.ToHex();
            DiscoveryTextColor = GuiStyle.DiscoveryTextColor.ToHex();
            ErrorTextColor = GuiStyle.ErrorTextColor.ToHex();
            ErrorTextColorHex = GuiStyle.ErrorTextColorHex;
            HotbarNumberTextColor = GuiStyle.HotbarNumberTextColor.ToHex();
            LinkTextColor = GuiStyle.LinkTextColor.ToHex();
            SuccessTextColor = GuiStyle.SuccessTextColor.ToHex();
            SuccessTextColorHex = GuiStyle.SuccessTextColorHex;
            WarningTextColor = GuiStyle.WarningTextColor.ToHex();

            DebugInfoText = "#bbbbbb";
            ButterflyNameText = "#ccc";
            HighDamageTierResistantText = "#86aad0";
        }
    }

    public class BackgroundGroup
    {
        public string DialogAlternateBgColor;
        public string DialogDefaultBgColor;
        public string DialogLightBgColor;
        public string DialogStrongBgColor;

        public BackgroundGroup(bool isDefault = false)
        {
            if (!isDefault) return;
            DialogAlternateBgColor = GuiStyle.DialogAlternateBgColor.ToHex();
            DialogDefaultBgColor = GuiStyle.DialogDefaultBgColor.ToHex();
            DialogLightBgColor = GuiStyle.DialogLightBgColor.ToHex();
            DialogStrongBgColor = GuiStyle.DialogStrongBgColor.ToHex();
        }
    }

    public class BarsGroup
    {
        public string FoodBarColor;
        public string HealthBarColor;
        public string OxygenBarColor;
        public string TitleBarColor;
        public string XPBarColor;

        public BarsGroup(bool isDefault = false)
        {
            if (!isDefault) return;
            FoodBarColor = GuiStyle.FoodBarColor.ToHex();
            HealthBarColor = GuiStyle.HealthBarColor.ToHex();
            OxygenBarColor = GuiStyle.OxygenBarColor.ToHex();
            TitleBarColor = GuiStyle.TitleBarColor.ToHex();
            XPBarColor = GuiStyle.XPBarColor.ToHex();
        }
    }

    public class MiscellaneousGroup
    {
        public string ActiveSlotColor;
        public string DialogBorderColor;
        public string DialogHighlightColor;
        public string DialogSlotBackColor;
        public string DialogSlotFrontColor;
        public string MacroIconColor;

        public MiscellaneousGroup(bool isDefault = false)
        {
            if (!isDefault) return;
            ActiveSlotColor = GuiStyle.ActiveSlotColor.ToHex();
            DialogBorderColor = GuiStyle.DialogBorderColor.ToHex();
            DialogHighlightColor = GuiStyle.DialogHighlightColor.ToHex();
            DialogSlotBackColor = GuiStyle.DialogSlotBackColor.ToHex();
            DialogSlotFrontColor = GuiStyle.DialogSlotFrontColor.ToHex();
            MacroIconColor = GuiStyle.MacroIconColor.ToHex();
        }
    }

    public class ColorsGroup
    {
        public string ColorParchment;
        public string ColorRot1;
        public string ColorRot2;
        public string ColorRot3;
        public string ColorRot4;
        public string ColorRot5;
        public string ColorRust1;
        public string ColorRust2;
        public string ColorRust3;
        public string ColorSchematic;
        public string ColorTime1;
        public string ColorTime2;
        public string ColorWood;
        public string DarkBrownColor;

        public ColorsGroup(bool isDefault = false)
        {
            if (!isDefault) return;
            ColorParchment = GuiStyle.ColorParchment.ToHex();
            ColorRot1 = GuiStyle.ColorRot1.ToHex();
            ColorRot2 = GuiStyle.ColorRot2.ToHex();
            ColorRot3 = GuiStyle.ColorRot3.ToHex();
            ColorRot4 = GuiStyle.ColorRot4.ToHex();
            ColorRot5 = GuiStyle.ColorRot5.ToHex();
            ColorRust1 = GuiStyle.ColorRust1.ToHex();
            ColorRust2 = GuiStyle.ColorRust2.ToHex();
            ColorRust3 = GuiStyle.ColorRust3.ToHex();
            ColorSchematic = GuiStyle.ColorSchematic.ToHex();
            ColorTime1 = GuiStyle.ColorTime1.ToHex();
            ColorTime2 = GuiStyle.ColorTime2.ToHex();
            ColorWood = GuiStyle.ColorWood.ToHex();
            DarkBrownColor = GuiStyle.DarkBrownColor.ToHex();
        }
    }

    public class GradientsGroup
    {
        public string[] DamageColorGradient;

        public GradientsGroup(bool isDefault = false)
        {
            if (!isDefault) return;
            DamageColorGradient = GetDefaultDamageColorGradient();
        }

        static string[] GetDefaultDamageColorGradient() => new[]
        {
            "#A7251F",
            "#F01700",
            "#F04900",
            "#F07100",
            "#F0D100",
            "#F0ED00",
            "#E2F000",
            "#AAF000",
            "#71F000",
            "#33F000",
            "#00F06B"
        };
    }
}