using Exiled.API.Interfaces;


namespace SCP_500 {
    public class Config : IConfig {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        public bool IsSpawnNormaly { get; set; } = true;
        public ushort SpawnChance { get; set; } = 100;
        public int Health { get; set; } = 500;
    }
}
