using static InterfacesAndRainbows.ConfigGroups;

namespace InterfacesAndRainbows.Configuration;

public class ConfigDefault : IConfig<ConfigDefault>
{
    public BackgroundGroup Background = new(true);
    public BarsGroup Bars = new(true);
    public TextGroup Text = new(true);
    public MiscellaneousGroup Miscellaneous = new(true);
    public ColorsGroup Colors = new(true);
    public GradientsGroup Gradients = new(true);

    public void GetPreviousConfig(ConfigDefault previousConfig) { }
}
