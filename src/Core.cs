using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;
using InterfacesAndRainbows.Configuration;
using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.GameContent;
using static InterfacesAndRainbows.Configuration.ModConfig;

[assembly: ModInfo("Interfaces And Rainbows",
    Authors = new[] { "Craluminum2413" })]

namespace InterfacesAndRainbows;

class Core : ModSystem
{
    public const string HarmonyID = "craluminum2413.interfacesandrainbows";
    public static ICoreClientAPI _capi;

    public override double ExecuteOrder() => 0;
    public override bool ShouldLoad(EnumAppSide forSide) => forSide == EnumAppSide.Client;

    public override void StartPre(ICoreAPI api)
    {
        base.StartPre(api);
        if (api is not ICoreClientAPI capi) return;
        _capi = capi;

        ReadConfig<ConfigDefault>("ConfigureEverything/InterfacesAndRainbows-Default.json", capi);
        ReadConfig<Config>("ConfigureEverything/InterfacesAndRainbows.json", capi);

        new Harmony(HarmonyID).PatchAll(Assembly.GetExecutingAssembly());

        api.World.Logger.Event("started 'Interfaces And Rainbows' mod");
    }

    public override void Dispose()
    {
        new Harmony(HarmonyID).UnpatchAll();
        base.Dispose();
    }

    [HarmonyPatch]
    public static class Patches
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(CollectibleObject), nameof(CollectibleObject.GetHeldItemInfo))]
        public static IEnumerable<CodeInstruction> CollectibleObject_GetHeldItemInfo_Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            var codes = new List<CodeInstruction>(instructions);

            for (int i = 0; i < codes.Count; i++)
            {
                if (PatchIfMatches(codes, i))
                {
                    yield return codes[i];
                    continue;
                }
                yield return codes[i];
            }
        }
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(ItemDeadButterfly), nameof(ItemDeadButterfly.GetHeldItemInfo))]
        public static IEnumerable<CodeInstruction> ItemDeadButterfly_GetHeldItemInfo_Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            var codes = new List<CodeInstruction>(instructions);

            for (int i = 0; i < codes.Count; i++)
            {
                if (PatchIfMatches(codes, i))
                {
                    yield return codes[i];
                    continue;
                }
                yield return codes[i];
            }
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(ItemCreature), nameof(ItemCreature.GetHeldItemInfo))]
        public static IEnumerable<CodeInstruction> ItemCreature_GetHeldItemInfo_Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            var codes = new List<CodeInstruction>(instructions);

            for (int i = 0; i < codes.Count; i++)
            {
                if (PatchIfMatches(codes, i))
                {
                    yield return codes[i];
                    continue;
                }
                yield return codes[i];
            }
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(ItemWearable), nameof(ItemWearable.GetHeldItemInfo))]
        public static IEnumerable<CodeInstruction> ItemWearable_GetHeldItemInfo_Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            var codes = new List<CodeInstruction>(instructions);

            for (int i = 0; i < codes.Count; i++)
            {
                if (PatchIfMatches(codes, i))
                {
                    yield return codes[i];
                    continue;
                }
                yield return codes[i];
            }
        }
    }

    private static bool PatchIfMatches(List<CodeInstruction> codes, int i)
    {
        string DebugInfoText = _capi.World.Config.GetString("InterfacesAndRainbows.DebugInfoText");
        string ButterflyNameText = _capi.World.Config.GetString("InterfacesAndRainbows.ButterflyNameText");
        string HighDamageTierResistantText = _capi.World.Config.GetString("InterfacesAndRainbows.HighDamageTierResistantText");

        switch (codes[i].operand)
        {
            case string hex when hex.Contains("#bbbbbb") && !string.IsNullOrEmpty(DebugInfoText):
                hex = hex.Replace("#bbbbbb", DebugInfoText);
                codes[i].operand = hex;
                return true;
            case string hex when hex.Contains("#ccc") && !string.IsNullOrEmpty(ButterflyNameText):
                hex = hex.Replace("#ccc", ButterflyNameText);
                codes[i].operand = hex;
                return true;
            case string hex when hex.Contains("#86aad0") && !string.IsNullOrEmpty(ButterflyNameText):
                hex = hex.Replace("#86aad0", HighDamageTierResistantText);
                codes[i].operand = hex;
                return true;
            default:
                return false;
        }
    }
}