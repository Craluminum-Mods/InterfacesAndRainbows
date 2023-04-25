using Vintagestory.API.Client;

namespace InterfacesAndRainbows.Configuration;

public static class ModConfig
{
    public static void ReadConfig<T>(string name, ICoreClientAPI api) where T : IConfig<T>
    {
        var config = LoadOrGenerateConfig<T>(name, api);
        if (config is Config) Patches.PatchGuiStyle(config as Config);
        if (config is Config) Patches.PatchWithHarmony(api, config as Config);
    }

    private static T LoadOrGenerateConfig<T>(string name, ICoreClientAPI api) where T : IConfig<T>
    {
        T config;
        try
        {
            config = LoadConfig<T>(name, api);

            if (config == null)
            {
                GenerateConfig<T>(name, api);
                config = LoadConfig<T>(name, api);
            }
            else
            {
                GenerateConfig(name, api, config);
            }
        }
        catch
        {
            GenerateConfig<T>(name, api);
            config = LoadConfig<T>(name, api);
        }

        return config;
    }

    private static T LoadConfig<T>(string name, ICoreClientAPI api) => api.LoadModConfig<T>(name);

    private static void GenerateConfig<T>(string name, ICoreClientAPI api)
    {
        if (typeof(T).Equals(typeof(Config))) api.StoreModConfig(new Config(), name);
        if (typeof(T).Equals(typeof(ConfigDefault))) api.StoreModConfig(new ConfigDefault(), name);
    }

    private static void GenerateConfig<T>(string name, ICoreClientAPI api, T config) where T : IConfig<T>
    {
        config.GetPreviousConfig(config);
        api.StoreModConfig(config, name);
    }
}