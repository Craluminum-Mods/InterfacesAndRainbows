namespace InterfacesAndRainbows.Configuration;

public interface IConfig<T>
{
    void GetPreviousConfig(T previousConfig);
}