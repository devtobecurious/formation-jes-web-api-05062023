namespace TestConfig.Configs
{
    public class EnemiesConfig
    {
        public int Nb { get; set; }
    }

    public class GameConfig
    {
        public EnemiesConfig Enemies { get; set; }
    }

    public static class ConfigStaticExtensions
    {
        public static void AddCustomOptions(this IServiceCollection service, IConfiguration config)
        {
            var gameConfigSection = config.GetSection("GameConfig");
            service.Configure<GameConfig>(gameConfigSection);
        }
    }
}
