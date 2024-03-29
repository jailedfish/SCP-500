using Exiled.API.Interfaces;


namespace SCP_500.Conf {
    public class Config : IConfig {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
    }
}
